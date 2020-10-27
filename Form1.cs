using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace l1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Microsoft.Win32.RegistryKey oRegistryKey = null;

            oRegistryKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey
                ("SOFTWARE\\AliFatemeh\\Licencing\\Licence",
                false);
            if (oRegistryKey == null)
            {
                oRegistryKey=Microsoft.Win32.Registry.LocalMachine.CreateSubKey
                ("SOFTWARE\\AliFatemeh\\Licencing\\Licence",
                Microsoft.Win32.RegistryKeyPermissionCheck.ReadWriteSubTree);

                oRegistryKey.SetValue("Key", "سلام");
            }
            oRegistryKey.Close();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
                        Microsoft.Win32.RegistryKey oRegistryKey = null;

            oRegistryKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey
                ("SOFTWARE\\AliFatemeh",
                false);
            if (oRegistryKey != null)
            {
                Microsoft.Win32.Registry.LocalMachine.DeleteSubKeyTree("SOFTWARE\\AliFatemeh");
                oRegistryKey.Close();
            }
        }
    }
}
