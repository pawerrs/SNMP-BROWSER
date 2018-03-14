using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using SnmpSharpNet;
using System.Net;
using System.Configuration;
using System.Net.Sockets;

namespace SNMP_BROWSER
{
    public partial class Form1 : Form
    {
        public List<UdpTarget> targets;
        public List<AgentParameters> parameters;
        public string selectedNodetext;
        public string OIDvalue;

        public Form1()
        {
            InitializeComponent();
            comboBoxOperations.Items.Add("Get");
            comboBoxOperations.Items.Add("GetNext");
            comboBoxOperations.Items.Add("GetTable");
            imageList.Images.Add(Properties.Resources.Folder);
            imageList.Images.Add(Properties.Resources.key);
            imageList.Images.Add(Properties.Resources.entry);
            imageList.Images.Add(Properties.Resources.listek);
            imageList.Images.Add(Properties.Resources.paper);
            imageList.Images.Add(Properties.Resources.table);
            treeView1.ImageList = imageList;
            InitializeMIBTree();


            targets = new List<UdpTarget>();
            parameters = new List<AgentParameters>();

            Dictionary<Oid, AsnType> result = new Dictionary<Oid, AsnType>();
            List<string> OIDslist = new List<string>();
            AgentSNMP();

            backgroundWorker1.WorkerSupportsCancellation = true;
            backgroundWorker2.RunWorkerAsync();
        }

        public void addRowToDataGridViewresultsofget(string OID, string value, string type, string IP)
        {
            dataGridViewResults.Rows.Add(OID, value, type, IP);
        }

        private void buttonGO_Click(object sender, EventArgs e)
        {
            if (comboBoxOperations.Text.Equals("Get"))
            {
                string host = textBoxAddress.Text;
                if (host == "localhost")
                    host = "127.0.0.1";

                SnmpPacket result = Program.getRequest(OIDvalue, host, targets[0], parameters[0]);

                if (result == null)
                {
                    MessageBox.Show("Failure in communiacation with agent");
                }
                else
                {

                    if (result.Pdu.ErrorStatus != 0)
                    {
                        MessageBox.Show("Pdu Error Status != 0");
                    }
                    else
                    {
                        string OIDget = result.Pdu.VbList[0].Oid.ToString();
                        var name = Program.MIbsList.FirstOrDefault(x => x.Value == "." + OIDget).Key;
                        string value = result.Pdu.VbList[0].Value.ToString();
                        

                        string valuetype = result.Pdu.VbList[0].Value.GetType().ToString();
                        char[] delimiter = { '.' };
                        string[] words = valuetype.Split(delimiter);
                        string address = textBoxAddress.Text.ToString() + ": " + ConfigurationManager.AppSettings["port"].ToString();
                        addRowToDataGridViewresultsofget(name, value, words[1], address);
                    }
                }
            }
            else if (comboBoxOperations.Text.Equals("GetNext"))
            {
                string host = textBoxAddress.Text;
                if (host == "localhost")
                    host = "127.0.0.1";

                SnmpPacket result = Program.getNextRequest(OIDvalue, host, targets[0], parameters[0]);

                if (result == null)
                {
                    MessageBox.Show("Failure in communiacation with agent");
                }
                else
                {
                    if (result.Pdu.ErrorStatus != 0)
                    {
                        MessageBox.Show("Pdu Error Status != 0");
                    }
                    else
                    {
                        Program.MIbsList.TryGetValue(selectedNodetext, out OIDvalue);
                        string OIDget = result.Pdu.VbList[0].Oid.ToString();
                        var name = Program.MIbsList.FirstOrDefault(x => x.Value == "." + OIDget).Key;
                        string value = result.Pdu.VbList[0].Value.ToString();
                        string valuetype = result.Pdu.VbList[0].Value.GetType().ToString();
                        char[] delimiter = { '.' };
                        string[] words = valuetype.Split(delimiter);
                        string address = textBoxAddress.Text.ToString() + ": " + ConfigurationManager.AppSettings["port"].ToString();
                        addRowToDataGridViewresultsofget(name, value, words[1], address);
                    }
                }
            }
            else if (comboBoxOperations.Text.Equals("GetTable"))
            {
                string host = textBoxAddress.Text;
                if (host == "localhost")
                    host = "127.0.0.1";

                GetTable(host, parameters[0], textBoxOID.Text, dataGridView1);
                tabControl1.SelectedTab = tableView;
            }
            int counter = dataGridViewResults.Rows.Count;

            if (counter > 2)
            {
                UpdateTextBoxOID();
            }
        }

        public void AgentSNMP()
        {
            IpAddress agent = new IpAddress("127.0.0.1");
            UdpTarget target = new UdpTarget((IPAddress)agent, 161, 2000, 1);
            targets.Add(target);
            OctetString hosts = new OctetString(System.Configuration.ConfigurationManager.AppSettings["community"]);
            AgentParameters param = new AgentParameters(hosts);
            parameters.Add(param);
            param.Version = SnmpVersion.Ver1;
        }

        private void InitializeMIBTree()
        {
            Program.ReadingFromFile();
            List<TreeNode> treeNodeList = new List<TreeNode>();
            int length = 0;
            string letter = String.Empty;

            foreach (KeyValuePair<string, string> var in Program.MIbsList)
            {
                if (var.Key.Equals("mgmt"))
                {
                    treeView1.Nodes.Add(var.Key);
                    treeNodeList.Add(treeView1.Nodes[0]);
                }
                else
                {
                    Program.LevelsList.TryGetValue(var.Key, out length);
                    Program.IconsList.TryGetValue(var.Key, out letter);

                    if (treeNodeList.Count > length)
                    {
                        treeNodeList[length - 1].Nodes.Add(var.Key);
                        treeNodeList[length] = treeNodeList[length - 1].Nodes[treeNodeList[length - 1].Nodes.Count - 1];
                        treeNodeList[length].ImageIndex = 1;
                    }
                    else
                    {
                        treeNodeList[length - 1].Nodes.Add(var.Key);
                        treeNodeList.Add(treeNodeList[length - 1].Nodes[treeNodeList[length - 1].Nodes.Count - 1]);
                    }
                }

                switch (letter)
                {
                    case "F":
                        treeNodeList[length - 1].Nodes[treeNodeList[length - 1].Nodes.Count - 1].ImageIndex = 0;
                        treeNodeList[length - 1].Nodes[treeNodeList[length - 1].Nodes.Count - 1].SelectedImageIndex = 0;
                        break;
                    case "K":
                        treeNodeList[length - 1].Nodes[treeNodeList[length - 1].Nodes.Count - 1].ImageIndex = 1;
                        treeNodeList[length - 1].Nodes[treeNodeList[length - 1].Nodes.Count - 1].SelectedImageIndex = 1;
                        break;
                    case "E":
                        treeNodeList[length - 1].Nodes[treeNodeList[length - 1].Nodes.Count - 1].ImageIndex = 2;
                        treeNodeList[length - 1].Nodes[treeNodeList[length - 1].Nodes.Count - 1].SelectedImageIndex = 2;
                        break;
                    case "L":
                        treeNodeList[length - 1].Nodes[treeNodeList[length - 1].Nodes.Count - 1].ImageIndex = 3;
                        treeNodeList[length - 1].Nodes[treeNodeList[length - 1].Nodes.Count - 1].SelectedImageIndex = 3;
                        break;
                    case "P":
                        treeNodeList[length - 1].Nodes[treeNodeList[length - 1].Nodes.Count - 1].ImageIndex = 4;
                        treeNodeList[length - 1].Nodes[treeNodeList[length - 1].Nodes.Count - 1].SelectedImageIndex = 4;
                        break;

                    case "T":
                        treeNodeList[length - 1].Nodes[treeNodeList[length - 1].Nodes.Count - 1].ImageIndex = 5;
                        treeNodeList[length - 1].Nodes[treeNodeList[length - 1].Nodes.Count - 1].SelectedImageIndex = 5;
                        break;
                }
            }
        }

        void treeView1_NodeMouseClick(Object sender, TreeNodeMouseClickEventArgs e)
        {
            MessageBox.Show(e.Node.Text);
        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            textBoxOID.Clear();
            selectedNodetext = e.Node.Text.ToString();
            Program.MIbsList.TryGetValue(selectedNodetext, out OIDvalue);
            textBoxOID.AppendText(OIDvalue);
        }
        private void UpdateTextBoxOID()

        {
            int rowIndex = dataGridViewResults.Rows.Count - 2;
            DataGridViewRow selectedRow = dataGridViewResults.Rows[rowIndex];
            Program.MIbsList.TryGetValue(Convert.ToString(selectedRow.Cells[0].Value), out OIDvalue);

            try
            {
                textBoxOID.Clear();
                textBoxOID.AppendText(OIDvalue);
            }
            catch (Exception)
            { 
                MessageBox.Show("You can not use getNext to a table!");
            }
        }

        private void GetTable(String host, AgentParameters param, String tableOID, DataGridView table)
        {
            table.Rows.Clear();
            table.Refresh();
            Dictionary<String, Dictionary<uint, AsnType>> result = new Dictionary<String, Dictionary<uint, AsnType>>();
            List<uint> tableColumns = new List<uint>();
            List<string> tableRows = new List<string>();
            IpAddress peer = new IpAddress(host);

            if (!peer.Valid)
            {
                MessageBox.Show("Unable to resolve name or error in address for peer: {0}", host);
                return;
            }
            UdpTarget target = new UdpTarget((IPAddress)peer);
            Oid startOid = new Oid(tableOID);
            startOid.Add(1);
            Pdu nextPdu = Pdu.GetNextPdu();
            nextPdu.VbList.Add(startOid);
            Oid curOid = (Oid)startOid.Clone();
            List<string> colNames = new List<string>();
            string searchOid = "." + startOid.ToString();

            foreach (KeyValuePair<string, string> kvp in Program.MIbsList)
            {
                if (kvp.Value.Contains(searchOid) && !kvp.Value.Equals(searchOid))
                    colNames.Add(kvp.Key);
            }

            while (startOid.IsRootOf(curOid))
            {
                SnmpPacket res = null;

                try
                {
                    res = target.Request(nextPdu, param);
                }
                catch (Exception e)
                {
                    MessageBox.Show("Request failed: {0}", e.Message);
                    target.Close();
                    return;
                }

                if (res.Pdu.ErrorStatus != 0)
                {
                    MessageBox.Show("SNMP agent returned error " + res.Pdu.ErrorStatus + " for request Vb index " + res.Pdu.ErrorIndex);
                    target.Close();
                    return;
                }

                foreach (Vb v in res.Pdu.VbList)
                {
                    curOid = (Oid)v.Oid.Clone();

                    if (startOid.IsRootOf(v.Oid))
                    {
                        uint[] childOids = Oid.GetChildIdentifiers(startOid, v.Oid);

                        uint[] instance = new uint[childOids.Length - 1];
                        Array.Copy(childOids, 1, instance, 0, childOids.Length - 1);
                        String strInst = InstanceToString(instance);
                        uint column = childOids[0];

                        if (!tableColumns.Contains(column))
                            tableColumns.Add(column);

                        if (result.ContainsKey(strInst))
                        {
                            result[strInst][column] = (AsnType)v.Value.Clone();
                        }
                        else
                        {
                            result[strInst] = new Dictionary<uint, AsnType>();
                            result[strInst][column] = (AsnType)v.Value.Clone();
                        }
                    }
                    else { break; }
                }

                if (startOid.IsRootOf(curOid))
                {
                    nextPdu.VbList.Clear();
                    nextPdu.VbList.Add(curOid);
                }
            }
            target.Close();

            if (result.Count <= 0)
            {
                MessageBox.Show("No results returned.");
            }
            else
            {
                table.ColumnCount = tableColumns.Count + 1;
                table.Columns[0].Name = "Instance";

                for (int i = 0; i < tableColumns.Count; i++)
                {
                    //table.Columns[i + 1].Name = "Column id " + tableColumns[i];
                    table.Columns[i + 1].Name = colNames[i];
                }

                foreach (KeyValuePair<string, Dictionary<uint, AsnType>> kvp in result)
                {
                    tableRows.Add(kvp.Key);
                    foreach (uint column in tableColumns)
                    {
                        if (kvp.Value.ContainsKey(column))
                        {
                            tableRows.Add(kvp.Value[column].ToString());
                        }
                        else
                        {
                            tableRows.Add("");
                        }
                    }
                    table.Rows.Add(tableRows.ToArray());
                    tableRows.Clear();
                }
            }
        }

        public static string InstanceToString(uint[] instance)
        {
            StringBuilder str = new StringBuilder();

            foreach (uint v in instance)
            {
                if (str.Length == 0)
                    str.Append(v);
                else
                    str.AppendFormat(".{0}", v);
            }
            return str.ToString();
        }

        private void buttonObserve_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy != true)
            {
                backgroundWorker1.RunWorkerAsync();
            }
            else
            {
                MessageBox.Show("One of objects is already observed! You cannot " +
                                    "observe multiple objects at the same time!", "WARNING", 
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, 
                                            (MessageBoxOptions)0x40000);
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            string tempOIDvalue = OIDvalue;

            ObserveWindow tempWindow = new ObserveWindow();
            BeginInvoke(new Action(() => {
                tempWindow.Show();
                tempWindow.ipText = textBoxAddress.Text.ToString() + ": " + ConfigurationManager.AppSettings["port"].ToString();
            }));

            while (!tempWindow.IsDisposed)
            {
                if (worker.CancellationPending == true)
                {
                    BeginInvoke(new Action(() => { tempWindow.Close(); }));
                    e.Cancel = true;
                    break;
                }
                else
                {
                    SnmpPacket result = Program.getRequest(tempOIDvalue, "127.0.0.1", targets[0], parameters[0]);

                    if (result == null)
                    {
                        BeginInvoke(new Action(() => { tempWindow.Close(); }));
                        MessageBox.Show("Failure in communiacation with agent", "ERROR", MessageBoxButtons.OK, 
                            MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, (MessageBoxOptions)0x40000);
                        e.Cancel = true;
                        break;
                    }
                    else
                    {
                        if (result.Pdu.ErrorStatus != 0)
                        {
                            BeginInvoke(new Action(() => { tempWindow.Close(); }));
                            MessageBox.Show("Pdu Error Status != 0", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error,
                                 MessageBoxDefaultButton.Button1, (MessageBoxOptions)0x40000);
                            e.Cancel = true;
                            break;
                        }
                        else
                        {
                            string OIDget = result.Pdu.VbList[0].Oid.ToString();
                            string valuetype = result.Pdu.VbList[0].Value.GetType().ToString();
                            char[] delimiter = { '.' };
                        string[] words = valuetype.Split(delimiter);
                            BeginInvoke(new Action(() => {
                                tempWindow.oidText = Program.MIbsList.FirstOrDefault(x => x.Value == "." + OIDget).Key;
                                tempWindow.typeText = words[1];
                                tempWindow.valueText = result.Pdu.VbList[0].Value.ToString();
                                tempWindow.timeText = DateTime.UtcNow.ToString("HH:mm:ss.fff");
                            }));
                        }
                    }
                }
                System.Threading.Thread.Sleep(500); 
            }
        }
        /*
        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            IPEndPoint ipep = new IPEndPoint(IPAddress.Any, 162);
            EndPoint ep = (EndPoint)ipep;
            socket.Bind(ep);
            socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReceiveTimeout, 0);
            bool run = true;
            int inlen = -1;

            while (run)
            {
                byte[] indata = new byte[16 * 1024];
                IPEndPoint peer = new IPEndPoint(IPAddress.Any, 0);
                EndPoint inep = (EndPoint)peer;
                try
                {
                    inlen = socket.ReceiveFrom(indata, ref inep);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception {0}", ex.Message);
                    inlen = -1;
                }
                if (inlen > 0)
                {
                    // Check protocol version int 
                    int ver = SnmpPacket.GetProtocolVersion(indata, inlen);
                    if (ver == (int)SnmpVersion.Ver1)
                    {
                        // Parse SNMP Version 1 TRAP packet 
                        SnmpV1TrapPacket pkt = new SnmpV1TrapPacket();
                        pkt.decode(indata, inlen);
                        string message = "";
                        message += "** SNMP Version 1 TRAP received from: " + inep.ToString() + Environment.NewLine;
                        message += "*** Trap generic: " + pkt.Pdu.Generic + Environment.NewLine;
                        message += "*** Trap specific: " + pkt.Pdu.Specific + Environment.NewLine;
                        message += "*** Agent address: " + pkt.Pdu.AgentAddress.ToString() + Environment.NewLine;
                        message += "*** Timestamp: " + pkt.Pdu.TimeStamp.ToString() + Environment.NewLine;
                        message += "*** VarBind count: " + pkt.Pdu.VbList.Count + Environment.NewLine;
                        message += "*** VarBind content:" + Environment.NewLine;
                        foreach (Vb v in pkt.Pdu.VbList)
                        {
                            message += "**** " + v.Oid.ToString() + " " + SnmpConstants.GetTypeName(v.Value.Type) + " : " + v.Value.ToString() + Environment.NewLine;
                        }
                        message += "** End of SNMP Version 1 TRAP data.";
                        MessageBox.Show(message, "TRAP", MessageBoxButtons.OK, MessageBoxIcon.Information,
                                        MessageBoxDefaultButton.Button1, (MessageBoxOptions)0x40000);
                    }
                    else
                    {
                        // Parse SNMP Version 2 TRAP packet 
                        SnmpV2Packet pkt = new SnmpV2Packet();
                        pkt.decode(indata, inlen);
                        string message = "";
                        message += "** SNMP Version 2 TRAP received from: " +  inep.ToString() + Environment.NewLine;
                        if ((SnmpSharpNet.PduType)pkt.Pdu.Type != PduType.V2Trap)
                        {
                            Console.WriteLine("*** NOT an SNMPv2 trap ****");
                        }
                        else
                        {
                            message += "*** Community: " + pkt.Community.ToString() + Environment.NewLine;
                            message += "*** VarBind count: " + pkt.Pdu.VbList.Count + Environment.NewLine;
                            message += "*** VarBind content:" + Environment.NewLine;
                            foreach (Vb v in pkt.Pdu.VbList)
                            {
                                message += "**** " + v.Oid.ToString() + " " + SnmpConstants.GetTypeName(v.Value.Type) + " : " + v.Value.ToString() + Environment.NewLine;
                            }
                            message += "** End of SNMP Version 2 TRAP data.";
                            MessageBox.Show(message, "TRAP", MessageBoxButtons.OK, MessageBoxIcon.Information,
                                            MessageBoxDefaultButton.Button1, (MessageBoxOptions)0x40000);
                        }
                    }
                }
                else
                {
                    if (inlen == 0)
                        Console.WriteLine("Zero length packet received.");
                }
                System.Threading.Thread.Sleep(10);
            }
        }*/

        private void trapButton_Click(object sender, EventArgs e)
        {
            TrapAgent agent = new TrapAgent();

            // Variable Binding collection to send with the trap
            VbCollection col = new VbCollection();
            col.Add(new Oid("1.3.6.1.2.1.1.1.0"), new OctetString("Test string"));
            col.Add(new Oid("1.3.6.1.2.1.1.2.0"), new Oid("1.3.6.1.9.1.1.0"));
            col.Add(new Oid("1.3.6.1.2.1.1.3.0"), new TimeTicks(2324));
            col.Add(new Oid("1.3.6.1.2.1.1.4.0"), new OctetString("Milan"));

            // Send the trap to the localhost port 162
            agent.SendV1Trap(new IpAddress("localhost"), 162, "public",
                             new Oid("1.3.6.1.2.1.1.1.0"), new IpAddress("127.0.0.1"),
                             SnmpConstants.LinkUp, 0, 13432, col);
        }
    }
}