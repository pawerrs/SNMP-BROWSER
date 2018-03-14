using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SnmpSharpNet;
using System.Net;
using System.IO;
using System.Text;

namespace SNMP_BROWSER
{
   public class Program
    {
        // lista OID + nazwa
        public static Dictionary<string, string> MIbsList= new Dictionary<string, string>();

        //lista nazwa + numer poziomu
        public static Dictionary<string, int> LevelsList = new Dictionary<string, int>();

        //lista nazwa + symbol graficzny
        public static Dictionary<string, string> IconsList = new Dictionary<string, string>();

        

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
          
        }

        public static SnmpPacket getRequest(string OID, string host, UdpTarget target, AgentParameters param)
        {
            Pdu pdu = new Pdu(PduType.Get);
            pdu.VbList.Add(OID); 
            SnmpPacket result = (SnmpPacket)target.Request(pdu, param);
            return result;
        }

        
        public static SnmpPacket getNextRequest(string OID, string host, UdpTarget target, AgentParameters param)
        {
            Pdu pdu = new Pdu(PduType.GetNext);
            pdu.VbList.Add(OID);
            SnmpPacket result = (SnmpPacket)target.Request(pdu, param);
            return result;
        }

        public static void ReadingFromFile()
        {
            var path = System.Configuration.ConfigurationManager.AppSettings["path"];

            try
            {
                string line;
                var fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
                using (var StreamReader = new StreamReader(fileStream, Encoding.UTF8))
                {

                    MIbsList.Add("mgmt", ".1.3.6.1.2");
                    IconsList.Add("mgmt", "F");
                    LevelsList.Add("mgmt", 0);

                    while ((line = StreamReader.ReadLine()) != null)
                    {
                        string[] lines_array = line.Split('#');
                        MIbsList.Add(lines_array[2], lines_array[1]);
                        IconsList.Add(lines_array[2], lines_array[0]);
                        LevelsList.Add(lines_array[2], Int32.Parse(lines_array[3]));
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

    }
}
