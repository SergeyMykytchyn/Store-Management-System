namespace FashionHousesProject
{
    partial class AddDivisionForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_DIV_NAME = new System.Windows.Forms.TextBox();
            this.textBox_DIV_ADRESS = new System.Windows.Forms.TextBox();
            this.textBox_DIV_QTY = new System.Windows.Forms.TextBox();
            this.btn_DIV_ADD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_DIV_NAME
            // 
            this.label_DIV_NAME.AutoSize = true;
            this.label_DIV_NAME.Location = new System.Drawing.Point(23, 40);
            this.label_DIV_NAME.Name = "label_DIV_NAME";
            this.label_DIV_NAME.Size = new System.Drawing.Size(123, 17);
            this.label_DIV_NAME.TabIndex = 0;
            this.label_DIV_NAME.Text = "Назва Пiдроздiла";
            // 
            // label_DIV_ADRESS
            // 
            this.label_DIV_ADRESS.AutoSize = true;
            this.label_DIV_ADRESS.Location = new System.Drawing.Point(26, 89);
            this.label_DIV_ADRESS.Name = "label_DIV_ADRESS";
            this.label_DIV_ADRESS.Size = new System.Drawing.Size(56, 17);
            this.label_DIV_ADRESS.TabIndex = 1;
            this.label_DIV_ADRESS.Text = "Адреса";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Кiлькiсть Працiвникiв";
            // 
            // textBox_DIV_NAME
            // 
            this.textBox_DIV_NAME.Location = new System.Drawing.Point(230, 40);
            this.textBox_DIV_NAME.Name = "textBox_DIV_NAME";
            this.textBox_DIV_NAME.Size = new System.Drawing.Size(134, 22);
            this.textBox_DIV_NAME.TabIndex = 3;
            // 
            // textBox_DIV_ADRESS
            // 
            this.textBox_DIV_ADRESS.Location = new System.Drawing.Point(230, 83);
            this.textBox_DIV_ADRESS.Name = "textBox_DIV_ADRESS";
            this.textBox_DIV_ADRESS.Size = new System.Drawing.Size(134, 22);
            this.textBox_DIV_ADRESS.TabIndex = 4;
            // 
            // textBox_DIV_QTY
            // 
            this.textBox_DIV_QTY.Location = new System.Drawing.Point(230, 129);
            this.textBox_DIV_QTY.Name = "textBox_DIV_QTY";
            this.textBox_DIV_QTY.Size = new System.Drawing.Size(134, 22);
            this.textBox_DIV_QTY.TabIndex = 5;
            // 
            // btn_DIV_ADD
            // 
            this.btn_DIV_ADD.Location = new System.Drawing.Point(32, 191);
            this.btn_DIV_ADD.Name = "btn_DIV_ADD";
            this.btn_DIV_ADD.Size = new System.Drawing.Size(114, 49);
            this.btn_DIV_ADD.TabIndex = 6;
            this.btn_DIV_ADD.Text = "Додати Пiдроздiл";
            this.btn_DIV_ADD.UseVisualStyleBackColor = true;
            this.btn_DIV_ADD.Click += new System.EventHandler(this.btn_DIV_ADD_Click);
            // 
            // AddDivisionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 253);
            this.Controls.Add(this.btn_DIV_ADD);
            this.Controls.Add(this.textBox_DIV_QTY);
            this.Controls.Add(this.textBox_DIV_ADRESS);
            this.Controls.Add(this.textBox_DIV_NAME);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_DIV_ADRESS);
            this.Controls.Add(this.label_DIV_NAME);
            this.MaximumSize = new System.Drawing.Size(420, 300);
            this.MinimumSize = new System.Drawing.Size(420, 300);
            this.Name = "AddDivisionForm";
            this.Text = "Додати Пiдроздiл до Дому Моди";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_DIV_NAME;
        private System.Windows.Forms.Label label_DIV_ADRESS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_DIV_NAME;
        private System.Windows.Forms.TextBox textBox_DIV_ADRESS;
        private System.Windows.Forms.TextBox textBox_DIV_QTY;
        private System.Windows.Forms.Button btn_DIV_ADD;
    }
}