using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            createOrder n = new createOrder();
            n.ShowDialog();
        }

        private void Btn_mRest_Click(object sender, EventArgs e)
        {

            this.Hide();
            manageRest n = new manageRest();
            n.ShowDialog();

        }

        private void Btn_mEmp_Click(object sender, EventArgs e)
        {

            this.Hide();
            manageEmp_disconnected x = new manageEmp_disconnected();
            x.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.SetStyle(
    ControlStyles.AllPaintingInWmPaint |
    ControlStyles.DoubleBuffer,
    true);
        }

        private void createOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            createOrder n = new createOrder();
            n.ShowDialog();
        }

        private void manageRestaurantToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Hide();
            manageRest n = new manageRest();
            n.ShowDialog();
        }

        private void manageEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            manageEmp_disconnected x = new manageEmp_disconnected();
            x.ShowDialog();
        }
    }
}
