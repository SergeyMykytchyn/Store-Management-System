namespace FashionHousesProject
{
    partial class ChangeDivision
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
            this.label_DIV_NAME = new System.Windows.Forms.Label();
            this.label_DIV_ADRESS = new System.Windows.Forms.Label();
            this.textBox_DIV_NAME = new System.Windows.Forms.TextBox();
            this.textBox_DIV_ADRESS = new System.Windows.Forms.TextBox();
            this.textBox_DIV_QTY = new System.Windows.Forms.TextBox();
            this.label_DIV_QTY = new System.Windows.Forms.Label();
            this.btn_CHANGE_DIV = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_DIV_NAME
            // 
            this.label_DIV_NAME.AutoSize = true;
            this.label_DIV_NAME.Location = new System.Drawing.Point(16, 23);
            this.label_DIV_NAME.Name = "label_DIV_NAME";
            this.label_DIV_NAME.Size = new System.Drawing.Size(48, 17);
            this.label_DIV_NAME.TabIndex = 0;
            this.label_DIV_NAME.Text = "Назва";
            // 
            // label_DIV_ADRESS
            // 
            this.label_DIV_ADRESS.AutoSize = true;
            this.label_DIV_ADRESS.Location = new System.Drawing.Point(16, 77);
            this.label_DIV_ADRESS.Name = "label_DIV_ADRESS";
            this.label_DIV_ADRESS.Size = new System.Drawing.Size(56, 17);
            this.label_DIV_ADRESS.TabIndex = 1;
            this.label_DIV_ADRESS.Text = "Адреса";
            // 
            // textBox_DIV_NAME
            // 
            this.textBox_DIV_NAME.Location = new System.Drawing.Point(128, 23);
            this.textBox_DIV_NAME.Name = "textBox_DIV_NAME";
            this.textBox_DIV_NAME.Size = new System.Drawing.Size(100, 22);
            this.textBox_DIV_NAME.TabIndex = 2;
            // 
            // textBox_DIV_ADRESS
            // 
            this.textBox_DIV_ADRESS.Location = new System.Drawing.Point(128, 77);
            this.textBox_DIV_ADRESS.Name = "textBox_DIV_ADRESS";
            this.textBox_DIV_ADRESS.Size = new System.Drawing.Size(100, 22);
            this.textBox_DIV_ADRESS.TabIndex = 3;
            // 
            // textBox_DIV_QTY
            // 
            this.textBox_DIV_QTY.Location = new System.Drawing.Point(128, 128);
            this.textBox_DIV_QTY.Name = "textBox_DIV_QTY";
            this.textBox_DIV_QTY.Size = new System.Drawing.Size(100, 22);
            this.textBox_DIV_QTY.TabIndex = 4;
            // 
            // label_DIV_QTY
            // 
            this.label_DIV_QTY.AutoSize = true;
            this.label_DIV_QTY.Location = new System.Drawing.Point(19, 132);
            this.label_DIV_QTY.Name = "label_DIV_QTY";
            this.label_DIV_QTY.Size = new System.Drawing.Size(66, 17);
            this.label_DIV_QTY.TabIndex = 5;
            this.label_DIV_QTY.Text = "Кiлькiсть";
            // 
            // btn_CHANGE_DIV
            // 
            this.btn_CHANGE_DIV.Location = new System.Drawing.Point(51, 183);
            this.btn_CHANGE_DIV.Name = "btn_CHANGE_DIV";
            this.btn_CHANGE_DIV.Size = new System.Drawing.Size(141, 81);
            this.btn_CHANGE_DIV.TabIndex = 6;
            this.btn_CHANGE_DIV.Text = "Змiнити Iнформацiю про пiдроздiл";
            this.btn_CHANGE_DIV.UseVisualStyleBackColor = true;
            this.btn_CHANGE_DIV.Click += new System.EventHandler(this.btn_CHANGE_DIV_Click);
            // 
            // ChangeDivision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 283);
            this.Controls.Add(this.btn_CHANGE_DIV);
            this.Controls.Add(this.label_DIV_QTY);
            this.Controls.Add(this.textBox_DIV_QTY);
            this.Controls.Add(this.textBox_DIV_ADRESS);
            this.Controls.Add(this.textBox_DIV_NAME);
            this.Controls.Add(this.label_DIV_ADRESS);
            this.Controls.Add(this.label_DIV_NAME);
            this.MaximumSize = new System.Drawing.Size(270, 330);
            this.MinimumSize = new System.Drawing.Size(270, 330);
            this.Name = "ChangeDivision";
            this.Text = "Змiна Iнформацii про пiдроздiл";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_DIV_NAME;
        private System.Windows.Forms.Label label_DIV_ADRESS;
        private System.Windows.Forms.TextBox textBox_DIV_NAME;
        private System.Windows.Forms.TextBox textBox_DIV_ADRESS;
        private System.Windows.Forms.TextBox textBox_DIV_QTY;
        private System.Windows.Forms.Label label_DIV_QTY;
        private System.Windows.Forms.Button btn_CHANGE_DIV;
    }
}