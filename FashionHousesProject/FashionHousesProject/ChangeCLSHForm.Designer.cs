namespace FashionHousesProject
{
    partial class ChangeCLSHForm
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
            this.label_CLSH_QTY = new System.Windows.Forms.Label();
            this.label_CLSH_COST = new System.Windows.Forms.Label();
            this.textBox_CLSH_QTY = new System.Windows.Forms.TextBox();
            this.textBox_CLSH_COST = new System.Windows.Forms.TextBox();
            this.btn_CHANGE_CLSH = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_CLSH_QTY
            // 
            this.label_CLSH_QTY.AutoSize = true;
            this.label_CLSH_QTY.Location = new System.Drawing.Point(13, 35);
            this.label_CLSH_QTY.Name = "label_CLSH_QTY";
            this.label_CLSH_QTY.Size = new System.Drawing.Size(196, 17);
            this.label_CLSH_QTY.TabIndex = 0;
            this.label_CLSH_QTY.Text = "Кiлькiсть одиниць в магазинi";
            // 
            // label_CLSH_COST
            // 
            this.label_CLSH_COST.AutoSize = true;
            this.label_CLSH_COST.Location = new System.Drawing.Point(16, 75);
            this.label_CLSH_COST.Name = "label_CLSH_COST";
            this.label_CLSH_COST.Size = new System.Drawing.Size(64, 17);
            this.label_CLSH_COST.TabIndex = 1;
            this.label_CLSH_COST.Text = "Вартiсть";
            // 
            // textBox_CLSH_QTY
            // 
            this.textBox_CLSH_QTY.Location = new System.Drawing.Point(260, 35);
            this.textBox_CLSH_QTY.Name = "textBox_CLSH_QTY";
            this.textBox_CLSH_QTY.Size = new System.Drawing.Size(141, 22);
            this.textBox_CLSH_QTY.TabIndex = 2;
            // 
            // textBox_CLSH_COST
            // 
            this.textBox_CLSH_COST.Location = new System.Drawing.Point(260, 75);
            this.textBox_CLSH_COST.Name = "textBox_CLSH_COST";
            this.textBox_CLSH_COST.Size = new System.Drawing.Size(141, 22);
            this.textBox_CLSH_COST.TabIndex = 3;
            // 
            // btn_CHANGE_CLSH
            // 
            this.btn_CHANGE_CLSH.Location = new System.Drawing.Point(16, 120);
            this.btn_CHANGE_CLSH.Name = "btn_CHANGE_CLSH";
            this.btn_CHANGE_CLSH.Size = new System.Drawing.Size(127, 77);
            this.btn_CHANGE_CLSH.TabIndex = 4;
            this.btn_CHANGE_CLSH.Text = "Змiнити iнформацiю про одяг в магазинi";
            this.btn_CHANGE_CLSH.UseVisualStyleBackColor = true;
            this.btn_CHANGE_CLSH.Click += new System.EventHandler(this.btn_CHANGE_CLSH_Click);
            // 
            // ChangeCLSHForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 233);
            this.Controls.Add(this.btn_CHANGE_CLSH);
            this.Controls.Add(this.textBox_CLSH_COST);
            this.Controls.Add(this.textBox_CLSH_QTY);
            this.Controls.Add(this.label_CLSH_COST);
            this.Controls.Add(this.label_CLSH_QTY);
            this.MaximumSize = new System.Drawing.Size(530, 280);
            this.MinimumSize = new System.Drawing.Size(530, 280);
            this.Name = "ChangeCLSHForm";
            this.Text = "Зміна інформації про одяг в магазині";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_CLSH_QTY;
        private System.Windows.Forms.Label label_CLSH_COST;
        private System.Windows.Forms.TextBox textBox_CLSH_QTY;
        private System.Windows.Forms.TextBox textBox_CLSH_COST;
        private System.Windows.Forms.Button btn_CHANGE_CLSH;
    }
}