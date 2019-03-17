namespace FashionHousesProject
{
    partial class AddDesignerForm
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
            this.label_FH_NAME = new System.Windows.Forms.Label();
            this.label_DES_BIRTHDAY = new System.Windows.Forms.Label();
            this.textBox_DES_NAME = new System.Windows.Forms.TextBox();
            this.textBox_DES_PASSPORT = new System.Windows.Forms.TextBox();
            this.textBox_DES_GENDER = new System.Windows.Forms.TextBox();
            this.textBox_DES_BIRTHDAY = new System.Windows.Forms.TextBox();
            this.comboBox_DES_FH_NAME = new System.Windows.Forms.ComboBox();
            this.btn_ADD_DES = new System.Windows.Forms.Button();
            this.fashionHousesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fashionHousesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label_DES_NAME
            // 
            this.label_DES_NAME.AutoSize = true;
            this.label_DES_NAME.Location = new System.Drawing.Point(13, 28);
            this.label_DES_NAME.Name = "label_DES_NAME";
            this.label_DES_NAME.Size = new System.Drawing.Size(105, 17);
            this.label_DES_NAME.TabIndex = 0;
            this.label_DES_NAME.Text = "ПIБ дизайнера";
            // 
            // label_DES_PASSPORT
            // 
            this.label_DES_PASSPORT.AutoSize = true;
            this.label_DES_PASSPORT.Location = new System.Drawing.Point(13, 75);
            this.label_DES_PASSPORT.Name = "label_DES_PASSPORT";
            this.label_DES_PASSPORT.Size = new System.Drawing.Size(139, 17);
            this.label_DES_PASSPORT.TabIndex = 1;
            this.label_DES_PASSPORT.Text = "Паспорт дизайнера";
            // 
            // label_DES_GENDER
            // 
            this.label_DES_GENDER.AutoSize = true;
            this.label_DES_GENDER.Location = new System.Drawing.Point(16, 122);
            this.label_DES_GENDER.Name = "label_DES_GENDER";
            this.label_DES_GENDER.Size = new System.Drawing.Size(109, 17);
            this.label_DES_GENDER.TabIndex = 2;
            this.label_DES_GENDER.Text = "Пол дизайнера";
            // 
            // label_FH_NAME
            // 
            this.label_FH_NAME.AutoSize = true;
            this.label_FH_NAME.Location = new System.Drawing.Point(16, 165);
            this.label_FH_NAME.Name = "label_FH_NAME";
            this.label_FH_NAME.Size = new System.Drawing.Size(75, 17);
            this.label_FH_NAME.TabIndex = 3;
            this.label_FH_NAME.Text = "Дом Моди";
            // 
            // label_DES_BIRTHDAY
            // 
            this.label_DES_BIRTHDAY.AutoSize = true;
            this.label_DES_BIRTHDAY.Location = new System.Drawing.Point(19, 219);
            this.label_DES_BIRTHDAY.Name = "label_DES_BIRTHDAY";
            this.label_DES_BIRTHDAY.Size = new System.Drawing.Size(129, 17);
            this.label_DES_BIRTHDAY.TabIndex = 4;
            this.label_DES_BIRTHDAY.Text = "День Народження";
            // 
            // textBox_DES_NAME
            // 
            this.textBox_DES_NAME.Location = new System.Drawing.Point(223, 28);
            this.textBox_DES_NAME.Name = "textBox_DES_NAME";
            this.textBox_DES_NAME.Size = new System.Drawing.Size(131, 22);
            this.textBox_DES_NAME.TabIndex = 5;
            // 
            // textBox_DES_PASSPORT
            // 
            this.textBox_DES_PASSPORT.Location = new System.Drawing.Point(223, 69);
            this.textBox_DES_PASSPORT.Name = "textBox_DES_PASSPORT";
            this.textBox_DES_PASSPORT.Size = new System.Drawing.Size(131, 22);
            this.textBox_DES_PASSPORT.TabIndex = 6;
            // 
            // textBox_DES_GENDER
            // 
            this.textBox_DES_GENDER.Location = new System.Drawing.Point(223, 116);
            this.textBox_DES_GENDER.Name = "textBox_DES_GENDER";
            this.textBox_DES_GENDER.Size = new System.Drawing.Size(131, 22);
            this.textBox_DES_GENDER.TabIndex = 7;
            // 
            // textBox_DES_BIRTHDAY
            // 
            this.textBox_DES_BIRTHDAY.Location = new System.Drawing.Point(223, 213);
            this.textBox_DES_BIRTHDAY.Name = "textBox_DES_BIRTHDAY";
            this.textBox_DES_BIRTHDAY.Size = new System.Drawing.Size(131, 22);
            this.textBox_DES_BIRTHDAY.TabIndex = 8;
            // 
            // comboBox_DES_FH_NAME
            // 
            this.comboBox_DES_FH_NAME.DataSource = this.fashionHousesBindingSource;
            this.comboBox_DES_FH_NAME.DisplayMember = "FH_NAME";
            this.comboBox_DES_FH_NAME.FormattingEnabled = true;
            this.comboBox_DES_FH_NAME.Location = new System.Drawing.Point(223, 165);
            this.comboBox_DES_FH_NAME.Name = "comboBox_DES_FH_NAME";
            this.comboBox_DES_FH_NAME.Size = new System.Drawing.Size(131, 24);
            this.comboBox_DES_FH_NAME.TabIndex = 9;
            this.comboBox_DES_FH_NAME.ValueMember = "FH_ID";
            // 
            // btn_ADD_DES
            // 
            this.btn_ADD_DES.Location = new System.Drawing.Point(116, 266);
            this.btn_ADD_DES.Name = "btn_ADD_DES";
            this.btn_ADD_DES.Size = new System.Drawing.Size(126, 52);
            this.btn_ADD_DES.TabIndex = 10;
            this.btn_ADD_DES.Text = "Додати Дизайнера";
            this.btn_ADD_DES.UseVisualStyleBackColor = true;
            this.btn_ADD_DES.Click += new System.EventHandler(this.btn_ADD_DES_Click);
            // 
            // fashionHousesBindingSource
            // 
            this.fashionHousesBindingSource.DataSource = typeof(ClassLibraryFashionHousesEF.FashionHouses);
            // 
            // AddDesignerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 323);
            this.Controls.Add(this.btn_ADD_DES);
            this.Controls.Add(this.comboBox_DES_FH_NAME);
            this.Controls.Add(this.textBox_DES_BIRTHDAY);
            this.Controls.Add(this.textBox_DES_GENDER);
            this.Controls.Add(this.textBox_DES_PASSPORT);
            this.Controls.Add(this.textBox_DES_NAME);
            this.Controls.Add(this.label_DES_BIRTHDAY);
            this.Controls.Add(this.label_FH_NAME);
            this.Controls.Add(this.label_DES_GENDER);
            this.Controls.Add(this.label_DES_PASSPORT);
            this.Controls.Add(this.label_DES_NAME);
            this.MaximumSize = new System.Drawing.Size(400, 370);
            this.MinimumSize = new System.Drawing.Size(400, 370);
            this.Name = "AddDesignerForm";
            this.Text = "Додати Дизайнера";
            this.Load += new System.EventHandler(this.AddDesignerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fashionHousesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_DES_NAME;
        private System.Windows.Forms.Label label_DES_PASSPORT;
        private System.Windows.Forms.Label label_DES_GENDER;
        private System.Windows.Forms.Label label_FH_NAME;
        private System.Windows.Forms.Label label_DES_BIRTHDAY;
        private System.Windows.Forms.TextBox textBox_DES_NAME;
        private System.Windows.Forms.TextBox textBox_DES_PASSPORT;
        private System.Windows.Forms.TextBox textBox_DES_GENDER;
        private System.Windows.Forms.TextBox textBox_DES_BIRTHDAY;
        private System.Windows.Forms.ComboBox comboBox_DES_FH_NAME;
        private System.Windows.Forms.Button btn_ADD_DES;
        private System.Windows.Forms.BindingSource fashionHousesBindingSource;
    }
}