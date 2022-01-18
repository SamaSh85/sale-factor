namespace WindowsFormsApplication1
{
    partial class AnbarInf
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnadd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btndelet = new System.Windows.Forms.Button();
            this.Lbcount = new System.Windows.Forms.Label();
            this.txtcount = new System.Windows.Forms.TextBox();
            this.btnReturn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnadd.Location = new System.Drawing.Point(274, 332);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(110, 23);
            this.btnadd.TabIndex = 0;
            this.btnadd.Text = "اضافه کردن به انبار";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Name,
            this.Code,
            this.Price,
            this.Producter,
            this.Num,
            this.UnitName});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(4, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(722, 211);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "ردیف";
            this.Id.Name = "Id";
            // 
            // Name
            // 
            this.Name.DataPropertyName = "Name";
            this.Name.HeaderText = "نام کالا";
            this.Name.Name = "Name";
            // 
            // Code
            // 
            this.Code.DataPropertyName = "Code";
            this.Code.HeaderText = "کد کالا";
            this.Code.Name = "Code";
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "قیمت";
            this.Price.Name = "Price";
            // 
            // Producter
            // 
            this.Producter.DataPropertyName = "Producter";
            this.Producter.HeaderText = "تولید کننده";
            this.Producter.Name = "Producter";
            // 
            // Num
            // 
            this.Num.DataPropertyName = "Num";
            this.Num.HeaderText = "موجودی";
            this.Num.Name = "Num";
            // 
            // UnitName
            // 
            this.UnitName.DataPropertyName = "UnitName";
            this.UnitName.HeaderText = "واحد";
            this.UnitName.Name = "UnitName";
            // 
            // btndelet
            // 
            this.btndelet.BackColor = System.Drawing.Color.Red;
            this.btndelet.Location = new System.Drawing.Point(157, 332);
            this.btndelet.Name = "btndelet";
            this.btndelet.Size = new System.Drawing.Size(86, 23);
            this.btndelet.TabIndex = 2;
            this.btndelet.Text = "حذف از انبار";
            this.btndelet.UseVisualStyleBackColor = false;
            this.btndelet.Click += new System.EventHandler(this.btndelet_Click);
            // 
            // Lbcount
            // 
            this.Lbcount.AutoSize = true;
            this.Lbcount.Location = new System.Drawing.Point(522, 341);
            this.Lbcount.Name = "Lbcount";
            this.Lbcount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Lbcount.Size = new System.Drawing.Size(33, 13);
            this.Lbcount.TabIndex = 3;
            this.Lbcount.Text = "تعداد:";
            // 
            // txtcount
            // 
            this.txtcount.Location = new System.Drawing.Point(438, 334);
            this.txtcount.Name = "txtcount";
            this.txtcount.Size = new System.Drawing.Size(64, 20);
            this.txtcount.TabIndex = 4;
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnReturn.Location = new System.Drawing.Point(65, 332);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 5;
            this.btnReturn.Text = "بازگشت";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // AnbarInf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 412);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.txtcount);
            this.Controls.Add(this.Lbcount);
            this.Controls.Add(this.btndelet);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnadd);
           // this.Name = "AnbarInf";
            this.Load += new System.EventHandler(this.Anbar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button btndelet;
        private System.Windows.Forms.Label Lbcount;
        private System.Windows.Forms.TextBox txtcount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitName;
        private System.Windows.Forms.Button btnReturn;
    }
}