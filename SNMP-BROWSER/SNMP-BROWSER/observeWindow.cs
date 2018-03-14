using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SNMP_BROWSER
{
    public partial class ObserveWindow : Form
    {
        public string typeText
        {
            get
            { return typeTextBox.Text; }
            set
            { typeTextBox.Text = value; }
        }
        public string oidText
        {
            get
            { return oidTextBox.Text; }
            set
            { oidTextBox.Text = value; }
        }
        public string ipText
        {
            get
            { return ipTextBox.Text; }
            set
            { ipTextBox.Text = value; }
        }
        public string valueText
        {
            get
            { return valueTextBox.Text; }
            set
            { valueTextBox.Text = value; }
        }

        public string timeText
        {
            get
            { return timeTextBox.Text; }
            set
            { timeTextBox.Text = value; }
        }

        public ObserveWindow()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
