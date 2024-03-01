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


namespace Restaurant
{
    public partial class manageEmp_disconnected : Form
    {
        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        DataSet ds;


        public manageEmp_disconnected()
        {
            InitializeComponent();
        }

        private void manageEmp_disconnected_Load(object sender, EventArgs e)
        {
            string constr = "Data Source = ORCL; User Id = scott; Password=tiger;";
            string cmdstr = "select * from EMPLOYEE )";
            adapter = new OracleDataAdapter(cmdstr, constr);
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            builder = new OracleCommandBuilder(adapter);
            adapter.Update(ds.Tables[0]);
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            form1 n = new form1();
            n.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            crystal n = new crystal();
            n.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            crystal2 n = new crystal2();
            n.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
