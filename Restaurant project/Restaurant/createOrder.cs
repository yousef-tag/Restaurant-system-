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
    public partial class createOrder : Form
    {
        string ordb = "Data Source = ORCL; User Id = scott; Password=tiger;";
        OracleConnection conn;
        public createOrder()
        {
            InitializeComponent();
        }

        private void Btn_back_Click(object sender, EventArgs e)
        {

            this.Hide();
            form1 n = new form1();
            n.ShowDialog();
        }

        private void Btn_order_Click(object sender, EventArgs e)
        {

        }

        private void createOrder_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "GETMEAL";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("myRow", OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {

                string str = String.Concat(dr[0], "  ");
                string str1 = string.Concat(str, dr[3]);
                string str2 = string.Concat(str1, "  ");
                string str3=String.Concat(str2,dr[2]);
                
                checkedListBox1.Items.Add(str3);
              
               /* foreach (object itemchecked in checkedListBox1.CheckedItems)
                {

                }
 */
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
