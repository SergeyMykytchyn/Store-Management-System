namespace FashionHousesProject
{
    partial class ChangeCloth
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
            this.label_FH_TO_CHANGE = new System.Windows.Forms.Label();
            this.label_DES_TO_CHANGE = new System.Windows.Forms.Label();
            this.label_DESCRIPTION_TO_CHANGE = new System.Windows.Forms.Label();
            this.label_COLOR_TO_CHANGE = new System.Windows.Forms.Label();
            this.label_CAT_TO_CHANGE = new System.Windows.Forms.Label();
            this.comboBox_FH_TO_CHANGE = new System.Windows.Forms.ComboBox();
            this.comboBox_DES_TO_CHANGE = new System.Windows.Forms.ComboBox();
            this.textBox_DESCRIPTION_TO_CHANGE = new System.Windows.Forms.TextBox();
            this.textBox_COLOR_TO_CHANGE = new System.Windows.Forms.TextBox();
            this.textBox_CAT_TO_CHANGE = new System.Windows.Forms.TextBox();
            this.fashionHousesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.designersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_CL_CHANGE = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fashionHousesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.designersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label_FH_TO_CHANGE
            // 
            this.label_FH_TO_CHANGE.AutoSize = true;
            this.label_FH_TO_CHANGE.Location = new System.Drawing.Point(31, 36);
            this.label_FH_TO_CHANGE.Name = "label_FH_TO_CHANGE";
            this.label_FH_TO_CHANGE.Size = new System.Drawing.Size(75, 17);
            this.label_FH_TO_CHANGE.TabIndex = 0;
            this.label_FH_TO_CHANGE.Text = "Дом Моди";
            // 
            // label_DES_TO_CHANGE
            // 
            this.label_DES_TO_CHANGE.AutoSize = true;
            this.label_DES_TO_CHANGE.Location = new System.Drawing.Point(34, 101);
            this.label_DES_TO_CHANGE.Name = "label_DES_TO_CHANGE";
            this.label_DES_TO_CHANGE.Size = new System.Drawing.Size(74, 17);
            this.label_DES_TO_CHANGE.TabIndex = 1;
            this.label_DES_TO_CHANGE.Text = "Дизайнер";
            // 
            // label_DESCRIPTION_TO_CHANGE
            // 
            this.label_DESCRIPTION_TO_CHANGE.AutoSize = true;
            this.label_DESCRIPTION_TO_CHANGE.Location = new System.Drawing.Point(34, 155);
            this.label_DESCRIPTION_TO_CHANGE.Name = "label_DESCRIPTION_TO_CHANGE";
            this.label_DESCRIPTION_TO_CHANGE.Size = new System.Drawing.Size(42, 17);
            this.label_DESCRIPTION_TO_CHANGE.TabIndex = 2;
            this.label_DESCRIPTION_TO_CHANGE.Text = "Опис";
            // 
            // label_COLOR_TO_CHANGE
            // 
            this.label_COLOR_TO_CHANGE.AutoSize = true;
            this.label_COLOR_TO_CHANGE.Location = new System.Drawing.Point(34, 203);
            this.label_COLOR_TO_CHANGE.Name = "label_COLOR_TO_CHANGE";
            this.label_COLOR_TO_CHANGE.Size = new System.Drawing.Size(44, 17);
            this.label_COLOR_TO_CHANGE.TabIndex = 3;
            this.label_COLOR_TO_CHANGE.Text = "Колiр";
            // 
            // label_CAT_TO_CHANGE
            // 
            this.label_CAT_TO_CHANGE.AutoSize = true;
            this.label_CAT_TO_CHANGE.Location = new System.Drawing.Point(34, 244);
            this.label_CAT_TO_CHANGE.Name = "label_CAT_TO_CHANGE";
            this.label_CAT_TO_CHANGE.Size = new System.Drawing.Size(72, 17);
            this.label_CAT_TO_CHANGE.TabIndex = 4;
            this.label_CAT_TO_CHANGE.Text = "Категорiя";
            // 
            // comboBox_FH_TO_CHANGE
            // 
            this.comboBox_FH_TO_CHANGE.DataSource = this.fashionHousesBindingSource;
            this.comboBox_FH_TO_CHANGE.DisplayMember = "FH_NAME";
            this.comboBox_FH_TO_CHANGE.FormattingEnabled = true;
            this.comboBox_FH_TO_CHANGE.Location = new System.Drawing.Point(198, 36);
            this.comboBox_FH_TO_CHANGE.Name = "comboBox_FH_TO_CHANGE";
            this.comboBox_FH_TO_CHANGE.Size = new System.Drawing.Size(121, 24);
            this.comboBox_FH_TO_CHANGE.TabIndex = 5;
            this.comboBox_FH_TO_CHANGE.ValueMember = "FH_ID";
            // 
            // comboBox_DES_TO_CHANGE
            // 
            this.comboBox_DES_TO_CHANGE.DataSource = this.designersBindingSource;
            this.comboBox_DES_TO_CHANGE.DisplayMember = "DES_FULLNAME";
            this.comboBox_DES_TO_CHANGE.FormattingEnabled = true;
            this.comboBox_DES_TO_CHANGE.Location = new System.Drawing.Point(198, 101);
            this.comboBox_DES_TO_CHANGE.Name = "comboBox_DES_TO_CHANGE";
            this.comboBox_DES_TO_CHANGE.Size = new System.Drawing.Size(121, 24);
            this.comboBox_DES_TO_CHANGE.TabIndex = 6;
            this.comboBox_DES_TO_CHANGE.ValueMember = "DES_ID";
            // 
            // textBox_DESCRIPTION_TO_CHANGE
            // 
            this.textBox_DESCRIPTION_TO_CHANGE.Location = new System.Drawing.Point(198, 149);
            this.textBox_DESCRIPTION_TO_CHANGE.Name = "textBox_DESCRIPTION_TO_CHANGE";
            this.textBox_DESCRIPTION_TO_CHANGE.Size = new System.Drawing.Size(121, 22);
            this.textBox_DESCRIPTION_TO_CHANGE.TabIndex = 7;
            // 
            // textBox_COLOR_TO_CHANGE
            // 
            this.textBox_COLOR_TO_CHANGE.Location = new System.Drawing.Point(198, 203);
            this.textBox_COLOR_TO_CHANGE.Name = "textBox_COLOR_TO_CHANGE";
            this.textBox_COLOR_TO_CHANGE.Size = new System.Drawing.Size(121, 22);
            this.textBox_COLOR_TO_CHANGE.TabIndex = 8;
            // 
            // textBox_CAT_TO_CHANGE
            // 
            this.textBox_CAT_TO_CHANGE.Location = new System.Drawing.Point(198, 244);
            this.textBox_CAT_TO_CHANGE.Name = "textBox_CAT_TO_CHANGE";
            this.textBox_CAT_TO_CHANGE.Size = new System.Drawing.Size(121, 22);
            this.textBox_CAT_TO_CHANGE.TabIndex = 9;
            // 
            // fashionHousesBindingSource
            // 
            this.fashionHousesBindingSource.DataSource = typeof(ClassLibraryFashionHousesEF.FashionHouses);
            // 
            // designersBindingSource
            // 
            this.designersBindingSource.DataSource = typeof(ClassLibraryFashionHousesEF.Designers);
            // 
            // btn_CL_CHANGE
            // 
            this.btn_CL_CHANGE.Location = new System.Drawing.Point(107, 297);
            this.btn_CL_CHANGE.Name = "btn_CL_CHANGE";
            this.btn_CL_CHANGE.Size = new System.Drawing.Size(100, 44);
            this.btn_CL_CHANGE.TabIndex = 10;
            this.btn_CL_CHANGE.Text = "Змiнити";
            this.btn_CL_CHANGE.UseVisualStyleBackColor = true;
            this.btn_CL_CHANGE.Click += new System.EventHandler(this.btn_CL_CHANGE_Click);
            // 
            // ChangeCloth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_CL_CHANGE);
            this.Controls.Add(this.textBox_CAT_TO_CHANGE);
            this.Controls.Add(this.textBox_COLOR_TO_CHANGE);
            this.Controls.Add(this.textBox_DESCRIPTION_TO_CHANGE);
            this.Controls.Add(this.comboBox_DES_TO_CHANGE);
            this.Controls.Add(this.comboBox_FH_TO_CHANGE);
            this.Controls.Add(this.label_CAT_TO_CHANGE);
            this.Controls.Add(this.label_COLOR_TO_CHANGE);
            this.Controls.Add(this.label_DESCRIPTION_TO_CHANGE);
            this.Controls.Add(this.label_DES_TO_CHANGE);
            this.Controls.Add(this.label_FH_TO_CHANGE);
            this.Name = "ChangeCloth";
            this.Text = "ChangeCloth";
            this.Load += new System.EventHandler(this.ChangeCloth_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fashionHousesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.designersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_FH_TO_CHANGE;
        private System.Windows.Forms.Label label_DES_TO_CHANGE;
        private System.Windows.Forms.Label label_DESCRIPTION_TO_CHANGE;
        private System.Windows.Forms.Label label_COLOR_TO_CHANGE;
        private System.Windows.Forms.Label label_CAT_TO_CHANGE;
        private System.Windows.Forms.ComboBox comboBox_FH_TO_CHANGE;
        private System.Windows.Forms.ComboBox comboBox_DES_TO_CHANGE;
        private System.Windows.Forms.TextBox textBox_DESCRIPTION_TO_CHANGE;
        private System.Windows.Forms.TextBox textBox_COLOR_TO_CHANGE;
        private System.Windows.Forms.TextBox textBox_CAT_TO_CHANGE;
        private System.Windows.Forms.BindingSource fashionHousesBindingSource;
        private System.Windows.Forms.BindingSource designersBindingSource;
        private System.Windows.Forms.Button btn_CL_CHANGE;
    }
}