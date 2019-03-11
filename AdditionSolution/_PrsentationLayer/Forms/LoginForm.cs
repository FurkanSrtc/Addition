using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _PrsentationLayer.ServiceReference;

namespace _PrsentationLayer.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        AdditionServiceClient client = new AdditionServiceClient();

        private ServiceReference.Garson _garson;

        public ServiceReference.Garson Garson
        {
            get { return _garson; }
        }




        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Uygulamdan çıkmak istediğinize emin misniz?", "ONAY", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            switch (result)
            {
                case DialogResult.None:
                    break;
                case DialogResult.OK:
                    break;
                case DialogResult.Cancel:
                    break;
                case DialogResult.Abort:
                    break;
                case DialogResult.Retry:
                    break;
                case DialogResult.Ignore:
                    break;
                case DialogResult.Yes:
                    Application.Exit();
                    break;
                case DialogResult.No:
                    break;
                default:
                    break;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var garson = client.GetGarson(txtUsername.Text, txtPassword.Text);
            if (garson != null)
            {
                _garson = garson;
                MainForm main = new MainForm(this);
                main.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı bulunamadı!", "UYARI", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }
    }
}
