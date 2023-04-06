using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lottery
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTicket_Click(object sender, EventArgs e)
        {
            DB.AddLottery(txtName.Text,txtSurname.Text,int.Parse(txtTicketNumber.Text));
        }

      

        private void btnDice_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtSurname.Text))) { 
            Random rnd = new Random();
            txtTicketNumber.Text = rnd.Next(100000, 999999).ToString();
            }
            else
            {
                MessageBox.Show("Ad ve Soyad boş geçilemez!");
            }
        }

        private void btnControl_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
