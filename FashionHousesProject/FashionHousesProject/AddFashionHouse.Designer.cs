namespace FashionHousesProject
{
    partial class AddFashionHouse
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
            this.label_FH_NAME = new System.Windows.Forms.Label();
            this.label_FH_ADRESS = new System.Windows.Forms.Label();
            this.textBox_FH_NAME = new System.Windows.Forms.TextBox();
            this.textBox_FH_ADRESS = new System.Windows.Forms.TextBox();
            this.btn_ADD_FH = new System.Windows.Forms.Button();
            this.label_PR_NAME = new System.Windows.Forms.Label();
            this.label_PR_PASSPORT = new System.Windows.Forms.Label();
            this.textBox_PR_NAME = new System.Windows.Forms.TextBox();
            this.textBox_PR_PASSPORT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_FH_NAME
            // 
            this.label_FH_NAME.AutoSize = true;
            this.label_FH_NAME.Location = new System.Drawing.Point(13, 38);
            this.label_FH_NAME.Name = "label_FH_NAME";
            this.label_FH_NAME.Size = new System.Drawing.Size(130, 17);
            this.label_FH_NAME.TabIndex = 0;
            this.label_FH_NAME.Text = " Назва Дому Моди";
            // 
            // label_FH_ADRESS
            // 
            this.label_FH_ADRESS.AutoSize = true;
            this.label_FH_ADRESS.Location = new System.Drawing.Point(16, 98);
            this.label_FH_ADRESS.Name = "label_FH_ADRESS";
            this.label_FH_ADRESS.Size = new System.Drawing.Size(134, 17);
            this.label_FH_ADRESS.TabIndex = 1;
            this.label_FH_ADRESS.Text = "Адреса Дому Моди";
            // 
            // textBox_FH_NAME
            // 
            this.textBox_FH_NAME.Location = new System.Drawing.Point(217, 38);
            this.textBox_FH_NAME.Name = "textBox_FH_NAME";
            this.textBox_FH_NAME.Size = new System.Drawing.Size(149, 22);
            this.textBox_FH_NAME.TabIndex = 2;
            // 
            // textBox_FH_ADRESS
            // 
            this.textBox_FH_ADRESS.Location = new System.Drawing.Point(217, 92);
            this.textBox_FH_ADRESS.Name = "textBox_FH_ADRESS";
            this.textBox_FH_ADRESS.Size = new System.Drawing.Size(149, 22);
            this.textBox_FH_ADRESS.TabIndex = 3;
            // 
            // btn_ADD_FH
            // 
            this.btn_ADD_FH.Location = new System.Drawing.Point(12, 234);
            this.btn_ADD_FH.Name = "btn_ADD_FH";
            this.btn_ADD_FH.Size = new System.Drawing.Size(131, 57);
            this.btn_ADD_FH.TabIndex = 4;
            this.btn_ADD_FH.Text = "Додати Дом Моди";
            this.btn_ADD_FH.UseVisualStyleBackColor = true;
            this.btn_ADD_FH.Click += new System.EventHandler(this.btn_ADD_FH_Click);
            // 
            // label_PR_NAME
            // 
            this.label_PR_NAME.AutoSize = true;
            this.label_PR_NAME.Location = new System.Drawing.Point(16, 144);
            this.label_PR_NAME.Name = "label_PR_NAME";
            this.label_PR_NAME.Size = new System.Drawing.Size(114, 17);
            this.label_PR_NAME.TabIndex = 5;
            this.label_PR_NAME.Text = "ПIБ Президента";
            // 
            // label_PR_PASSPORT
            // 
            this.label_PR_PASSPORT.Location = new System.Drawing.Point(19, 187);
            this.label_PR_PASSPORT.Name = "label_PR_PASSPORT";
            this.label_PR_PASSPORT.Size = new System.Drawing.Size(124, 44);
            this.label_PR_PASSPORT.TabIndex = 6;
            this.label_PR_PASSPORT.Text = "Номер паспорта президента";
            // 
            // textBox_PR_NAME
            // 
            this.textBox_PR_NAME.Location = new System.Drawing.Point(217, 144);
            this.textBox_PR_NAME.Name = "textBox_PR_NAME";
            this.textBox_PR_NAME.Size = new System.Drawing.Size(149, 22);
            this.textBox_PR_NAME.TabIndex = 7;
            // 
            // textBox_PR_PASSPORT
            // 
            this.textBox_PR_PASSPORT.Location = new System.Drawing.Point(217, 187);
            this.textBox_PR_PASSPORT.Name = "textBox_PR_PASSPORT";
            this.textBox_PR_PASSPORT.Size = new System.Drawing.Size(149, 22);
            this.textBox_PR_PASSPORT.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 9;
            // 
            // AddFashionHouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 313);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_PR_PASSPORT);
            this.Controls.Add(this.textBox_PR_NAME);
            this.Controls.Add(this.label_PR_PASSPORT);
            this.Controls.Add(this.label_PR_NAME);
            this.Controls.Add(this.btn_ADD_FH);
            this.Controls.Add(this.textBox_FH_ADRESS);
            this.Controls.Add(this.textBox_FH_NAME);
            this.Controls.Add(this.label_FH_ADRESS);
            this.Controls.Add(this.label_FH_NAME);
            this.MaximumSize = new System.Drawing.Size(410, 360);
            this.MinimumSize = new System.Drawing.Size(410, 360);
            this.Name = "AddFashionHouse";
            this.Text = "Додати Дом Моди";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_FH_NAME;
        private System.Windows.Forms.Label label_FH_ADRESS;
        private System.Windows.Forms.TextBox textBox_FH_NAME;
        private System.Windows.Forms.TextBox textBox_FH_ADRESS;
        private System.Windows.Forms.Button btn_ADD_FH;
        private System.Windows.Forms.Label label_PR_NAME;
        private System.Windows.Forms.Label label_PR_PASSPORT;
        private System.Windows.Forms.TextBox textBox_PR_NAME;
        private System.Windows.Forms.TextBox textBox_PR_PASSPORT;
        private System.Windows.Forms.Label label1;
    }
}