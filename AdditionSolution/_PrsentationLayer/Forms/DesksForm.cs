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
    public partial class DesksForm : Form
    {
        public DesksForm()
        {
            InitializeComponent();
        }

        AdditionServiceClient client = new AdditionServiceClient();

        private void DesksForm_Load(object sender, EventArgs e)
        {
            foreach (var item in client.Masalar())
            {
                Button button = new Button
                {
                    Name = item.Id.ToString(),
                    Text = item.MasaAdi,
                    Width = 150,
                    Height = 150,
                    BackColor = Color.Green
                };
                deskLayout.Controls.Add(button);
            }
        }
    }
}
