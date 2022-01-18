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
    public partial class buy : Form
    {
        public buy()
        {
            InitializeComponent();
        }
       
        public int idKala = 0;
        public int idbuyer = 0;
        public int idfactor = 0;
        public string date = "";       
        bool isedit = false;
        int avalibleKala = 0;
        int count = 0;
        int diff = 0;
        float TotalPrice = 0;      
        bool isSelect = false;
        bool isOk = false;
        bool isBuyer = false;
        private void buy_Load(object sender, EventArgs e)
        {
            SqlConnection sc = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new System.Data.DataTable();
            string qry = "";
            sc.ConnectionString = "Data Source=.;Initial Catalog=anbar;Integrated Security=True";
            sc.Open();
            cmd.Connection = sc;
            da.SelectCommand = cmd;
            qry = "select Commadity.Id,Commadity.Name,Commadity.Price,Commadity.Code,Commadity.Producter,Commadity.Num,Commadity.Image,Unit.UnitName from Commadity join Unit on Commadity.unitId=unit.Id";
            cmd.CommandText = qry;
            da.Fill(dt);
            dataGridView2.RowTemplate.Height = 150;
            bindingSource1.DataSource = dt;
            sc.Close();          
        }

        private void btnBasket_Click(object sender, EventArgs e)
        {
            if (txtname.Text == "" | txtFamily.Text == "" | txtcount.Text == ""|isSelect==false |isBuyer==false)
            {
                if (txtname.Text == "")
                    MessageBox.Show("لطفا نام خریدار را وارد کنید");
                if (txtFamily.Text == "")
                    MessageBox.Show("لطفا فامیلی خریدار را وارد کنید");

                if (txtcount.Text == "")
                    MessageBox.Show("لطفا تعداد کالا را وارد نمایید");
                if(isSelect==false)
                    MessageBox.Show("لطفا کالایی را انتخاب نمایید");
                if(isBuyer==false)
                    MessageBox.Show("لطفا کاربر مورد نظر را ثبت کنید");
            }
            else
            {
                            
                    string v = dataGridView2[0, dataGridView2.CurrentRow.Index].Value.ToString();
                    idKala = int.Parse(v);                                
                    SqlConnection ssc = new SqlConnection();
                    SqlCommand cmdd = new SqlCommand();
                    SqlDataAdapter dda = new SqlDataAdapter();
                    DataTable dtt = new System.Data.DataTable();
                    string qry1 = "";
                    ssc.ConnectionString = "Data Source=.;Initial Catalog=anbar;Integrated Security=True";
                    ssc.Open();
                    cmdd.Connection = ssc;
                    qry1 = "select top 1 Id from dbo.Factors order by Id desc";
                    cmdd.CommandText = qry1;
                    dda.SelectCommand = cmdd;
                    dda.Fill(dtt);
                    if (dtt.Rows.Count == 0)
                    {
                        idfactor = 1;
                    }
                    else
                    {
                        idfactor = int.Parse(dtt.Rows[0]["Id"].ToString())+1;
                    }
                    ssc.Close();
                    if (txtcount.Text == "")
                        MessageBox.Show("لطفا تعداد کالا را وارد کنید");
                    SqlConnection sccc = new SqlConnection();
                    SqlCommand cmddd = new SqlCommand();
                    SqlDataAdapter ddda = new SqlDataAdapter();
                    DataTable dttt = new System.Data.DataTable();
                    string qry2 = "";
                    sccc.ConnectionString = "Data Source=.;Initial Catalog=anbar;Integrated Security=True";
                    sccc.Open();
                    cmddd.Connection = sccc;
                    ddda.SelectCommand = cmddd;
                    qry2 = "select Commadity.Price,Commadity.Num from Commadity where Id=@id";
                    cmddd.CommandText = qry2;
                    cmddd.Parameters.AddWithValue("@id", idKala);
                    ddda.Fill(dttt);
                    float PricetKala = float.Parse(dttt.Rows[0]["Price"].ToString());
                    avalibleKala = int.Parse(dttt.Rows[0]["Num"].ToString());                       
                       count = int.Parse(txtcount.Text.ToString());
                   
                     
                    
                    if (count > avalibleKala)
                    {
                        MessageBox.Show("موجودی کافی نیست");
                        txtcount.Text = "";
                    }
                    else
                    {

                        string t = dataGridView2[0, dataGridView2.CurrentRow.Index].Value.ToString();
                        int IdKa = int.Parse(t);
                        SqlConnection sc0 = new SqlConnection();
                        SqlCommand cmd0 = new SqlCommand();
                        SqlDataAdapter da0 = new SqlDataAdapter();
                        DataTable dt0 = new System.Data.DataTable();
                        string qry0 = "";
                        sc0.ConnectionString = "Data Source=.;Initial Catalog=anbar;Integrated Security=True";
                        sc0.Open();
                        cmd0.Connection = sc0;
                        da0.SelectCommand = cmd0;
                        qry0 = "select Factordetails.Id from Factordetails join Commadity on Factordetails.CommadityId=Commadity.Id where Factordetails.FactorId=@factorid and Commadity.Id=@Id";

                        cmd0.CommandText = qry0;
                        cmd0.Parameters.AddWithValue("@factorid", idfactor);
                        cmd0.Parameters.AddWithValue("@Id", IdKa);
                        da0.Fill(dt0);
                        if (dt0.Rows.Count != 0)
                            MessageBox.Show("این کالا قبلا انتخاب شده است");
                        else
                        {
                            float totalPrice = PricetKala * count;
                            SqlConnection sc1 = new SqlConnection();
                            sc1.ConnectionString = "Data Source=.;Initial Catalog=anbar;Integrated Security=True";
                            sc1.Open();
                            SqlCommand cmd1 = new SqlCommand();
                            cmd1.Connection = sc1;
                            string qry3 = "insert into FactorDetails Values(@KalaId,@Num,@FactorId,@TotalPrice)";
                            cmd1.CommandText = qry3;
                            cmd1.Parameters.AddWithValue("@kalaId", idKala);
                            cmd1.Parameters.AddWithValue("@Num", count);
                            cmd1.Parameters.AddWithValue("@FactorId", idfactor);
                            cmd1.Parameters.AddWithValue("@TotalPrice", totalPrice);
                            cmd1.ExecuteNonQuery();
                            sc1.Close();
                        }
                     
                        SqlConnection sc3 = new SqlConnection();
                        SqlCommand cmd3 = new SqlCommand();
                        SqlDataAdapter da3 = new SqlDataAdapter();
                        DataTable dt3 = new System.Data.DataTable();
                        string qry5 = "";
                        sc3.ConnectionString = "Data Source=.;Initial Catalog=anbar;Integrated Security=True";
                        sc3.Open();
                        cmd3.Connection = sc3;
                        da3.SelectCommand = cmd3;
                        qry5 = "select Factordetails.Id,Factordetails.CommadityId,Factordetails.Num,Factordetails.FactorId,Factordetails.Totalprice,Commadity.Name from Factordetails join Commadity on Factordetails.CommadityId=Commadity.Id where Factordetails.FactorId=@factorid";
                            
                        cmd3.CommandText = qry5;
                        cmd3.Parameters.AddWithValue("@factorid", idfactor);
                        da3.Fill(dt3);
                        bindingSource2.DataSource = dt3;
                        txtcount.Text = "";
                        for (int i = 0; i < dt3.Rows.Count;i++)
                        {
                            float price = float.Parse(dt3.Rows[i]["Totalprice"].ToString());
                            TotalPrice += price;                      
                        }
                        txtTotal.Text = TotalPrice.ToString();
                      
                    }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
                {
                    SqlConnection sc1 = new SqlConnection();
                    sc1.ConnectionString = "Data Source=.;Initial Catalog=anbar;Integrated Security=True";
                    sc1.Open();
                    SqlCommand cmd1 = new SqlCommand();
                    cmd1.Connection = sc1;
                    string qry3 = "insert into Factors Values(@FactorId,@buyerId,@TotalPrice,@date)";
                    cmd1.CommandText = qry3;
                    cmd1.Parameters.AddWithValue("@FactorId", idfactor);
                    cmd1.Parameters.AddWithValue("@buyerId", idbuyer);
                    cmd1.Parameters.AddWithValue("@TotalPrice", TotalPrice);
                    cmd1.Parameters.AddWithValue("@date",DateTime.Parse(date.ToString()));
                    cmd1.ExecuteNonQuery();
                    sc1.Close();
                        MessageBox.Show("فاکتور شما ثبت شد");
                        isOk = true;
                        SqlConnection sc0 = new SqlConnection();
                        SqlCommand cmd0 = new SqlCommand();
                        SqlDataAdapter da0 = new SqlDataAdapter();
                        DataTable dt0 = new System.Data.DataTable();
                        string qry0 = "";
                        sc0.ConnectionString = "Data Source=.;Initial Catalog=anbar;Integrated Security=True";
                        sc0.Open();
                        cmd0.Connection = sc0;
                        da0.SelectCommand = cmd0;
                        qry0 = "select Factordetails.Num as buyerNum, Commadity.Num as AvalibleNum,Commadity.Id from Factordetails join Commadity on Factordetails.CommadityId=Commadity.Id where Factordetails.FactorId=@factorid";                            
                        cmd0.CommandText = qry0;
                        cmd0.Parameters.AddWithValue("@factorid", idfactor);
                        da0.Fill(dt0);
                        for(int i=0;i<dt0.Rows.Count;i++)
                        {
                            int buyernumber=int.Parse(dt0.Rows[i]["buyerNum"].ToString());
                            int Avaliblenum = int.Parse(dt0.Rows[i]["AvalibleNum"].ToString());
                            diff = Avaliblenum - buyernumber;
                            SqlConnection sc3 = new SqlConnection();
                            sc3.ConnectionString = "Data Source=.;Initial Catalog=anbar;Integrated Security=True";
                            sc3.Open();
                            SqlCommand cmd3 = new SqlCommand();
                            cmd3.Connection = sc3;
                            string qry5 = "update Commadity set Commadity.Num=@num where Commadity.Id=@Id";
                            cmd3.CommandText = qry5;
                            cmd3.Parameters.AddWithValue("@num", diff);
                            cmd3.Parameters.AddWithValue("@Id",int.Parse( dt0.Rows[i]["Id"].ToString()));
                            cmd3.ExecuteNonQuery();
                            sc3.Close();
                           
                        }
                        dataGridView1.Enabled = false;
                        dataGridView2.Enabled = false;

        }

        private void lbedit_Click(object sender, EventArgs e)
        {
            if(isedit==false)
            {
                MessageBox.Show("لطفا کالایی رو برای ویرایش انتخاب کنید");
            }
            string v = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
            int IdF = int.Parse(v);
            string s = dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString();
            int Idk = int.Parse(s);
            SqlConnection sc1 = new SqlConnection();
            SqlCommand cmd1 = new SqlCommand();
            SqlDataAdapter da1 = new SqlDataAdapter();
            DataTable dt1 = new System.Data.DataTable();
            string qry1 = "";
            sc1.ConnectionString = "Data Source=.;Initial Catalog=anbar;Integrated Security=True";
            sc1.Open();
            cmd1.Connection = sc1;
            da1.SelectCommand = cmd1;
            qry1 = "select Commadity.Num ,Commadity.Price from Commadity  where Commadity.Id=@id";
            cmd1.CommandText = qry1;
            cmd1.Parameters.AddWithValue("@id", Idk);
            da1.Fill(dt1);
            avalibleKala=int.Parse(dt1.Rows[0]["Num"].ToString());
            float Totalp = float.Parse(dt1.Rows[0]["Price"].ToString());
            count = int.Parse(txtEdit.Text.ToString());
            if(count>avalibleKala)
            {
                MessageBox.Show("موجودی کافی نیست");
                txtEdit.Text = "";
            }                 
            SqlConnection sc2 = new SqlConnection();
            sc2.ConnectionString = "Data Source=.;Initial Catalog=anbar;Integrated Security=True";
            sc2.Open();
            SqlCommand cmd2 = new SqlCommand();
            cmd2.Connection = sc2;
            string qry4 = "update FactorDetails set Num=@num and Totalprice=@Total where Id=@id";
            cmd2.CommandText = qry4;
            cmd2.Parameters.AddWithValue("@num", count);
            cmd2.Parameters.AddWithValue("@id", IdF);
            cmd2.Parameters.AddWithValue("@Total", Totalp);
            cmd2.ExecuteNonQuery();
            sc2.Close();
            SqlConnection sc0 = new SqlConnection();
            SqlCommand cmd0 = new SqlCommand();
            SqlDataAdapter da0 = new SqlDataAdapter();
            DataTable dt0 = new System.Data.DataTable();
            string qry0 = "";
            sc0.ConnectionString = "Data Source=.;Initial Catalog=anbar;Integrated Security=True";
            sc0.Open();
            cmd0.Connection = sc0;
            da0.SelectCommand = cmd0;
            qry0 = "select Factordetails.Id,Factordetails.CommadityId,Factordetails.Num,Factordetails.FactorId,Factordetails.Totalprice,Commadity.Name from Factordetails join Commadity on Factordetails.CommadityId=Commadity.Id where Factordetails.FactorId=@factorid";
               
            cmd0.CommandText = qry0;
            cmd0.Parameters.AddWithValue("@factorid", idfactor);
            da0.Fill(dt0);
            bindingSource2.DataSource = dt0;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
          
            this.Close();           
           if(isOk==false)
           {
               SqlConnection sc3 = new SqlConnection();
               sc3.ConnectionString = "Data Source=.;Initial Catalog=anbar;Integrated Security=True";
               sc3.Open();
               SqlCommand cmd3 = new SqlCommand();
               cmd3.Connection = sc3;
               string qry5 = "delete from FactorDetails where FactorId=@FactorId";
               cmd3.CommandText = qry5;
               cmd3.Parameters.AddWithValue("@FactorId", idfactor);
               cmd3.ExecuteNonQuery();
               sc3.Close();
           }
            
        }

        private void buy_Leave(object sender, EventArgs e)
        {
          
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            isedit = true;
            string v = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
            int IdF = int.Parse(v);
            SqlConnection sc0 = new SqlConnection();
            SqlCommand cmd0 = new SqlCommand();
            SqlDataAdapter da0 = new SqlDataAdapter();
            DataTable dt0 = new System.Data.DataTable();
            string qry0 = "";
            sc0.ConnectionString = "Data Source=.;Initial Catalog=anbar;Integrated Security=True";
            sc0.Open();
            cmd0.Connection = sc0;
            da0.SelectCommand = cmd0;
            qry0 = "select Factordetails.Num  from Factordetails  where Factordetails.Id=@id";
            cmd0.CommandText = qry0;
            cmd0.Parameters.AddWithValue("@id", IdF);
            da0.Fill(dt0);
            txtEdit.Text = dt0.Rows[0]["Num"].ToString();
            sc0.Close();
        }

        private void lbdelete_Click(object sender, EventArgs e)
        {
            if(isedit==false)
            {
                MessageBox.Show("لطفا کالایی رو برای خدف انتخاب کنید");
            }
            string v = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
            int IdF = int.Parse(v);
            SqlConnection sc3 = new SqlConnection();
            sc3.ConnectionString = "Data Source=.;Initial Catalog=anbar;Integrated Security=True";
            sc3.Open();
            SqlCommand cmd3 = new SqlCommand();
            cmd3.Connection = sc3;
            string qry5 = "delete from FactorDetails where Id=@Id";
            cmd3.CommandText = qry5;
            cmd3.Parameters.AddWithValue("@Id", IdF);
            cmd3.ExecuteNonQuery();
            sc3.Close();
            MessageBox.Show("کالای مورد نظر از سبد خرید خذف شد");
            SqlConnection sc0 = new SqlConnection();
            SqlCommand cmd0 = new SqlCommand();
            SqlDataAdapter da0 = new SqlDataAdapter();
            DataTable dt0 = new System.Data.DataTable();
            string qry0 = "";
            sc0.ConnectionString = "Data Source=.;Initial Catalog=anbar;Integrated Security=True";
            sc0.Open();
            cmd0.Connection = sc0;
            da0.SelectCommand = cmd0;
            qry0 = "select Factordetails.Id,Factordetails.CommadityId,Factordetails.Num,Factordetails.FactorId,Factordetails.Totalprice,Commadity.Name from Factordetails join Commadity on Factordetails.CommadityId=Commadity.Id where Factordetails.FactorId=@factorid";

            cmd0.CommandText = qry0;
            cmd0.Parameters.AddWithValue("@factorid", idfactor);
            da0.Fill(dt0);
            bindingSource2.DataSource = dt0;           
        }

        private void buy_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isOk == false)
            {
                SqlConnection sc3 = new SqlConnection();
                sc3.ConnectionString = "Data Source=.;Initial Catalog=anbar;Integrated Security=True";
                sc3.Open();
                SqlCommand cmd3 = new SqlCommand();
                cmd3.Connection = sc3;
                string qry5 = "delete from FactorDetails where FactorId=@FactorId";
                cmd3.CommandText = qry5;
                cmd3.Parameters.AddWithValue("@FactorId", idfactor);
                cmd3.ExecuteNonQuery();
                sc3.Close();
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            isSelect = true;
                     
        }

        private void dataGridView1_CellBorderStyleChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void btnbuyer(object sender, EventArgs e)
        {
            isBuyer = true;
            date = txtDate.Text.ToString();
            SqlConnection scc = new SqlConnection();
            scc.ConnectionString = "Data Source=.;Initial Catalog=anbar;Integrated Security=True";
            scc.Open();
            SqlCommand scmd = new SqlCommand();
            scmd.Connection = scc;
            string qryy = "insert into buyer Values(@Name,@Family,@melli)";
            scmd.CommandText = qryy;
            scmd.Parameters.AddWithValue("@Name", txtname.Text.ToString());
            scmd.Parameters.AddWithValue("@Family", txtFamily.Text.ToString());
            scmd.Parameters.AddWithValue("@melli", txtMelli.Text.ToString());
            scmd.ExecuteNonQuery();
            scc.Close();
            MessageBox.Show("کاربر مورد نظر ثبت شد");
            txtname.Text = "";
            txtFamily.Text = "";
            txtMelli.Text = "";
            txtDate.Text = "";
            SqlConnection sc = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new System.Data.DataTable();
            string qry = "";
            sc.ConnectionString = "Data Source=.;Initial Catalog=anbar;Integrated Security=True";
            sc.Open();
            cmd.Connection = sc;
            da.SelectCommand = cmd;
            qry = "select  top 1 Id from buyer order by Id desc";
            cmd.CommandText = qry;
            da.Fill(dt);
            idbuyer = int.Parse(dt.Rows[0]["Id"].ToString());
            sc.Close();
        }

       
        
    }
}
