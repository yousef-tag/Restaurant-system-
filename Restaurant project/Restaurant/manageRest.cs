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
    public partial class manageRest : Form
    {
        string ordb = "Data Source = ORCL; User Id = scott; Password=tiger;";
        OracleConnection con;
        public manageRest()
        {
            InitializeComponent();
        }

        private void Btn_updateitm_Click(object sender, EventArgs e)
        {
            tb_name.ReadOnly = false;
            tb_type.ReadOnly = false;
            tb_cost.ReadOnly = false;
            tb_size.ReadOnly = false;
            tb_calories.ReadOnly = false;
            tb_ord_num.ReadOnly = false;
            lbl_id.Show();
            tb_search.Show();
            btn_search.Show();
            btn_delete.Hide();
            
            btn_add.Hide();

        }

        private void Btn_additm_Click(object sender, EventArgs e)
        {

            tb_name.ReadOnly = false;
            tb_type.ReadOnly = false;
            tb_cost.ReadOnly = false;
            tb_size.ReadOnly = false;
            tb_calories.ReadOnly = false;
            tb_ord_num.ReadOnly = false;
            lbl_id.Hide();
            tb_search.Hide();
            btn_search.Hide();
            btn_delete.Hide();
            
            btn_add.Show();

            
        }

        private void Btn_deleteitm_Click(object sender, EventArgs e)
        {
            tb_name.ReadOnly = true;
            tb_type.ReadOnly = true;
            tb_cost.ReadOnly = true;
            tb_size.ReadOnly = true;
            tb_calories.ReadOnly = true;
            tb_ord_num.ReadOnly = true;
            lbl_id.Show();
            tb_search.Show();
            btn_search.Show();
            btn_delete.Show();
            
            btn_add.Hide();

        }

        private void Btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            form1 n = new form1();
            n.ShowDialog();

        }

        private void manageRest_Load(object sender, EventArgs e)
        {

            con = new OracleConnection(ordb);
            con.Open();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into MEAL values(:name1,:type1,:cost1,:size1,:calories1,:ord_num1)";
          //  cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("name1", tb_name.Text);
            cmd.Parameters.Add("type1", tb_type.Text);
            cmd.Parameters.Add("cost1", tb_cost.Text);
            cmd.Parameters.Add("size1", tb_size.Text);
            cmd.Parameters.Add("calories1", tb_calories.Text);
            cmd.Parameters.Add("ord_num1", tb_ord_num.Text);
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {
                MessageBox.Show("Meal Inserted!");
                tb_name.Text = "";
                tb_type.Text = "";
                tb_cost.Text = "";
                tb_size.Text = "";
                tb_calories.Text = "";
                tb_search.Text = "";
                tb_ord_num.Text = "";


            }


        }

        private void manageRest_FormClosed(object sender, FormClosedEventArgs e)
        {
            con.Dispose();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {

             OracleCommand cmd2 = new OracleCommand();
             cmd2.Connection = con;
             cmd2.CommandText = "update MEAL set NAME=:name3,TYPE=:type3, COST=:cost3, SIZE=:size3, CALORIES=:calories3,ORD_NUM=:ord_num3 where NAME=: searchName";
             cmd2.Parameters.Add("name3", tb_name.Text);
             cmd2.Parameters.Add("type3", tb_type.Text);
             cmd2.Parameters.Add("cost3", tb_cost.Text);
             cmd2.Parameters.Add("size3", tb_size.Text);
             cmd2.Parameters.Add("calories3", tb_calories.Text);
            cmd2.Parameters.Add("ord_num3", tb_ord_num.Text);
            cmd2.Parameters.Add("searchName", tb_search.Text);
             int y = cmd2.ExecuteNonQuery();
             if (y != -1)
             {
                 MessageBox.Show("Meal Updated!");
             }

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from meal where name=: searchName";

            cmd.Parameters.Add("searchName", tb_search.Text);

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                tb_name.Text = dr[0].ToString();
                tb_type.Text = dr[1].ToString();
                tb_cost.Text = dr[2].ToString();
                tb_size.Text = dr[3].ToString();
                tb_calories.Text = dr[4].ToString();
                tb_ord_num.Text = dr[5].ToString();

            }

        }

        private void tb_search_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

            OracleCommand C = new OracleCommand();
            C.Connection = con;
            C.CommandText = "Delete from MEAL where name=:searchhh";
            C.Parameters.Add("searchhh", tb_search.Text);
            int y = C.ExecuteNonQuery();
            if (y != -1)
            {
                MessageBox.Show("Meal Deleted");
                tb_name.Text = "";
                tb_type.Text = "";
                tb_cost.Text = "";
                tb_size.Text = "";
                tb_calories.Text = "";
                tb_search.Text = "";
                tb_search.Text = "";

            }





        }

        private void tb_size_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
