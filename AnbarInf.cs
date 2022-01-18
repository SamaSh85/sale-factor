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

namespace WindowsFormsApplication1
{
    public partial class AnbarInf : Form
    {
        public AnbarInf()
        {
            InitializeComponent();
           
        }
        bool isclick = false;
        private void Anbar_Load(object sender, EventArgs e)
        {
            SqlConnection sc = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new System.Data.DataTable();
            string qry = "";

           
            sc.ConnectionString="Data Source=.;Initial Catalog=anbar;Integrated Security=True";
            sc.Open();
            cmd.Connection=sc;
            da.SelectCommand=cmd;
            qry = "select Commadity.Id,Commadity.Name,Commadity.Price,Commadity.Code,Commadity.Producter,Commadity.Num,Unit.UnitName from Commadity join Unit on Commadity.unitId=unit.Id";
            cmd.CommandText=qry;
            da.Fill(dt);
            bindingSource1.DataSource=dt;
            sc.Close();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
          
                string v = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
                int Id = int.Parse(v);
                if (txtcount.Text == "" | isclick==false)
                {
                    if (txtcount.Text == "")
                        MessageBox.Show("لطفا تعداد کالا را وارد کنید!");
                    if (isclick == false)
                        MessageBox.Show("لطفا کالایی را انتخاب نمایید");
                }
                   
                else
                {
                    SqlConnection sc = new SqlConnection();
                    sc.ConnectionString = "Data Source=.;Initial Catalog=anbar;Integrated Security=True";
                    SqlCommand cmd = new SqlCommand();
                    sc.Open();
                    cmd.Connection = sc;
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = cmd;
                    DataTable dt = new System.Data.DataTable();
                    string qry = "";

                    qry = "select Num from Commadity where Id={0}";
                    qry = string.Format(qry, Id);
                    cmd.CommandText = qry;
                    da.Fill(dt);
                    int num = int.Parse(dt.Rows[0]["Num"].ToString());
                    int sum = num + int.Parse(txtcount.Text);
                    SqlCommand sqc = new SqlCommand();
                    sqc.Connection = sc;
                    SqlDataAdapter dda = new SqlDataAdapter();
                    dda.SelectCommand = sqc;

                    qry = "update Commadity set Num={0} where Id={1}";
                    qry = string.Format(qry, sum, Id);
                    sqc.CommandText = qry;
                    DataTable ddt = new DataTable();
                    dda.Fill(ddt);
                    sqc.ExecuteNonQuery();
                    txtcount.Text = "";
                    Anbar_Load(null, null);
                }
               
            
            
           
        }

        private void btndelet_Click(object sender, EventArgs e)
        {
            
                string v = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
                int Id = int.Parse(v);
                if (txtcount.Text == "" | isclick==false)
                {
                    if(txtcount.Text=="")
                      MessageBox.Show("لطفا تعداد کالا را وارد کنید!");
                    if (isclick == false)
                        MessageBox.Show("لطفا کالایی را انتخاب نمایید");
                }
                else
                {
                    int count = int.Parse(txtcount.Text);
                    SqlConnection sc = new SqlConnection();
                    sc.ConnectionString = "Data Source=.;Initial Catalog=anbar;Integrated Security=True";
                    SqlCommand cmd = new SqlCommand();
                    sc.Open();
                    cmd.Connection = sc;
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = cmd;
                    DataTable dt = new System.Data.DataTable();
                    string qry = "";

                    qry = "select Num from Commadity where Id={0}";
                    qry = string.Format(qry, Id);
                    cmd.CommandText = qry;
                    da.Fill(dt);
                    int num = int.Parse(dt.Rows[0]["Num"].ToString());

                    if (count > num)
                    {
                        MessageBox.Show("موجودی کافی نیست");
                        txtcount.Text = "";
                    }
                    else
                    {
                        int diff = num - count;
                        SqlCommand sqc = new SqlCommand();
                        sqc.Connection = sc;
                        SqlDataAdapter dda = new SqlDataAdapter();
                        dda.SelectCommand = sqc;

                        qry = "update Commadity set Num={0} where Id={1}";
                        qry = string.Format(qry, diff, Id);
                        sqc.CommandText = qry;
                        DataTable ddt = new DataTable();
                        dda.Fill(ddt);
                        sqc.ExecuteNonQuery();
                        txtcount.Text = "";
                        Anbar_Load(null, null);
                    }
                }  
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //isclick = true;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            isclick = true;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
