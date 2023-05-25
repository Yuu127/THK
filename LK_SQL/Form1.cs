using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
//using LK_SQL.ViewForm;

namespace LK_SQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connStr = @"Data Source=YUU\SQLEXPRESS;Initial Catalog=CSDL;User Id=sa;Password=1234";

            SqlConnection sql = new SqlConnection();
            sql.ConnectionString = connStr;
            sql.Open();

            SqlCommand cmd = sql.CreateCommand();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select* from LOAIHANG";
            SqlDataReader reader = cmd.ExecuteReader();



            DataTable data = new DataTable();
            data.Load(reader);

            hienthidata.DataSource = data;
        }

        /*      private void btn_edit_Click(object sender, EventArgs e)
              {
                  Edit edit = new Edit();
                  if (edit.ShowDialog() == DialogResult.OK)
                  {

                  }
                  edit.Dispose();
              }
              int vitrichon;
              private void hienThiDuLieu_CellContentClick(object sender, DataGridViewCellEventArgs e)
              {
                  MessageBox.Show($"Dang chon {e.RowIndex}");
              }

          }
        */
    } 
}
