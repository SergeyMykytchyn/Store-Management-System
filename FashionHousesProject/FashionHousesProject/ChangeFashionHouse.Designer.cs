namespace FashionHousesProject
{
    partial class ChangeFashionHouse
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
            this.label_PR_NAME = new System.Windows.Forms.Label();
            this.label_PR_PASSPORT = new System.Windows.Forms.Label();
            this.textBox_FH_NAME = new System.Windows.Forms.TextBox();
            this.textBox_FH_ADRESS = new System.Windows.Forms.TextBox();
            this.textBox_PR_NAME = new System.Windows.Forms.TextBox();
            this.textBox_PR_PASSPORT = new System.Windows.Forms.TextBox();
            this.btn_FH_CHANGE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_FH_NAME
            // 
            this.label_FH_NAME.AutoSize = true;
            this.label_FH_NAME.Location = new System.Drawing.Point(22, 36);
            this.label_FH_NAME.Name = "label_FH_NAME";
            this.label_FH_NAME.Size = new System.Drawing.Size(127, 17);
            this.label_FH_NAME.TabIndex = 0;
            this.label_FH_NAME.Text = "Назва Дома Моди";
            // 
            // label_FH_ADRESS
            // 
            this.label_FH_ADRESS.AutoSize = true;
            this.label_FH_ADRESS.Location = new System.Drawing.Point(25, 79);
            this.label_FH_ADRESS.Name = "label_FH_ADRESS";
            this.label_FH_ADRESS.Size = new System.Drawing.Size(135, 17);
            this.label_FH_ADRESS.TabIndex = 1;
            this.label_FH_ADRESS.Text = "Адреса Дома Моди";
            // 
            // label_PR_NAME
            // 
            this.label_PR_NAME.AutoSize = true;
            this.label_PR_NAME.Location = new System.Drawing.Point(25, 123);
            this.label_PR_NAME.Name = "label_PR_NAME";
            this.label_PR_NAME.Size = new System.Drawing.Size(114, 17);
            this.label_PR_NAME.TabIndex = 2;
            this.label_PR_NAME.Text = "ПIБ Президента";
            // 
            // label_PR_PASSPORT
            // 
            this.label_PR_PASSPORT.AutoSize = true;
            this.label_PR_PASSPORT.Location = new System.Drawing.Point(25, 169);
            this.label_PR_PASSPORT.Name = "label_PR_PASSPORT";
            this.label_PR_PASSPORT.Size = new System.Drawing.Size(146, 17);
            this.label_PR_PASSPORT.TabIndex = 3;
            this.label_PR_PASSPORT.Text = "Паспорт президента";
            // 
            // textBox_FH_NAME
            // 
            this.textBox_FH_NAME.Location = new System.Drawing.Point(229, 36);
            this.textBox_FH_NAME.Name = "textBox_FH_NAME";
            this.textBox_FH_NAME.Size = new System.Drawing.Size(137, 22);
            this.textBox_FH_NAME.TabIndex = 4;
            // 
            // textBox_FH_ADRESS
            // 
            this.textBox_FH_ADRESS.Location = new System.Drawing.Point(229, 79);
            this.textBox_FH_ADRESS.Name = "textBox_FH_ADRESS";
            this.textBox_FH_ADRESS.Size = new System.Drawing.Size(137, 22);
            this.textBox_FH_ADRESS.TabIndex = 5;
            // 
            // textBox_PR_NAME
            // 
            this.textBox_PR_NAME.Location = new System.Drawing.Point(229, 123);
            this.textBox_PR_NAME.Name = "textBox_PR_NAME";
            this.textBox_PR_NAME.Size = new System.Drawing.Size(137, 22);
            this.textBox_PR_NAME.TabIndex = 6;
            // 
            // textBox_PR_PASSPORT
            // 
            this.textBox_PR_PASSPORT.Location = new System.Drawing.Point(229, 169);
            this.textBox_PR_PASSPORT.Name = "textBox_PR_PASSPORT";
            this.textBox_PR_PASSPORT.Size = new System.Drawing.Size(137, 22);
            this.textBox_PR_PASSPORT.TabIndex = 7;
            // 
            // btn_FH_CHANGE
            // 
            this.btn_FH_CHANGE.Location = new System.Drawing.Point(25, 222);
            this.btn_FH_CHANGE.Name = "btn_FH_CHANGE";
            this.btn_FH_CHANGE.Size = new System.Drawing.Size(85, 44);
            this.btn_FH_CHANGE.TabIndex = 8;
            this.btn_FH_CHANGE.Text = "Змiнити";
            this.btn_FH_CHANGE.UseVisualStyleBackColor = true;
            this.btn_FH_CHANGE.Click += new System.EventHandler(this.btn_FH_CHANGE_Click);
            // 
            // ChangeFashionHouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 283);
            this.Controls.Add(this.btn_FH_CHANGE);
            this.Controls.Add(this.textBox_PR_PASSPORT);
            this.Controls.Add(this.textBox_PR_NAME);
            this.Controls.Add(this.textBox_FH_ADRESS);
            this.Controls.Add(this.textBox_FH_NAME);
            this.Controls.Add(this.label_PR_PASSPORT);
            this.Controls.Add(this.label_PR_NAME);
            this.Controls.Add(this.label_FH_ADRESS);
            this.Controls.Add(this.label_FH_NAME);
            this.MaximumSize = new System.Drawing.Size(400, 330);
            this.MinimumSize = new System.Drawing.Size(400, 330);
            this.Name = "ChangeFashionHouse";
            this.Text = "Змiнити Дом Моди";
            this.Load += new System.EventHandler(this.ChangeFashionHouse_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_FH_NAME;
        private System.Windows.Forms.Label label_FH_ADRESS;
        private System.Windows.Forms.Label label_PR_NAME;
        private System.Windows.Forms.Label label_PR_PASSPORT;
        private System.Windows.Forms.TextBox textBox_FH_NAME;
        private System.Windows.Forms.TextBox textBox_FH_ADRESS;
        private System.Windows.Forms.TextBox textBox_PR_NAME;
        private System.Windows.Forms.TextBox textBox_PR_PASSPORT;
        private System.Windows.Forms.Button btn_FH_CHANGE;
    }
}