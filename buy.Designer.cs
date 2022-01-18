namespace WindowsFormsApplication1
{
    partial class buy
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
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.txtcount = new System.Windows.Forms.MaskedTextBox();
            this.txtDate = new System.Windows.Forms.MaskedTextBox();
            this.txtMelli = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBasket = new System.Windows.Forms.Button();
            this.txtFamily = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbMelli = new System.Windows.Forms.Label();
            this.lbFamily = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lbdelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IdF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumKa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdFact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFinal = new System.Windows.Forms.Button();
            this.txtEdit = new System.Windows.Forms.MaskedTextBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.IdFa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CommadityId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nameka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FactorId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTotal = new System.Windows.Forms.MaskedTextBox();
            this.buyerbtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Image = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtcount
            // 
            this.txtcount.Location = new System.Drawing.Point(760, 314);
            this.txtcount.Mask = "0000000";
            this.txtcount.Name = "txtcount";
            this.txtcount.Size = new System.Drawing.Size(53, 20);
            this.txtcount.TabIndex = 30;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(61, 12);
            this.txtDate.Mask = "00/00/0000";
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(100, 20);
            this.txtDate.TabIndex = 29;
            this.txtDate.ValidatingType = typeof(System.DateTime);
            // 
            // txtMelli
            // 
            this.txtMelli.Location = new System.Drawing.Point(291, 9);
            this.txtMelli.Mask = "0000000000";
            this.txtMelli.Name = "txtMelli";
            this.txtMelli.Size = new System.Drawing.Size(100, 20);
            this.txtMelli.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(819, 318);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "تعداد:";
            // 
            // btnBasket
            // 
            this.btnBasket.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBasket.Location = new System.Drawing.Point(564, 312);
            this.btnBasket.Name = "btnBasket";
            this.btnBasket.Size = new System.Drawing.Size(140, 23);
            this.btnBasket.TabIndex = 26;
            this.btnBasket.Text = "افرودن به سبد خرید";
            this.btnBasket.UseVisualStyleBackColor = false;
            this.btnBasket.Click += new System.EventHandler(this.btnBasket_Click);
            // 
            // txtFamily
            // 
            this.txtFamily.Location = new System.Drawing.Point(519, 9);
            this.txtFamily.Name = "txtFamily";
            this.txtFamily.Size = new System.Drawing.Size(100, 20);
            this.txtFamily.TabIndex = 25;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(763, 9);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 20);
            this.txtname.TabIndex = 24;
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(178, 12);
            this.lbDate.Name = "lbDate";
            this.lbDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbDate.Size = new System.Drawing.Size(38, 13);
            this.lbDate.TabIndex = 23;
            this.lbDate.Text = " تاریخ:";
            // 
            // lbMelli
            // 
            this.lbMelli.AutoSize = true;
            this.lbMelli.Location = new System.Drawing.Point(408, 12);
            this.lbMelli.Name = "lbMelli";
            this.lbMelli.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbMelli.Size = new System.Drawing.Size(43, 13);
            this.lbMelli.TabIndex = 22;
            this.lbMelli.Text = "کد ملی:";
            // 
            // lbFamily
            // 
            this.lbFamily.AutoSize = true;
            this.lbFamily.Location = new System.Drawing.Point(623, 12);
            this.lbFamily.Name = "lbFamily";
            this.lbFamily.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbFamily.Size = new System.Drawing.Size(72, 13);
            this.lbFamily.TabIndex = 21;
            this.lbFamily.Text = "نام خانوادگی:";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(871, 12);
            this.lbName.Name = "lbName";
            this.lbName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbName.Size = new System.Drawing.Size(23, 13);
            this.lbName.TabIndex = 20;
            this.lbName.Text = "نام:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Name,
            this.Num,
            this.Code,
            this.UnitName,
            this.producter,
            this.Price,
            this.Image});
            this.dataGridView2.DataSource = this.bindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(61, 120);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(830, 186);
            this.dataGridView2.TabIndex = 31;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnEdit.Location = new System.Drawing.Point(205, 426);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnEdit.Size = new System.Drawing.Size(99, 29);
            this.btnEdit.TabIndex = 35;
            this.btnEdit.Text = "ویرایش تعداد کالا:";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.lbedit_Click);
            // 
            // lbdelete
            // 
            this.lbdelete.BackColor = System.Drawing.Color.Red;
            this.lbdelete.Location = new System.Drawing.Point(206, 487);
            this.lbdelete.Name = "lbdelete";
            this.lbdelete.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbdelete.Size = new System.Drawing.Size(98, 39);
            this.lbdelete.TabIndex = 34;
            this.lbdelete.Text = "حذف از فاکتور:";
            this.lbdelete.UseVisualStyleBackColor = false;
            this.lbdelete.Click += new System.EventHandler(this.lbdelete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdF,
            this.IdK,
            this.NameK,
            this.NumKa,
            this.IdFact,
            this.Total});
            this.dataGridView1.DataSource = this.bindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(394, 360);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(497, 166);
            this.dataGridView1.TabIndex = 33;
            this.dataGridView1.CellBorderStyleChanged += new System.EventHandler(this.dataGridView1_CellBorderStyleChanged);
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // IdF
            // 
            this.IdF.DataPropertyName = "Id";
            this.IdF.HeaderText = "ردیف";
            this.IdF.Name = "IdF";
            this.IdF.Visible = false;
            // 
            // IdK
            // 
            this.IdK.DataPropertyName = "CommadityId";
            this.IdK.HeaderText = "شماره کالا";
            this.IdK.Name = "IdK";
            this.IdK.Visible = false;
            // 
            // NameK
            // 
            this.NameK.DataPropertyName = "Name";
            this.NameK.HeaderText = "نام کالا";
            this.NameK.Name = "NameK";
            // 
            // NumKa
            // 
            this.NumKa.DataPropertyName = "Num";
            this.NumKa.HeaderText = "تعداد کالا";
            this.NumKa.Name = "NumKa";
            // 
            // IdFact
            // 
            this.IdFact.DataPropertyName = "FactorId";
            this.IdFact.HeaderText = "شماره فاکتور";
            this.IdFact.Name = "IdFact";
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Totalprice";
            this.Total.HeaderText = "جمع قیمت";
            this.Total.Name = "Total";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(51, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(856, 3);
            this.label1.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 390);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "جمع کل فاکتور:";
            // 
            // btnFinal
            // 
            this.btnFinal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnFinal.Location = new System.Drawing.Point(123, 487);
            this.btnFinal.Name = "btnFinal";
            this.btnFinal.Size = new System.Drawing.Size(66, 39);
            this.btnFinal.TabIndex = 39;
            this.btnFinal.Text = "ثبت نهایی";
            this.btnFinal.UseVisualStyleBackColor = false;
            this.btnFinal.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtEdit
            // 
            this.txtEdit.Location = new System.Drawing.Point(143, 431);
            this.txtEdit.Mask = "0000000";
            this.txtEdit.Name = "txtEdit";
            this.txtEdit.Size = new System.Drawing.Size(56, 20);
            this.txtEdit.TabIndex = 40;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(29, 487);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 39);
            this.btnReturn.TabIndex = 41;
            this.btnReturn.Text = "بازگشت";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // IdFa
            // 
            this.IdFa.DataPropertyName = "Id";
            this.IdFa.HeaderText = "ردیف";
            this.IdFa.Name = "IdFa";
            this.IdFa.Visible = false;
            // 
            // CommadityId
            // 
            this.CommadityId.DataPropertyName = "CommadityId";
            this.CommadityId.HeaderText = "CommadityId";
            this.CommadityId.Name = "CommadityId";
            this.CommadityId.Visible = false;
            // 
            // Nameka
            // 
            this.Nameka.DataPropertyName = "Name";
            this.Nameka.HeaderText = "نام کالا";
            this.Nameka.Name = "Nameka";
            this.Nameka.Width = 114;
            // 
            // Numk
            // 
            this.Numk.DataPropertyName = "Num";
            this.Numk.HeaderText = "تعداد";
            this.Numk.Name = "Numk";
            this.Numk.Width = 113;
            // 
            // FactorId
            // 
            this.FactorId.DataPropertyName = "FactorId";
            this.FactorId.HeaderText = "شماره فاکتور";
            this.FactorId.Name = "FactorId";
            this.FactorId.Width = 114;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(190, 383);
            this.txtTotal.Mask = "0000000000";
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(75, 20);
            this.txtTotal.TabIndex = 42;
            // 
            // buyerbtn
            // 
            this.buyerbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buyerbtn.Location = new System.Drawing.Point(61, 57);
            this.buyerbtn.Name = "buyerbtn";
            this.buyerbtn.Size = new System.Drawing.Size(75, 23);
            this.buyerbtn.TabIndex = 43;
            this.buyerbtn.Text = "ثبت کاربر";
            this.buyerbtn.UseVisualStyleBackColor = false;
            this.buyerbtn.Click += new System.EventHandler(this.btnbuyer);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(51, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(856, 3);
            this.label3.TabIndex = 44;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // Name
            // 
            this.Name.DataPropertyName = "Name";
            this.Name.HeaderText = "نام";
            this.Name.Name = "Name";
            // 
            // Num
            // 
            this.Num.DataPropertyName = "Num";
            this.Num.HeaderText = "تعداد";
            this.Num.Name = "Num";
            // 
            // Code
            // 
            this.Code.DataPropertyName = "Code";
            this.Code.HeaderText = "کد کالا";
            this.Code.Name = "Code";
            // 
            // UnitName
            // 
            this.UnitName.DataPropertyName = "UnitName";
            this.UnitName.HeaderText = "واحد";
            this.UnitName.Name = "UnitName";
            // 
            // producter
            // 
            this.producter.DataPropertyName = "producter";
            this.producter.HeaderText = "تولید کننده";
            this.producter.Name = "producter";
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "قیمت";
            this.Price.Name = "Price";
            // 
            // Image
            // 
            this.Image.DataPropertyName = "Image";
            this.Image.HeaderText = "تصویر";
            this.Image.Name = "Image";
            this.Image.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // buy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 555);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buyerbtn);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.txtEdit);
            this.Controls.Add(this.btnFinal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lbdelete);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.txtcount);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtMelli);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnBasket);
            this.Controls.Add(this.txtFamily);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.lbMelli);
            this.Controls.Add(this.lbFamily);
            this.Controls.Add(this.lbName);
           // this.Name = "buy";
            this.Text = "buy";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.buy_FormClosed);
            this.Load += new System.EventHandler(this.buy_Load);
            this.Leave += new System.EventHandler(this.buy_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.MaskedTextBox txtcount;
        private System.Windows.Forms.MaskedTextBox txtDate;
        private System.Windows.Forms.MaskedTextBox txtMelli;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBasket;
        private System.Windows.Forms.TextBox txtFamily;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbMelli;
        private System.Windows.Forms.Label lbFamily;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button lbdelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFinal;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.MaskedTextBox txtEdit;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdFa;
        private System.Windows.Forms.DataGridViewTextBoxColumn CommadityId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nameka;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numk;
        private System.Windows.Forms.DataGridViewTextBoxColumn FactorId;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdF;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdK;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameK;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumKa;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdFact;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.MaskedTextBox txtTotal;
        private System.Windows.Forms.Button buyerbtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitName;
        private System.Windows.Forms.DataGridViewTextBoxColumn producter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewImageColumn Image;
    }
}