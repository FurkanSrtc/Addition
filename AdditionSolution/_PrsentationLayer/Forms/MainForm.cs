using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _PrsentationLayer.Forms
{
    public partial class MainForm : Form
    {
        private LoginForm _loginForm;
        public MainForm(LoginForm loginForm)
        {
            _loginForm = loginForm;
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lblActiveUser.Text = string.Format("Aktif kullanıcı bilgisi: {0} {1}", _loginForm.Garson.Ad, _loginForm.Garson.Soyad);
        }

        private void masaListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DesksForm form = new DesksForm();
            form.MdiParent = this;
            form.Show();
        }
    }
}
