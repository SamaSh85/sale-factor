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
using System.IO;
namespace WindowsFormsApplication1
{
    public partial class AddCommadity : Form
    {
        public AddCommadity()
        {
            InitializeComponent();
        }
        string path = "";
        int id = 0;
        bool isSave = false;
        byte[] arr;
        string str = Path.GetFileNameWithoutExtension(Path.GetRandomFileName());
     
        private void lblSave_Click(object sender, EventArgs e)
        {
            
                
               
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void AddCommadity_Load(object sender, EventArgs e)
        {
           


        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void lblSave_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
            txtImg.Focus();
            pictureBox1.Focus();
            txtCode.Focus();
            txtName.Focus();
            txtPrice.Focus();
            txtCount.Focus();
            txtPro.Focus();
            txtComment.Focus();
            lblNameK.Focus();
            lblCodK.Focus();
            lblImgK.Focus();
            lblPriceK.Focus();
            lblCountK.Focus();
            lblUnitK.Focus();
            lblProK.Focus();
            lblCommK.Focus();                           
            string name = txtName.Text.ToString();
            string code = txtCode.Text.ToString();
            float price = float.Parse(txtPrice.Text.ToString());
            int count = int.Parse(txtCount.Text.ToString());
            string comment = txtComment.Text.ToString();
            string producter = txtPro.Text.ToString();
            //string image = pictureBox1.ImageLocation;
            SqlConnection sc = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new System.Data.DataTable();
            if (name == "" | code == "" | txtPrice.Text == "" | txtCount.Text == "" | producter == "")
            {
                if (name == "")
                    MessageBox.Show("لطفا نام کالا را وارد کنید");
                else if (code == "")
                    MessageBox.Show("لطفا کد کالا را وارد کنید");
                else if (txtPrice.Text == "")
                    MessageBox.Show("لطفا قیمت کالا را وارد کنید");
                else if (txtCount.Text == "")
                    MessageBox.Show("لطفا تعداد کالا را وارد کنید");
                else if (producter == "")
                    MessageBox.Show("لطفا نام تولید کننده ی کالا را وارد کنید");
            }
            else
            {
                sc.ConnectionString = "Data Source=.;Initial Catalog=anbar;Integrated Security=True";
                sc.Open();
                cmd.Connection = sc;
                da.SelectCommand = cmd;
                string qry2 = "";
                qry2 = "select Id from Unit where UnitName=N'{0}'";
                qry2 = string.Format(qry2, txtUnit.Text.ToString());
                cmd.CommandText = qry2;
                da.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("لطفا واحد کالا را درست وارد کنید");
                    txtUnit.Text = "";
                }
                   
                else
                {
                    sc.Close();
                    SqlConnection sc1 = new SqlConnection();
                    SqlCommand cmd1 = new SqlCommand();
                    SqlDataAdapter da1 = new SqlDataAdapter();
                    DataTable dt1 = new System.Data.DataTable();
                    sc1.ConnectionString = "Data Source=.;Initial Catalog=anbar;Integrated Security=True";
                    sc1.Open();
                    cmd1.Connection = sc1;
                    da1.SelectCommand = cmd1;
                    string qry = "";
                    qry = "select * from Commadity where Code=@Code";
                    cmd1.CommandText = qry; cmd1.Parameters.AddWithValue("@Code", code);
                    da1.Fill(dt1);
                    if (dt1.Rows.Count != 0)
                    {
                        MessageBox.Show("کد کالا قبلا ثبت شده است");
                        txtCode.Text = "";
                    }
                    else
                    {
                        id = int.Parse(dt.Rows[0]["Id"].ToString());
                        sc.Close();
                        SqlConnection scc = new SqlConnection();
                        scc.ConnectionString = "Data Source=.;Initial Catalog=anbar;Integrated Security=True";
                        scc.Open();
                        SqlCommand scmd = new SqlCommand();
                        scmd.Connection = scc;
                        string qryy = "";
                        qryy = "insert into Commadity(Name,Code,Price,Num,Comment,Producter,Image,unitId) Values(@Name,@Code,@Price,@Num,@Comm,@Pro,@img,@id)";
                        scmd.CommandText = qryy;
                        scmd.Parameters.AddWithValue("@Name", name);
                        scmd.Parameters.AddWithValue("@Code", code);
                        scmd.Parameters.AddWithValue("@Price", price);
                        scmd.Parameters.AddWithValue("@Num", count);
                        scmd.Parameters.AddWithValue("@Comm", comment);
                        scmd.Parameters.AddWithValue("@Pro", producter);
                        scmd.Parameters.AddWithValue("@img", arr);
                        scmd.Parameters.AddWithValue("@id", id);
                        scmd.ExecuteNonQuery();
                        scc.Close();
                        MessageBox.Show("کالای شما در انبار ثبت شد");
                        txtCode.Text = "";
                        txtName.Text = "";
                        txtImg.Text = "";
                        txtPrice.Text = "";
                        txtCount.Text = "";
                        txtUnit.Text = "";
                        txtPro.Text = "";
                        txtImg.Text = "";
                    }
                   
                }

            }
               
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
           
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnbrows_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
            txtUnitName.Focus();       
            txtComm.Focus();
            openFileDialog1.InitialDirectory = "C://Desktop";
            openFileDialog1.Title = "لطفا تصویر کالای خود را انتخاب کنید";
            openFileDialog1.Filter = "select valid image(*.png; *.jpg; *.jpeg)| *.png; *.jpg; *.jpeg";
            openFileDialog1.FilterIndex = 1;

            try
            {
                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (openFileDialog1.CheckFileExists)
                    {
                        string myFile = openFileDialog1.FileName;
                        arr = File.ReadAllBytes(myFile);                    
                         txtImg.Text = openFileDialog1.FileName;
                        pictureBox1.Visible = true;
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox1.Image=new Bitmap(openFileDialog1.FileName);
                      

                    }
                    else
                    {
                        MessageBox.Show("لطفا یک فایل انتخاب کنید");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUnitSave_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
            lblUnitName.Focus();
            txtUnitName.Focus();
            lblCom.Focus();
            txtComm.Focus();
            string UnitName = txtUnitName.Text.ToString();
            SqlConnection sc = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new System.Data.DataTable();
            string qry = "";
            sc.ConnectionString = "Data Source=.;Initial Catalog=anbar;Integrated Security=True";
            sc.Open();
            cmd.Connection = sc;
            da.SelectCommand = cmd;
            qry = "select * from Unit";
            cmd.CommandText = qry;
            da.Fill(dt);
            for(int i=0;i<dt.Rows.Count;i++)
            {
                if(UnitName==dt.Rows[i]["UnitName"].ToString())
                {
                    txtUnitName.Text = "";
                    MessageBox.Show("این واحد قبلا ثبت شده است");
                    isSave = true;
                    txtUnitName.Text = "";
                    txtComm.Text = "";
                }
             
            }
            sc.Close();
            if(isSave==false)
            {
                SqlConnection scc = new SqlConnection();
                scc.ConnectionString = "Data Source=.;Initial Catalog=anbar;Integrated Security=True";
                scc.Open();
                SqlCommand scmd = new SqlCommand();
                scmd.Connection = scc;
                string qryy = "";
                qryy = "insert into Unit Values(@Desc,@Name)";
                scmd.CommandText = qryy;
                scmd.Parameters.AddWithValue("@Name", UnitName);
                scmd.Parameters.AddWithValue("@Desc", txtComm.Text.ToString());
                scmd.ExecuteNonQuery();
                scc.Close();
                MessageBox.Show("واحد مورد نظر ثبت گردید");
                txtUnitName.Text = "";
                txtComm.Text = "";
            }

           
          
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
