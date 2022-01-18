namespace WindowsFormsApplication1
{
    partial class Default
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
            this.btnAnbar = new System.Windows.Forms.Button();
            this.btnBuy = new System.Windows.Forms.Button();
            this.btnCommadity = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAnbar
            // 
            this.btnAnbar.Location = new System.Drawing.Point(183, 41);
            this.btnAnbar.Name = "btnAnbar";
            this.btnAnbar.Size = new System.Drawing.Size(106, 41);
            this.btnAnbar.TabIndex = 0;
            this.btnAnbar.Text = "انبار داری";
            this.btnAnbar.UseVisualStyleBackColor = true;
            this.btnAnbar.Click += new System.EventHandler(this.btnAnbar_Click);
            // 
            // btnBuy
            // 
            this.btnBuy.Location = new System.Drawing.Point(183, 184);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(106, 49);
            this.btnBuy.TabIndex = 1;
            this.btnBuy.Text = "خرید ";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // btnCommadity
            // 
            this.btnCommadity.Location = new System.Drawing.Point(183, 112);
            this.btnCommadity.Name = "btnCommadity";
            this.btnCommadity.Size = new System.Drawing.Size(106, 44);
            this.btnCommadity.TabIndex = 2;
            this.btnCommadity.Text = "درج کالا";
            this.btnCommadity.UseVisualStyleBackColor = true;
            this.btnCommadity.Click += new System.EventHandler(this.btnCommadity_Click);
            // 
            // Default
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 325);
            this.Controls.Add(this.btnCommadity);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.btnAnbar);
            this.Name = "Default";
            this.Text = "Default";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAnbar;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.Button btnCommadity;
    }
}