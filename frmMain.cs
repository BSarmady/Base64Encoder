using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Base64 {
    public partial class frmMain: Form {

        private const string AppName = "Base64";
        private const string AppTitle = "Base64 Encode And Decode";
        private const string AppRegistryKey = @"Software\JGhost\" + AppName;

        private bool Converting = false;

        public frmMain() {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e) {
            this.Icon = Icon.ExtractAssociatedIcon(System.Reflection.Assembly.GetExecutingAssembly().Location);
            this.Text = AppTitle;
            Reg.LoadWindowPos(AppRegistryKey, this);
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e) {
            Reg.SaveWindowPos(AppRegistryKey, this);

        }

        private void edt_base64string_TextChanged(object sender, EventArgs e) {
            try {
                if (Converting)
                    return;
                Converting = true;
                edt_base64string.ForeColor = Color.Black;
                byte[] s = Convert.FromBase64String(edt_base64string.Text.Replace("\r", "").Replace("\n", "").Replace("\t", "").Replace(" ", ""));
                for (int i = 0;i < s.Length;i++) {
                    if (s[i] == '\0') {
                        s[i] = (byte) '?';
                    }
                }

                edt_plain_text.Text = Encoding.UTF8.GetString(s);
            } catch (Exception ex) {
                edt_plain_text.ForeColor = Color.Red;
                edt_plain_text.Text = ex.ToString();
            }
            Converting = false;
        }

        private void edt_plain_text_TextChanged(object sender, EventArgs e) {
            try {
                if (Converting)
                    return;
                Converting = true;
                edt_base64string.ForeColor = Color.Black;
                edt_base64string.Text = Convert.ToBase64String(Encoding.UTF8.GetBytes(edt_plain_text.Text));
            } catch (Exception ex) {
                edt_base64string.ForeColor = Color.Red;
                edt_base64string.Text = ex.ToString();
            }
            Converting = false;
        }

        private void btnFile_Click(object sender, EventArgs e) {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK) {
                File.WriteAllText(ofd.FileName + ".fromBase64.txt", Encoding.UTF8.GetString(Convert.FromBase64String(File.ReadAllText(ofd.FileName).Replace("\r", "").Replace("\n", "").Replace("\t", "").Replace(" ", ""))));
            }
        }


    }
}
