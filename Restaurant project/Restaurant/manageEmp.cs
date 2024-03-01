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
    public partial class manageEmp : Form
    {
        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        DataSet ds;
        public manageEmp()
        {
            InitializeComponent();
        }

        private void ManageRest_Load(object sender, EventArgs e)
        {
            string connect1 = "Data Source = ORCL; User Id = scott; Password=tiger;";
            string cmdstr1 = "select * from meal";
            adapter = new OracleDataAdapter(cmdstr1, connect1);
            DataSet ds = new DataSet();
            adapter.Fill(ds);


        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            form1 n = new form1();
            n.ShowDialog();
        }

        private void Btn_addSales_Click(object sender, EventArgs e)
        {

            tb_id.ReadOnly = false;
            tb_name.ReadOnly = false;
            tb_sal.ReadOnly = false;
            tb_add.ReadOnly = false;
            tb_tittle.ReadOnly = false;
            lbl_id.Hide();
            tb_search.Hide();
            btn_search.Hide();
            btn_delete.Hide();
            btn_update.Hide();
            btn_add.Show();
        }

        private void Btn_updateSales_Click(object sender, EventArgs e)
        {
            tb_id.ReadOnly = true;
            tb_name.ReadOnly = false;
            tb_sal.ReadOnly = false;
            tb_add.ReadOnly = false;
            tb_tittle.ReadOnly = false;
            lbl_id.Show();
            tb_search.Show();
            btn_search.Show();
            btn_delete.Hide();
            btn_update.Show();
            btn_add.Hide();

        }

        private void Btn_deleteSales_Click(object sender, EventArgs e)
        {
            tb_id.ReadOnly = true;
            tb_name.ReadOnly = true;
            tb_sal.ReadOnly = true;
            tb_add.ReadOnly = true;
            tb_tittle.ReadOnly = true;
            lbl_id.Show();
            tb_search.Show();
            btn_search.Show();
            btn_delete.Show();
            btn_update.Hide();
            btn_add.Hide();

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            /*adapter = new OracleDataAdapter(cmdstr, ordb);
            adapter.SelectCommand.Parameters.Add("name1", tb_name);
            adapter.SelectCommand.Parameters.Add("job_tittle1", tb_tittle);
            adapter.SelectCommand.Parameters.Add("add1", tb_add);
            adapter.SelectCommand.Parameters.Add("dep_id1", tb_dep);
            adapter.SelectCommand.Parameters.Add("birth_date1", tb_bir);
            adapter.SelectCommand.Parameters.Add("sal1", tb_sal);
            adapter.SelectCommand.Parameters.Add("id1", tb_id);
            adapter.SelectCommand.Parameters.Add("gender1", tb_gender);
            adapter.SelectCommand.Parameters.Add("search_id", tb_id);
            ds = new DataSet();
            adapter.Fill(ds);
            builder = new OracleCommandBuilder(adapter);
            adapter.Update(ds.Tables[0]);*/

        }

        private void tb_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string ordb = "Data Source = ORCL; User Id = scott; Password=tiger;";
            string cmdstr = "select * from EMPLOYE where SSN=:id5)";
            adapter = new OracleDataAdapter(cmdstr, ordb);           
            adapter.SelectCommand.Parameters.Add("id5", tb_id);
            ds = new DataSet();
            adapter.Fill(ds);
            builder = new OracleCommandBuilder(adapter);
            adapter.Update(ds.Tables[0]);
        }
    }
}
