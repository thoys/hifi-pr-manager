using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Microsoft.Win32;


// based on https://www.mindstick.com/Articles/1379/uninstall-utility-in-c-sharp-dot-net
namespace HiFi_PR_Manager
{
    public partial class Form1 : Form
    {
        private static string hifiPRInstallerPrefix = "High Fidelity - PR";

        public class DataBind
        {
            public string pPRNumber { get; set; }
            public string pUninstallString { get; set; }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridBind()
        {
            var lstDataBind = new List<DataBind>();
            const string Win64UninstallersLocation = @"Software\Wow6432Node\Microsoft\Windows\CurrentVersion\Uninstall";

            List<Application> apps = new List<Application>();

            RegistryKey rk = Registry.LocalMachine.OpenSubKey(Win64UninstallersLocation);
            foreach (string skName in rk.GetSubKeyNames())
            {
                if (!skName.StartsWith(hifiPRInstallerPrefix))
                {
                    continue;
                }
                RegistryKey sk = rk.OpenSubKey(skName);
                lstDataBind.Add(new DataBind { pPRNumber = skName.Substring(hifiPRInstallerPrefix.Length), pUninstallString = sk.GetValue("UninstallString").ToString() });
            }
            dgvHifiPRInstallers.DataSource = lstDataBind;
            dgvHifiPRInstallers.Columns[0].Width = 332;
            dgvHifiPRInstallers.Columns[1].Width = 248;
            dgvHifiPRInstallers.Columns[0].HeaderText = "PR Build";
            dgvHifiPRInstallers.Columns[1].HeaderText = "Uninstall String";
            btnUninstallSingle.Enabled = true;
        }

        private bool runUninstallString(string uninstallString)
        {
            if (!System.IO.File.Exists(uninstallString))
            {
                return false;
            }
            Process process = new Process();
            process.StartInfo = new ProcessStartInfo(uninstallString, "/S");
            process.Start();
            process.WaitForExit();//Process.Start(uninstallString, "/S");

            return true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WindowsPrincipal myPrincipal = new WindowsPrincipal(WindowsIdentity.GetCurrent());
            if (myPrincipal.IsInRole(WindowsBuiltInRole.Administrator) == false)
            {
                MessageBox.Show("Please start this program as Administrator.");
                Close();
                return;
            }
            dataGridBind();
        }

        private void btnUninstallAll_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dgvrPR in dgvHifiPRInstallers.Rows)
            {
                string selectedUninstallPath = dgvrPR.Cells[1].Value.ToString();
                runUninstallString(selectedUninstallPath);
            }
            dataGridBind();
        }

        private void btnUninstallSingle_Click(object sender, EventArgs e)
        {
            if (dgvHifiPRInstallers.SelectedRows.Count == 0)
            {
                return;
            }
            foreach (DataGridViewRow dgvrPR in dgvHifiPRInstallers.SelectedRows)
            {
                string selectedUninstallPath = dgvrPR.Cells[1].Value.ToString();
                runUninstallString(selectedUninstallPath);
            }
            dataGridBind();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dataGridBind();
        }

        private void dgvHifiPRInstallers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnUninstallSingle.Enabled = true;
        }
    }
}
