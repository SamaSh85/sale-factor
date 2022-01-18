namespace WindowsFormsApplication1
{
    partial class AddCommadity
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblCom = new System.Windows.Forms.Label();
            this.lblUnitName = new System.Windows.Forms.Label();
            this.btnUnitSave = new System.Windows.Forms.Button();
            this.txtComm = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUnitName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblProK = new System.Windows.Forms.Label();
            this.lblCommK = new System.Windows.Forms.Label();
            this.lblUnitK = new System.Windows.Forms.Label();
            this.lblCountK = new System.Windows.Forms.Label();
            this.lblPriceK = new System.Windows.Forms.Label();
            this.lblImgK = new System.Windows.Forms.Label();
            this.lblNameK = new System.Windows.Forms.Label();
            this.lblCodK = new System.Windows.Forms.Label();
            this.txtCount = new System.Windows.Forms.MaskedTextBox();
            this.txtPrice = new System.Windows.Forms.MaskedTextBox();
            this.btnbrows = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtPro = new System.Windows.Forms.TextBox();
            this.lblPro = new System.Windows.Forms.Label();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.txtImg = new System.Windows.Forms.TextBox();
            this.lblSave = new System.Windows.Forms.Button();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblcount = new System.Windows.Forms.Label();
            this.lblComment = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblImg = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblUnit = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnReturn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(908, 443);
            this.tabControl1.TabIndex = 24;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.lblCom);
            this.tabPage1.Controls.Add(this.lblUnitName);
            this.tabPage1.Controls.Add(this.btnUnitSave);
            this.tabPage1.Controls.Add(this.txtComm);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtUnitName);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(900, 417);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ثبت واحد";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // lblCom
            // 
            this.lblCom.AutoSize = true;
            this.lblCom.Location = new System.Drawing.Point(545, 226);
            this.lblCom.Name = "lblCom";
            this.lblCom.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCom.Size = new System.Drawing.Size(52, 13);
            this.lblCom.TabIndex = 6;
            this.lblCom.Text = "توضیحات:";
            // 
            // lblUnitName
            // 
            this.lblUnitName.AutoSize = true;
            this.lblUnitName.Location = new System.Drawing.Point(542, 63);
            this.lblUnitName.Name = "lblUnitName";
            this.lblUnitName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblUnitName.Size = new System.Drawing.Size(47, 13);
            this.lblUnitName.TabIndex = 5;
            this.lblUnitName.Text = "نام واحد:";
            // 
            // btnUnitSave
            // 
            this.btnUnitSave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUnitSave.Location = new System.Drawing.Point(364, 304);
            this.btnUnitSave.Name = "btnUnitSave";
            this.btnUnitSave.Size = new System.Drawing.Size(75, 34);
            this.btnUnitSave.TabIndex = 4;
            this.btnUnitSave.Text = "ثبت";
            this.btnUnitSave.UseVisualStyleBackColor = false;
            this.btnUnitSave.Click += new System.EventHandler(this.btnUnitSave_Click);
            // 
            // txtComm
            // 
            this.txtComm.Location = new System.Drawing.Point(47, 151);
            this.txtComm.Multiline = true;
            this.txtComm.Name = "txtComm";
            this.txtComm.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtComm.Size = new System.Drawing.Size(483, 112);
            this.txtComm.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(548, 239);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 2;
            // 
            // txtUnitName
            // 
            this.txtUnitName.Location = new System.Drawing.Point(430, 60);
            this.txtUnitName.Name = "txtUnitName";
            this.txtUnitName.Size = new System.Drawing.Size(100, 20);
            this.txtUnitName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(536, 63);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnReturn);
            this.tabPage2.Controls.Add(this.lblProK);
            this.tabPage2.Controls.Add(this.lblCommK);
            this.tabPage2.Controls.Add(this.lblUnitK);
            this.tabPage2.Controls.Add(this.lblCountK);
            this.tabPage2.Controls.Add(this.lblPriceK);
            this.tabPage2.Controls.Add(this.lblImgK);
            this.tabPage2.Controls.Add(this.lblNameK);
            this.tabPage2.Controls.Add(this.lblCodK);
            this.tabPage2.Controls.Add(this.txtCount);
            this.tabPage2.Controls.Add(this.txtPrice);
            this.tabPage2.Controls.Add(this.btnbrows);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.txtPro);
            this.tabPage2.Controls.Add(this.lblPro);
            this.tabPage2.Controls.Add(this.txtUnit);
            this.tabPage2.Controls.Add(this.txtImg);
            this.tabPage2.Controls.Add(this.lblSave);
            this.tabPage2.Controls.Add(this.txtComment);
            this.tabPage2.Controls.Add(this.txtName);
            this.tabPage2.Controls.Add(this.lblcount);
            this.tabPage2.Controls.Add(this.lblComment);
            this.tabPage2.Controls.Add(this.lblPrice);
            this.tabPage2.Controls.Add(this.lblImg);
            this.tabPage2.Controls.Add(this.lblName);
            this.tabPage2.Controls.Add(this.lblUnit);
            this.tabPage2.Controls.Add(this.txtCode);
            this.tabPage2.Controls.Add(this.lblCode);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(900, 417);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ثبت کالا";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // lblProK
            // 
            this.lblProK.AutoSize = true;
            this.lblProK.Location = new System.Drawing.Point(211, 149);
            this.lblProK.Name = "lblProK";
            this.lblProK.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblProK.Size = new System.Drawing.Size(61, 13);
            this.lblProK.TabIndex = 69;
            this.lblProK.Text = "تولید کننده:";
            // 
            // lblCommK
            // 
            this.lblCommK.AutoSize = true;
            this.lblCommK.Location = new System.Drawing.Point(737, 325);
            this.lblCommK.Name = "lblCommK";
            this.lblCommK.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCommK.Size = new System.Drawing.Size(52, 13);
            this.lblCommK.TabIndex = 68;
            this.lblCommK.Text = "توضیحات:";
            // 
            // lblUnitK
            // 
            this.lblUnitK.AutoSize = true;
            this.lblUnitK.Location = new System.Drawing.Point(219, 110);
            this.lblUnitK.Name = "lblUnitK";
            this.lblUnitK.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblUnitK.Size = new System.Drawing.Size(31, 13);
            this.lblUnitK.TabIndex = 67;
            this.lblUnitK.Text = "واحد:";
            // 
            // lblCountK
            // 
            this.lblCountK.AutoSize = true;
            this.lblCountK.Location = new System.Drawing.Point(219, 65);
            this.lblCountK.Name = "lblCountK";
            this.lblCountK.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCountK.Size = new System.Drawing.Size(33, 13);
            this.lblCountK.TabIndex = 66;
            this.lblCountK.Text = "تعداد:";
            // 
            // lblPriceK
            // 
            this.lblPriceK.AutoSize = true;
            this.lblPriceK.Location = new System.Drawing.Point(219, 26);
            this.lblPriceK.Name = "lblPriceK";
            this.lblPriceK.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPriceK.Size = new System.Drawing.Size(33, 13);
            this.lblPriceK.TabIndex = 65;
            this.lblPriceK.Text = "قیمت:";
            // 
            // lblImgK
            // 
            this.lblImgK.AutoSize = true;
            this.lblImgK.Location = new System.Drawing.Point(752, 148);
            this.lblImgK.Name = "lblImgK";
            this.lblImgK.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblImgK.Size = new System.Drawing.Size(38, 13);
            this.lblImgK.TabIndex = 64;
            this.lblImgK.Text = "تصویر:";
            // 
            // lblNameK
            // 
            this.lblNameK.AutoSize = true;
            this.lblNameK.Location = new System.Drawing.Point(752, 81);
            this.lblNameK.Name = "lblNameK";
            this.lblNameK.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblNameK.Size = new System.Drawing.Size(43, 13);
            this.lblNameK.TabIndex = 63;
            this.lblNameK.Text = "نام کالا:";
            // 
            // lblCodK
            // 
            this.lblCodK.AutoSize = true;
            this.lblCodK.Location = new System.Drawing.Point(752, 28);
            this.lblCodK.Name = "lblCodK";
            this.lblCodK.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCodK.Size = new System.Drawing.Size(42, 13);
            this.lblCodK.TabIndex = 62;
            this.lblCodK.Text = "کد کالا:";
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(107, 60);
            this.txtCount.Mask = "000000";
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(100, 20);
            this.txtCount.TabIndex = 61;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(107, 19);
            this.txtPrice.Mask = "00000000";
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 60;
            // 
            // btnbrows
            // 
            this.btnbrows.Location = new System.Drawing.Point(583, 144);
            this.btnbrows.Name = "btnbrows";
            this.btnbrows.Size = new System.Drawing.Size(45, 19);
            this.btnbrows.TabIndex = 59;
            this.btnbrows.Text = "brows";
            this.btnbrows.UseVisualStyleBackColor = true;
            this.btnbrows.Click += new System.EventHandler(this.btnbrows_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(494, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 79);
            this.pictureBox1.TabIndex = 58;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // txtPro
            // 
            this.txtPro.Location = new System.Drawing.Point(103, 145);
            this.txtPro.Name = "txtPro";
            this.txtPro.Size = new System.Drawing.Size(104, 20);
            this.txtPro.TabIndex = 57;
            // 
            // lblPro
            // 
            this.lblPro.AutoSize = true;
            this.lblPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblPro.Location = new System.Drawing.Point(213, 149);
            this.lblPro.Name = "lblPro";
            this.lblPro.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPro.Size = new System.Drawing.Size(0, 17);
            this.lblPro.TabIndex = 56;
            // 
            // txtUnit
            // 
            this.txtUnit.Location = new System.Drawing.Point(103, 103);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(104, 20);
            this.txtUnit.TabIndex = 55;
            // 
            // txtImg
            // 
            this.txtImg.Location = new System.Drawing.Point(634, 143);
            this.txtImg.Name = "txtImg";
            this.txtImg.Size = new System.Drawing.Size(104, 20);
            this.txtImg.TabIndex = 54;
            // 
            // lblSave
            // 
            this.lblSave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblSave.Location = new System.Drawing.Point(387, 366);
            this.lblSave.Name = "lblSave";
            this.lblSave.Size = new System.Drawing.Size(75, 32);
            this.lblSave.TabIndex = 53;
            this.lblSave.Text = "ثبت";
            this.lblSave.UseVisualStyleBackColor = false;
            this.lblSave.Click += new System.EventHandler(this.lblSave_Click_1);
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(186, 278);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(534, 71);
            this.txtComment.TabIndex = 52;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(634, 74);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(104, 20);
            this.txtName.TabIndex = 51;
            // 
            // lblcount
            // 
            this.lblcount.AutoSize = true;
            this.lblcount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblcount.Location = new System.Drawing.Point(213, 63);
            this.lblcount.Name = "lblcount";
            this.lblcount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblcount.Size = new System.Drawing.Size(0, 17);
            this.lblcount.TabIndex = 50;
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblComment.Location = new System.Drawing.Point(731, 311);
            this.lblComment.Name = "lblComment";
            this.lblComment.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblComment.Size = new System.Drawing.Size(0, 17);
            this.lblComment.TabIndex = 49;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblPrice.Location = new System.Drawing.Point(213, 22);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPrice.Size = new System.Drawing.Size(0, 17);
            this.lblPrice.TabIndex = 48;
            // 
            // lblImg
            // 
            this.lblImg.AutoSize = true;
            this.lblImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblImg.Location = new System.Drawing.Point(745, 146);
            this.lblImg.Name = "lblImg";
            this.lblImg.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblImg.Size = new System.Drawing.Size(0, 17);
            this.lblImg.TabIndex = 47;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblName.Location = new System.Drawing.Point(745, 74);
            this.lblName.Name = "lblName";
            this.lblName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblName.Size = new System.Drawing.Size(0, 17);
            this.lblName.TabIndex = 46;
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblUnit.Location = new System.Drawing.Point(213, 106);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblUnit.Size = new System.Drawing.Size(0, 17);
            this.lblUnit.TabIndex = 45;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(634, 22);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(104, 20);
            this.txtCode.TabIndex = 44;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblCode.Location = new System.Drawing.Point(745, 22);
            this.lblCode.Name = "lblCode";
            this.lblCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCode.Size = new System.Drawing.Size(0, 17);
            this.lblCode.TabIndex = 43;
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnReturn.Location = new System.Drawing.Point(276, 366);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(69, 32);
            this.btnReturn.TabIndex = 70;
            this.btnReturn.Text = "بازگشت";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(252, 304);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 32);
            this.button1.TabIndex = 71;
            this.button1.Text = "بازگشت";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // AddCommadity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 521);
            this.Controls.Add(this.tabControl1);
            this.Name = "AddCommadity";
            this.Text = "AddCommadity";
            this.Load += new System.EventHandler(this.AddCommadity_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnUnitSave;
        private System.Windows.Forms.TextBox txtComm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUnitName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.MaskedTextBox txtCount;
        private System.Windows.Forms.MaskedTextBox txtPrice;
        private System.Windows.Forms.Button btnbrows;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtPro;
        private System.Windows.Forms.Label lblPro;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.TextBox txtImg;
        private System.Windows.Forms.Button lblSave;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblcount;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblImg;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblCom;
        private System.Windows.Forms.Label lblUnitName;
        private System.Windows.Forms.Label lblCommK;
        private System.Windows.Forms.Label lblUnitK;
        private System.Windows.Forms.Label lblCountK;
        private System.Windows.Forms.Label lblPriceK;
        private System.Windows.Forms.Label lblImgK;
        private System.Windows.Forms.Label lblNameK;
        private System.Windows.Forms.Label lblCodK;
        private System.Windows.Forms.Label lblProK;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button button1;
    }
}