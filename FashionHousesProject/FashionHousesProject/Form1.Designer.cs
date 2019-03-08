namespace FashionHousesProject
{
    partial class MainForm
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageCL = new System.Windows.Forms.TabPage();
            this.btnDelCL = new System.Windows.Forms.Button();
            this.btnAddCL = new System.Windows.Forms.Button();
            this.btnCOLOR_CL = new System.Windows.Forms.Button();
            this.btnCAT_CL = new System.Windows.Forms.Button();
            this.btnDES_CL = new System.Windows.Forms.Button();
            this.btnFH_CL = new System.Windows.Forms.Button();
            this.textBoxCOLOR_CL = new System.Windows.Forms.TextBox();
            this.textBoxCAT_CL = new System.Windows.Forms.TextBox();
            this.textBoxDES_CL = new System.Windows.Forms.TextBox();
            this.textBoxFH_CL = new System.Windows.Forms.TextBox();
            this.dataGridViewCL = new System.Windows.Forms.DataGridView();
            this.tabPageFH = new System.Windows.Forms.TabPage();
            this.dataGridViewFH = new System.Windows.Forms.DataGridView();
            this.btnAddFH = new System.Windows.Forms.Button();
            this.btnDelFH = new System.Windows.Forms.Button();
            this.btnFH_FH = new System.Windows.Forms.Button();
            this.btnADRESS_FH = new System.Windows.Forms.Button();
            this.btnPR_FH = new System.Windows.Forms.Button();
            this.textBoxFH_FH = new System.Windows.Forms.TextBox();
            this.textBoxAdressFH = new System.Windows.Forms.TextBox();
            this.comboBoxPR_FH = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.tabControlMain.SuspendLayout();
            this.tabPageCL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCL)).BeginInit();
            this.tabPageFH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFH)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(0, 1);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(1080, 182);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageCL);
            this.tabControlMain.Controls.Add(this.tabPageFH);
            this.tabControlMain.Location = new System.Drawing.Point(5, 189);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1075, 553);
            this.tabControlMain.TabIndex = 1;
            // 
            // tabPageCL
            // 
            this.tabPageCL.Controls.Add(this.btnDelCL);
            this.tabPageCL.Controls.Add(this.btnAddCL);
            this.tabPageCL.Controls.Add(this.btnCOLOR_CL);
            this.tabPageCL.Controls.Add(this.btnCAT_CL);
            this.tabPageCL.Controls.Add(this.btnDES_CL);
            this.tabPageCL.Controls.Add(this.btnFH_CL);
            this.tabPageCL.Controls.Add(this.textBoxCOLOR_CL);
            this.tabPageCL.Controls.Add(this.textBoxCAT_CL);
            this.tabPageCL.Controls.Add(this.textBoxDES_CL);
            this.tabPageCL.Controls.Add(this.textBoxFH_CL);
            this.tabPageCL.Controls.Add(this.dataGridViewCL);
            this.tabPageCL.Location = new System.Drawing.Point(4, 25);
            this.tabPageCL.Name = "tabPageCL";
            this.tabPageCL.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCL.Size = new System.Drawing.Size(1067, 524);
            this.tabPageCL.TabIndex = 0;
            this.tabPageCL.Text = "Одяг";
            this.tabPageCL.UseVisualStyleBackColor = true;
            // 
            // btnDelCL
            // 
            this.btnDelCL.Location = new System.Drawing.Point(940, 6);
            this.btnDelCL.Name = "btnDelCL";
            this.btnDelCL.Size = new System.Drawing.Size(120, 105);
            this.btnDelCL.TabIndex = 10;
            this.btnDelCL.Text = "Видалити Одяг";
            this.btnDelCL.UseVisualStyleBackColor = true;
            // 
            // btnAddCL
            // 
            this.btnAddCL.Location = new System.Drawing.Point(6, 6);
            this.btnAddCL.Name = "btnAddCL";
            this.btnAddCL.Size = new System.Drawing.Size(120, 105);
            this.btnAddCL.TabIndex = 9;
            this.btnAddCL.Text = "Додати Одяг";
            this.btnAddCL.UseVisualStyleBackColor = true;
            // 
            // btnCOLOR_CL
            // 
            this.btnCOLOR_CL.Location = new System.Drawing.Point(766, 67);
            this.btnCOLOR_CL.Name = "btnCOLOR_CL";
            this.btnCOLOR_CL.Size = new System.Drawing.Size(155, 30);
            this.btnCOLOR_CL.TabIndex = 8;
            this.btnCOLOR_CL.Text = "Колір";
            this.btnCOLOR_CL.UseVisualStyleBackColor = true;
            // 
            // btnCAT_CL
            // 
            this.btnCAT_CL.Location = new System.Drawing.Point(561, 67);
            this.btnCAT_CL.Name = "btnCAT_CL";
            this.btnCAT_CL.Size = new System.Drawing.Size(155, 30);
            this.btnCAT_CL.TabIndex = 7;
            this.btnCAT_CL.Text = "Категорія";
            this.btnCAT_CL.UseVisualStyleBackColor = true;
            // 
            // btnDES_CL
            // 
            this.btnDES_CL.Location = new System.Drawing.Point(353, 67);
            this.btnDES_CL.Name = "btnDES_CL";
            this.btnDES_CL.Size = new System.Drawing.Size(155, 30);
            this.btnDES_CL.TabIndex = 6;
            this.btnDES_CL.Text = "Дизайнер";
            this.btnDES_CL.UseVisualStyleBackColor = true;
            // 
            // btnFH_CL
            // 
            this.btnFH_CL.Location = new System.Drawing.Point(150, 67);
            this.btnFH_CL.Name = "btnFH_CL";
            this.btnFH_CL.Size = new System.Drawing.Size(155, 30);
            this.btnFH_CL.TabIndex = 5;
            this.btnFH_CL.Text = "Дом Моди";
            this.btnFH_CL.UseVisualStyleBackColor = true;
            // 
            // textBoxCOLOR_CL
            // 
            this.textBoxCOLOR_CL.Location = new System.Drawing.Point(766, 23);
            this.textBoxCOLOR_CL.Name = "textBoxCOLOR_CL";
            this.textBoxCOLOR_CL.Size = new System.Drawing.Size(155, 22);
            this.textBoxCOLOR_CL.TabIndex = 4;
            // 
            // textBoxCAT_CL
            // 
            this.textBoxCAT_CL.Location = new System.Drawing.Point(561, 23);
            this.textBoxCAT_CL.Name = "textBoxCAT_CL";
            this.textBoxCAT_CL.Size = new System.Drawing.Size(155, 22);
            this.textBoxCAT_CL.TabIndex = 3;
            // 
            // textBoxDES_CL
            // 
            this.textBoxDES_CL.Location = new System.Drawing.Point(353, 23);
            this.textBoxDES_CL.Name = "textBoxDES_CL";
            this.textBoxDES_CL.Size = new System.Drawing.Size(155, 22);
            this.textBoxDES_CL.TabIndex = 2;
            // 
            // textBoxFH_CL
            // 
            this.textBoxFH_CL.Location = new System.Drawing.Point(150, 23);
            this.textBoxFH_CL.Name = "textBoxFH_CL";
            this.textBoxFH_CL.Size = new System.Drawing.Size(155, 22);
            this.textBoxFH_CL.TabIndex = 1;
            // 
            // dataGridViewCL
            // 
            this.dataGridViewCL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCL.Location = new System.Drawing.Point(6, 116);
            this.dataGridViewCL.Name = "dataGridViewCL";
            this.dataGridViewCL.RowTemplate.Height = 24;
            this.dataGridViewCL.Size = new System.Drawing.Size(1054, 401);
            this.dataGridViewCL.TabIndex = 0;
            // 
            // tabPageFH
            // 
            this.tabPageFH.Controls.Add(this.comboBoxPR_FH);
            this.tabPageFH.Controls.Add(this.textBoxAdressFH);
            this.tabPageFH.Controls.Add(this.textBoxFH_FH);
            this.tabPageFH.Controls.Add(this.btnPR_FH);
            this.tabPageFH.Controls.Add(this.btnADRESS_FH);
            this.tabPageFH.Controls.Add(this.btnFH_FH);
            this.tabPageFH.Controls.Add(this.btnDelFH);
            this.tabPageFH.Controls.Add(this.btnAddFH);
            this.tabPageFH.Controls.Add(this.dataGridViewFH);
            this.tabPageFH.Location = new System.Drawing.Point(4, 25);
            this.tabPageFH.Name = "tabPageFH";
            this.tabPageFH.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFH.Size = new System.Drawing.Size(1067, 524);
            this.tabPageFH.TabIndex = 1;
            this.tabPageFH.Text = "Дома Моди";
            this.tabPageFH.UseVisualStyleBackColor = true;
            // 
            // dataGridViewFH
            // 
            this.dataGridViewFH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFH.Location = new System.Drawing.Point(6, 116);
            this.dataGridViewFH.Name = "dataGridViewFH";
            this.dataGridViewFH.RowTemplate.Height = 24;
            this.dataGridViewFH.Size = new System.Drawing.Size(1054, 401);
            this.dataGridViewFH.TabIndex = 0;
            // 
            // btnAddFH
            // 
            this.btnAddFH.Location = new System.Drawing.Point(6, 6);
            this.btnAddFH.Name = "btnAddFH";
            this.btnAddFH.Size = new System.Drawing.Size(120, 105);
            this.btnAddFH.TabIndex = 1;
            this.btnAddFH.Text = "Додати Дом Моди";
            this.btnAddFH.UseVisualStyleBackColor = true;
            // 
            // btnDelFH
            // 
            this.btnDelFH.Location = new System.Drawing.Point(940, 6);
            this.btnDelFH.Name = "btnDelFH";
            this.btnDelFH.Size = new System.Drawing.Size(120, 105);
            this.btnDelFH.TabIndex = 2;
            this.btnDelFH.Text = "Видалити Дом Моди";
            this.btnDelFH.UseVisualStyleBackColor = true;
            // 
            // btnFH_FH
            // 
            this.btnFH_FH.Location = new System.Drawing.Point(179, 76);
            this.btnFH_FH.Name = "btnFH_FH";
            this.btnFH_FH.Size = new System.Drawing.Size(155, 30);
            this.btnFH_FH.TabIndex = 3;
            this.btnFH_FH.Text = "Дом Моди";
            this.btnFH_FH.UseVisualStyleBackColor = true;
            // 
            // btnADRESS_FH
            // 
            this.btnADRESS_FH.Location = new System.Drawing.Point(425, 76);
            this.btnADRESS_FH.Name = "btnADRESS_FH";
            this.btnADRESS_FH.Size = new System.Drawing.Size(155, 30);
            this.btnADRESS_FH.TabIndex = 4;
            this.btnADRESS_FH.Text = "Адреса";
            this.btnADRESS_FH.UseVisualStyleBackColor = true;
            // 
            // btnPR_FH
            // 
            this.btnPR_FH.Location = new System.Drawing.Point(702, 76);
            this.btnPR_FH.Name = "btnPR_FH";
            this.btnPR_FH.Size = new System.Drawing.Size(155, 30);
            this.btnPR_FH.TabIndex = 5;
            this.btnPR_FH.Text = "Президент";
            this.btnPR_FH.UseVisualStyleBackColor = true;
            // 
            // textBoxFH_FH
            // 
            this.textBoxFH_FH.Location = new System.Drawing.Point(179, 35);
            this.textBoxFH_FH.Name = "textBoxFH_FH";
            this.textBoxFH_FH.Size = new System.Drawing.Size(155, 22);
            this.textBoxFH_FH.TabIndex = 6;
            // 
            // textBoxAdressFH
            // 
            this.textBoxAdressFH.Location = new System.Drawing.Point(425, 34);
            this.textBoxAdressFH.Name = "textBoxAdressFH";
            this.textBoxAdressFH.Size = new System.Drawing.Size(155, 22);
            this.textBoxAdressFH.TabIndex = 7;
            // 
            // comboBoxPR_FH
            // 
            this.comboBoxPR_FH.FormattingEnabled = true;
            this.comboBoxPR_FH.Location = new System.Drawing.Point(702, 35);
            this.comboBoxPR_FH.Name = "comboBoxPR_FH";
            this.comboBoxPR_FH.Size = new System.Drawing.Size(155, 24);
            this.comboBoxPR_FH.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 743);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.pictureBox);
            this.Name = "MainForm";
            this.Text = "Магазин Одягу";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.tabControlMain.ResumeLayout(false);
            this.tabPageCL.ResumeLayout(false);
            this.tabPageCL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCL)).EndInit();
            this.tabPageFH.ResumeLayout(false);
            this.tabPageFH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageCL;
        private System.Windows.Forms.DataGridView dataGridViewCL;
        private System.Windows.Forms.TabPage tabPageFH;
        private System.Windows.Forms.DataGridView dataGridViewFH;
        private System.Windows.Forms.TextBox textBoxCOLOR_CL;
        private System.Windows.Forms.TextBox textBoxCAT_CL;
        private System.Windows.Forms.TextBox textBoxDES_CL;
        private System.Windows.Forms.TextBox textBoxFH_CL;
        private System.Windows.Forms.Button btnCOLOR_CL;
        private System.Windows.Forms.Button btnCAT_CL;
        private System.Windows.Forms.Button btnDES_CL;
        private System.Windows.Forms.Button btnFH_CL;
        private System.Windows.Forms.Button btnAddCL;
        private System.Windows.Forms.Button btnDelCL;
        private System.Windows.Forms.Button btnPR_FH;
        private System.Windows.Forms.Button btnADRESS_FH;
        private System.Windows.Forms.Button btnFH_FH;
        private System.Windows.Forms.Button btnDelFH;
        private System.Windows.Forms.Button btnAddFH;
        private System.Windows.Forms.ComboBox comboBoxPR_FH;
        private System.Windows.Forms.TextBox textBoxAdressFH;
        private System.Windows.Forms.TextBox textBoxFH_FH;
    }
}

