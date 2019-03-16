namespace FashionHousesProject
{
    partial class ChangeShopForm
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
            this.label_SH_ADRESS = new System.Windows.Forms.Label();
            this.label_SH_QTY_EMP = new System.Windows.Forms.Label();
            this.textBox_SH_ADRESS = new System.Windows.Forms.TextBox();
            this.textBox_SH_QTY_EMP = new System.Windows.Forms.TextBox();
            this.btn_CHANGE_SH = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_SH_ADRESS
            // 
            this.label_SH_ADRESS.AutoSize = true;
            this.label_SH_ADRESS.Location = new System.Drawing.Point(13, 32);
            this.label_SH_ADRESS.Name = "label_SH_ADRESS";
            this.label_SH_ADRESS.Size = new System.Drawing.Size(56, 17);
            this.label_SH_ADRESS.TabIndex = 0;
            this.label_SH_ADRESS.Text = "Адреса";
            // 
            // label_SH_QTY_EMP
            // 
            this.label_SH_QTY_EMP.AutoSize = true;
            this.label_SH_QTY_EMP.Location = new System.Drawing.Point(13, 75);
            this.label_SH_QTY_EMP.Name = "label_SH_QTY_EMP";
            this.label_SH_QTY_EMP.Size = new System.Drawing.Size(145, 17);
            this.label_SH_QTY_EMP.TabIndex = 1;
            this.label_SH_QTY_EMP.Text = "Кiлькiсть працiвникiв";
            // 
            // textBox_SH_ADRESS
            // 
            this.textBox_SH_ADRESS.Location = new System.Drawing.Point(203, 32);
            this.textBox_SH_ADRESS.Name = "textBox_SH_ADRESS";
            this.textBox_SH_ADRESS.Size = new System.Drawing.Size(131, 22);
            this.textBox_SH_ADRESS.TabIndex = 2;
            // 
            // textBox_SH_QTY_EMP
            // 
            this.textBox_SH_QTY_EMP.Location = new System.Drawing.Point(203, 75);
            this.textBox_SH_QTY_EMP.Name = "textBox_SH_QTY_EMP";
            this.textBox_SH_QTY_EMP.Size = new System.Drawing.Size(131, 22);
            this.textBox_SH_QTY_EMP.TabIndex = 3;
            // 
            // btn_CHANGE_SH
            // 
            this.btn_CHANGE_SH.Location = new System.Drawing.Point(16, 118);
            this.btn_CHANGE_SH.Name = "btn_CHANGE_SH";
            this.btn_CHANGE_SH.Size = new System.Drawing.Size(93, 42);
            this.btn_CHANGE_SH.TabIndex = 4;
            this.btn_CHANGE_SH.Text = "Змiнити Магазин";
            this.btn_CHANGE_SH.UseVisualStyleBackColor = true;
            this.btn_CHANGE_SH.Click += new System.EventHandler(this.btn_CHANGE_SH_Click);
            // 
            // ChangeShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 173);
            this.Controls.Add(this.btn_CHANGE_SH);
            this.Controls.Add(this.textBox_SH_QTY_EMP);
            this.Controls.Add(this.textBox_SH_ADRESS);
            this.Controls.Add(this.label_SH_QTY_EMP);
            this.Controls.Add(this.label_SH_ADRESS);
            this.MaximumSize = new System.Drawing.Size(410, 220);
            this.MinimumSize = new System.Drawing.Size(410, 220);
            this.Name = "ChangeShopForm";
            this.Text = "Змiнити Iнформацiю про магзин";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_SH_ADRESS;
        private System.Windows.Forms.Label label_SH_QTY_EMP;
        private System.Windows.Forms.TextBox textBox_SH_ADRESS;
        private System.Windows.Forms.TextBox textBox_SH_QTY_EMP;
        private System.Windows.Forms.Button btn_CHANGE_SH;
    }
}