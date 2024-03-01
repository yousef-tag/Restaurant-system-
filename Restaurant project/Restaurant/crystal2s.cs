using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using CrystalDecisions.Shared;
namespace Restaurant
{
    public partial class crystal2 : Form
    {
        CrystalReport2 cr;
        public crystal2()
        {
            InitializeComponent();
        }     
       

        private void crystal2_Load(object sender, EventArgs e)
        {
            cr = new CrystalReport2();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            crystalReportViewer2.ReportSource = cr;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            manageEmp_disconnected n = new manageEmp_disconnected();
            n.ShowDialog();
        }
    }
}
