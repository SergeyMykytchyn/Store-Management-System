namespace FashionHousesProject
{
    partial class ChangeDesignerForm
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
            this.label_DES_NAME = new System.Windows.Forms.Label();
            this.label_DES_PASSPORT = new System.Windows.Forms.Label();
            this.label_DES_GENDER = new System.Windows.Forms.Label();
            this.label_DES_FH_NAME = new System.Windows.Forms.Label();
            this.label_DES_BIRTHDAY = new System.Windows.Forms.Label();
            this.textBox_DES_NAME = new System.Windows.Forms.TextBox();
            this.textBox_DES_PASSPORT = new System.Windows.Forms.TextBox();
            this.textBox_DES_GENDER = new System.Windows.Forms.TextBox();
            this.textBox_DES_BIRTHDAY = new System.Windows.Forms.TextBox();
            this.comboBox_DES_FH_NAME = new System.Windows.Forms.ComboBox();
            this.btn_DES_CHANGE = new System.Windows.Forms.Button();
            this.fashionHousesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fashionHousesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label_DES_NAME
            // 
            this.label_DES_NAME.AutoSize = true;
            this.label_DES_NAME.Location = new System.Drawing.Point(13, 30);
            this.label_DES_NAME.Name = "label_DES_NAME";
            this.label_DES_NAME.Size = new System.Drawing.Size(108, 17);
            this.label_DES_NAME.TabIndex = 0;
            this.label_DES_NAME.Text = "ПIБ Дизайнера";
            // 
            // label_DES_PASSPORT
            // 
            this.label_DES_PASSPORT.AutoSize = true;
            this.label_DES_PASSPORT.Location = new System.Drawing.Point(13, 71);
            this.label_DES_PASSPORT.Name = "label_DES_PASSPORT";
            this.label_DES_PASSPORT.Size = new System.Drawing.Size(64, 17);
            this.label_DES_PASSPORT.TabIndex = 1;
            this.label_DES_PASSPORT.Text = "Паспорт";
            // 
            // label_DES_GENDER
            // 
            this.label_DES_GENDER.AutoSize = true;
            this.label_DES_GENDER.Location = new System.Drawing.Point(13, 112);
            this.label_DES_GENDER.Name = "label_DES_GENDER";
            this.label_DES_GENDER.Size = new System.Drawing.Size(34, 17);
            this.label_DES_GENDER.TabIndex = 2;
            this.label_DES_GENDER.Text = "Пол";
            // 
            // label_DES_FH_NAME
            // 
            this.label_DES_FH_NAME.AutoSize = true;
            this.label_DES_FH_NAME.Location = new System.Drawing.Point(13, 152);
            this.label_DES_FH_NAME.Name = "label_DES_FH_NAME";
            this.label_DES_FH_NAME.Size = new System.Drawing.Size(75, 17);
            this.label_DES_FH_NAME.TabIndex = 3;
            this.label_DES_FH_NAME.Text = "Дом Моди";
            // 
            // label_DES_BIRTHDAY
            // 
            this.label_DES_BIRTHDAY.AutoSize = true;
            this.label_DES_BIRTHDAY.Location = new System.Drawing.Point(16, 191);
            this.label_DES_BIRTHDAY.Name = "label_DES_BIRTHDAY";
            this.label_DES_BIRTHDAY.Size = new System.Drawing.Size(129, 17);
            this.label_DES_BIRTHDAY.TabIndex = 4;
            this.label_DES_BIRTHDAY.Text = "День Народження";
            // 
            // textBox_DES_NAME
            // 
            this.textBox_DES_NAME.Location = new System.Drawing.Point(186, 30);
            this.textBox_DES_NAME.Name = "textBox_DES_NAME";
            this.textBox_DES_NAME.Size = new System.Drawing.Size(134, 22);
            this.textBox_DES_NAME.TabIndex = 5;
            // 
            // textBox_DES_PASSPORT
            // 
            this.textBox_DES_PASSPORT.Location = new System.Drawing.Point(186, 71);
            this.textBox_DES_PASSPORT.Name = "textBox_DES_PASSPORT";
            this.textBox_DES_PASSPORT.Size = new System.Drawing.Size(134, 22);
            this.textBox_DES_PASSPORT.TabIndex = 6;
            // 
            // textBox_DES_GENDER
            // 
            this.textBox_DES_GENDER.Location = new System.Drawing.Point(186, 112);
            this.textBox_DES_GENDER.Name = "textBox_DES_GENDER";
            this.textBox_DES_GENDER.Size = new System.Drawing.Size(134, 22);
            this.textBox_DES_GENDER.TabIndex = 7;
            // 
            // textBox_DES_BIRTHDAY
            // 
            this.textBox_DES_BIRTHDAY.Location = new System.Drawing.Point(186, 191);
            this.textBox_DES_BIRTHDAY.Name = "textBox_DES_BIRTHDAY";
            this.textBox_DES_BIRTHDAY.Size = new System.Drawing.Size(134, 22);
            this.textBox_DES_BIRTHDAY.TabIndex = 9;
            // 
            // comboBox_DES_FH_NAME
            // 
            this.comboBox_DES_FH_NAME.DataSource = this.fashionHousesBindingSource;
            this.comboBox_DES_FH_NAME.DisplayMember = "FH_NAME";
            this.comboBox_DES_FH_NAME.FormattingEnabled = true;
            this.comboBox_DES_FH_NAME.Location = new System.Drawing.Point(186, 152);
            this.comboBox_DES_FH_NAME.Name = "comboBox_DES_FH_NAME";
            this.comboBox_DES_FH_NAME.Size = new System.Drawing.Size(134, 24);
            this.comboBox_DES_FH_NAME.TabIndex = 10;
            this.comboBox_DES_FH_NAME.ValueMember = "FH_ID";
            // 
            // btn_DES_CHANGE
            // 
            this.btn_DES_CHANGE.Location = new System.Drawing.Point(105, 233);
            this.btn_DES_CHANGE.Name = "btn_DES_CHANGE";
            this.btn_DES_CHANGE.Size = new System.Drawing.Size(132, 72);
            this.btn_DES_CHANGE.TabIndex = 11;
            this.btn_DES_CHANGE.Text = "Змiнити Iнформацiю про дизайнера";
            this.btn_DES_CHANGE.UseVisualStyleBackColor = true;
            this.btn_DES_CHANGE.Click += new System.EventHandler(this.btn_DES_CHANGE_Click);
            // 
            // fashionHousesBindingSource
            // 
            this.fashionHousesBindingSource.DataSource = typeof(ClassLibraryFashionHousesEF.FashionHouses);
            // 
            // ChangeDesignerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 313);
            this.Controls.Add(this.btn_DES_CHANGE);
            this.Controls.Add(this.comboBox_DES_FH_NAME);
            this.Controls.Add(this.textBox_DES_BIRTHDAY);
            this.Controls.Add(this.textBox_DES_GENDER);
            this.Controls.Add(this.textBox_DES_PASSPORT);
            this.Controls.Add(this.textBox_DES_NAME);
            this.Controls.Add(this.label_DES_BIRTHDAY);
            this.Controls.Add(this.label_DES_FH_NAME);
            this.Controls.Add(this.label_DES_GENDER);
            this.Controls.Add(this.label_DES_PASSPORT);
            this.Controls.Add(this.label_DES_NAME);
            this.MaximumSize = new System.Drawing.Size(360, 360);
            this.MinimumSize = new System.Drawing.Size(360, 360);
            this.Name = "ChangeDesignerForm";
            this.Text = "Змiнити Iнформацiю про дизайнера";
            this.Load += new System.EventHandler(this.ChangeDesignerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fashionHousesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_DES_NAME;
        private System.Windows.Forms.Label label_DES_PASSPORT;
        private System.Windows.Forms.Label label_DES_GENDER;
        private System.Windows.Forms.Label label_DES_FH_NAME;
        private System.Windows.Forms.Label label_DES_BIRTHDAY;
        private System.Windows.Forms.TextBox textBox_DES_NAME;
        private System.Windows.Forms.TextBox textBox_DES_PASSPORT;
        private System.Windows.Forms.TextBox textBox_DES_GENDER;
        private System.Windows.Forms.TextBox textBox_DES_BIRTHDAY;
        private System.Windows.Forms.ComboBox comboBox_DES_FH_NAME;
        private System.Windows.Forms.Button btn_DES_CHANGE;
        private System.Windows.Forms.BindingSource fashionHousesBindingSource;
    }
}