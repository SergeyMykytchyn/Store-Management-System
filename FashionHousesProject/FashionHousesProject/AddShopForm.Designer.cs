namespace FashionHousesProject
{
    partial class AddShopForm
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
            this.label_FH_ADRESS = new System.Windows.Forms.Label();
            this.label_QTY_EMP = new System.Windows.Forms.Label();
            this.textBox_SH_ADRESS = new System.Windows.Forms.TextBox();
            this.textBox_SH_QTY_EMP = new System.Windows.Forms.TextBox();
            this.btn_ADD_SH = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_FH_ADRESS
            // 
            this.label_FH_ADRESS.AutoSize = true;
            this.label_FH_ADRESS.Location = new System.Drawing.Point(13, 43);
            this.label_FH_ADRESS.Name = "label_FH_ADRESS";
            this.label_FH_ADRESS.Size = new System.Drawing.Size(56, 17);
            this.label_FH_ADRESS.TabIndex = 0;
            this.label_FH_ADRESS.Text = "Адреса";
            // 
            // label_QTY_EMP
            // 
            this.label_QTY_EMP.AutoSize = true;
            this.label_QTY_EMP.Location = new System.Drawing.Point(16, 94);
            this.label_QTY_EMP.Name = "label_QTY_EMP";
            this.label_QTY_EMP.Size = new System.Drawing.Size(145, 17);
            this.label_QTY_EMP.TabIndex = 1;
            this.label_QTY_EMP.Text = "Кiлькiсть працiвникiв";
            // 
            // textBox_SH_ADRESS
            // 
            this.textBox_SH_ADRESS.Location = new System.Drawing.Point(177, 40);
            this.textBox_SH_ADRESS.Name = "textBox_SH_ADRESS";
            this.textBox_SH_ADRESS.Size = new System.Drawing.Size(122, 22);
            this.textBox_SH_ADRESS.TabIndex = 2;
            // 
            // textBox_SH_QTY_EMP
            // 
            this.textBox_SH_QTY_EMP.Location = new System.Drawing.Point(177, 94);
            this.textBox_SH_QTY_EMP.Name = "textBox_SH_QTY_EMP";
            this.textBox_SH_QTY_EMP.Size = new System.Drawing.Size(122, 22);
            this.textBox_SH_QTY_EMP.TabIndex = 3;
            // 
            // btn_ADD_SH
            // 
            this.btn_ADD_SH.Location = new System.Drawing.Point(19, 145);
            this.btn_ADD_SH.Name = "btn_ADD_SH";
            this.btn_ADD_SH.Size = new System.Drawing.Size(122, 56);
            this.btn_ADD_SH.TabIndex = 4;
            this.btn_ADD_SH.Text = "Додати Магазин";
            this.btn_ADD_SH.UseVisualStyleBackColor = true;
            this.btn_ADD_SH.Click += new System.EventHandler(this.btn_ADD_SH_Click);
            // 
            // AddShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 223);
            this.Controls.Add(this.btn_ADD_SH);
            this.Controls.Add(this.textBox_SH_QTY_EMP);
            this.Controls.Add(this.textBox_SH_ADRESS);
            this.Controls.Add(this.label_QTY_EMP);
            this.Controls.Add(this.label_FH_ADRESS);
            this.MaximumSize = new System.Drawing.Size(350, 270);
            this.MinimumSize = new System.Drawing.Size(350, 270);
            this.Name = "AddShopForm";
            this.Text = "Додати Магазин";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_FH_ADRESS;
        private System.Windows.Forms.Label label_QTY_EMP;
        private System.Windows.Forms.TextBox textBox_SH_ADRESS;
        private System.Windows.Forms.TextBox textBox_SH_QTY_EMP;
        private System.Windows.Forms.Button btn_ADD_SH;
    }
}