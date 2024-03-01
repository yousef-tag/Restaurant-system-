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
    public partial class crystal : Form
    {
        CrystalReport1 cr;   
        public crystal()
        {
            InitializeComponent();
        }     
        private void crystal_Load(object sender, EventArgs e)
        {
            cr = new CrystalReport1();
            foreach (ParameterDiscreteValue v in cr.ParameterFields[0].DefaultValues)
                emp_comp.Items.Add(v.Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cr.SetParameterValue(0, emp_comp.Text);   
            crystalReportViewer1.ReportSource = cr;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            manageEmp_disconnected n = new manageEmp_disconnected();
            n.ShowDialog();
        }
    }
}
