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
            this.components = new System.ComponentModel.Container();
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
            this.fashionHousesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.designersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clothesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPageFH = new System.Windows.Forms.TabPage();
            this.comboBoxPR_FH = new System.Windows.Forms.ComboBox();
            this.textBoxAdressFH = new System.Windows.Forms.TextBox();
            this.textBoxFH_FH = new System.Windows.Forms.TextBox();
            this.btnPR_FH = new System.Windows.Forms.Button();
            this.btnADRESS_FH = new System.Windows.Forms.Button();
            this.btnFH_FH = new System.Windows.Forms.Button();
            this.btnDelFH = new System.Windows.Forms.Button();
            this.btnAddFH = new System.Windows.Forms.Button();
            this.dataGridViewFH = new System.Windows.Forms.DataGridView();
            this.fashionHousesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.presidentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FH_President = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.fHNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fHADRESSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fHIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clothesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.designersDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.divisionsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.presidentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shopClothesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLFHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cLDESDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cLDESCRIPTIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLCATEGORYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLCOLORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.designersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fashionHousesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clothesInShopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.tabControlMain.SuspendLayout();
            this.tabPageCL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fashionHousesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.designersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clothesBindingSource)).BeginInit();
            this.tabPageFH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fashionHousesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.presidentsBindingSource)).BeginInit();
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
            this.tabControlMain.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControlMain_Selected);
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
            this.dataGridViewCL.AutoGenerateColumns = false;
            this.dataGridViewCL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCL.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cLIDDataGridViewTextBoxColumn,
            this.cLFHDataGridViewTextBoxColumn,
            this.cLDESDataGridViewTextBoxColumn,
            this.cLDESCRIPTIONDataGridViewTextBoxColumn,
            this.cLCATEGORYDataGridViewTextBoxColumn,
            this.cLCOLORDataGridViewTextBoxColumn,
            this.designersDataGridViewTextBoxColumn,
            this.fashionHousesDataGridViewTextBoxColumn,
            this.clothesInShopDataGridViewTextBoxColumn});
            this.dataGridViewCL.DataSource = this.clothesBindingSource;
            this.dataGridViewCL.Location = new System.Drawing.Point(6, 116);
            this.dataGridViewCL.Name = "dataGridViewCL";
            this.dataGridViewCL.RowTemplate.Height = 24;
            this.dataGridViewCL.Size = new System.Drawing.Size(1054, 401);
            this.dataGridViewCL.TabIndex = 0;
            this.dataGridViewCL.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridViewCL_DataError);
            // 
            // fashionHousesBindingSource
            // 
            this.fashionHousesBindingSource.DataSource = typeof(ClassLibraryFashionHousesEF.FashionHouses);
            // 
            // designersBindingSource
            // 
            this.designersBindingSource.DataSource = typeof(ClassLibraryFashionHousesEF.Designers);
            // 
            // clothesBindingSource
            // 
            this.clothesBindingSource.DataSource = typeof(ClassLibraryFashionHousesEF.Clothes);
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
            // comboBoxPR_FH
            // 
            this.comboBoxPR_FH.FormattingEnabled = true;
            this.comboBoxPR_FH.Location = new System.Drawing.Point(702, 35);
            this.comboBoxPR_FH.Name = "comboBoxPR_FH";
            this.comboBoxPR_FH.Size = new System.Drawing.Size(155, 24);
            this.comboBoxPR_FH.TabIndex = 8;
            // 
            // textBoxAdressFH
            // 
            this.textBoxAdressFH.Location = new System.Drawing.Point(425, 34);
            this.textBoxAdressFH.Name = "textBoxAdressFH";
            this.textBoxAdressFH.Size = new System.Drawing.Size(155, 22);
            this.textBoxAdressFH.TabIndex = 7;
            // 
            // textBoxFH_FH
            // 
            this.textBoxFH_FH.Location = new System.Drawing.Point(179, 35);
            this.textBoxFH_FH.Name = "textBoxFH_FH";
            this.textBoxFH_FH.Size = new System.Drawing.Size(155, 22);
            this.textBoxFH_FH.TabIndex = 6;
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
            // btnADRESS_FH
            // 
            this.btnADRESS_FH.Location = new System.Drawing.Point(425, 76);
            this.btnADRESS_FH.Name = "btnADRESS_FH";
            this.btnADRESS_FH.Size = new System.Drawing.Size(155, 30);
            this.btnADRESS_FH.TabIndex = 4;
            this.btnADRESS_FH.Text = "Адреса";
            this.btnADRESS_FH.UseVisualStyleBackColor = true;
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
            // btnDelFH
            // 
            this.btnDelFH.Location = new System.Drawing.Point(940, 6);
            this.btnDelFH.Name = "btnDelFH";
            this.btnDelFH.Size = new System.Drawing.Size(120, 105);
            this.btnDelFH.TabIndex = 2;
            this.btnDelFH.Text = "Видалити Дом Моди";
            this.btnDelFH.UseVisualStyleBackColor = true;
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
            // dataGridViewFH
            // 
            this.dataGridViewFH.AutoGenerateColumns = false;
            this.dataGridViewFH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FH_President,
            this.fHNAMEDataGridViewTextBoxColumn,
            this.fHADRESSDataGridViewTextBoxColumn,
            this.fHIDDataGridViewTextBoxColumn,
            this.clothesDataGridViewTextBoxColumn,
            this.designersDataGridViewTextBoxColumn1,
            this.divisionsDataGridViewTextBoxColumn,
            this.presidentsDataGridViewTextBoxColumn,
            this.shopClothesDataGridViewTextBoxColumn});
            this.dataGridViewFH.DataSource = this.fashionHousesBindingSource1;
            this.dataGridViewFH.Location = new System.Drawing.Point(6, 116);
            this.dataGridViewFH.Name = "dataGridViewFH";
            this.dataGridViewFH.RowTemplate.Height = 24;
            this.dataGridViewFH.Size = new System.Drawing.Size(1054, 401);
            this.dataGridViewFH.TabIndex = 0;
            // 
            // fashionHousesBindingSource1
            // 
            this.fashionHousesBindingSource1.DataSource = typeof(ClassLibraryFashionHousesEF.FashionHouses);
            // 
            // presidentsBindingSource
            // 
            this.presidentsBindingSource.DataSource = typeof(ClassLibraryFashionHousesEF.Presidents);
            // 
            // FH_President
            // 
            this.FH_President.DataPropertyName = "FH_ID";
            this.FH_President.DataSource = this.presidentsBindingSource;
            this.FH_President.DisplayMember = "PR_FULLNAME";
            this.FH_President.HeaderText = "Президент";
            this.FH_President.Name = "FH_President";
            this.FH_President.ValueMember = "PR_FH";
            // 
            // fHNAMEDataGridViewTextBoxColumn
            // 
            this.fHNAMEDataGridViewTextBoxColumn.DataPropertyName = "FH_NAME";
            this.fHNAMEDataGridViewTextBoxColumn.HeaderText = "Дом Моди";
            this.fHNAMEDataGridViewTextBoxColumn.Name = "fHNAMEDataGridViewTextBoxColumn";
            // 
            // fHADRESSDataGridViewTextBoxColumn
            // 
            this.fHADRESSDataGridViewTextBoxColumn.DataPropertyName = "FH_ADRESS";
            this.fHADRESSDataGridViewTextBoxColumn.HeaderText = "Адреса";
            this.fHADRESSDataGridViewTextBoxColumn.Name = "fHADRESSDataGridViewTextBoxColumn";
            // 
            // fHIDDataGridViewTextBoxColumn
            // 
            this.fHIDDataGridViewTextBoxColumn.DataPropertyName = "FH_ID";
            this.fHIDDataGridViewTextBoxColumn.HeaderText = "FH_ID";
            this.fHIDDataGridViewTextBoxColumn.Name = "fHIDDataGridViewTextBoxColumn";
            this.fHIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // clothesDataGridViewTextBoxColumn
            // 
            this.clothesDataGridViewTextBoxColumn.DataPropertyName = "Clothes";
            this.clothesDataGridViewTextBoxColumn.HeaderText = "Clothes";
            this.clothesDataGridViewTextBoxColumn.Name = "clothesDataGridViewTextBoxColumn";
            this.clothesDataGridViewTextBoxColumn.Visible = false;
            // 
            // designersDataGridViewTextBoxColumn1
            // 
            this.designersDataGridViewTextBoxColumn1.DataPropertyName = "Designers";
            this.designersDataGridViewTextBoxColumn1.HeaderText = "Designers";
            this.designersDataGridViewTextBoxColumn1.Name = "designersDataGridViewTextBoxColumn1";
            this.designersDataGridViewTextBoxColumn1.Visible = false;
            // 
            // divisionsDataGridViewTextBoxColumn
            // 
            this.divisionsDataGridViewTextBoxColumn.DataPropertyName = "Divisions";
            this.divisionsDataGridViewTextBoxColumn.HeaderText = "Divisions";
            this.divisionsDataGridViewTextBoxColumn.Name = "divisionsDataGridViewTextBoxColumn";
            this.divisionsDataGridViewTextBoxColumn.Visible = false;
            // 
            // presidentsDataGridViewTextBoxColumn
            // 
            this.presidentsDataGridViewTextBoxColumn.DataPropertyName = "Presidents";
            this.presidentsDataGridViewTextBoxColumn.HeaderText = "Presidents";
            this.presidentsDataGridViewTextBoxColumn.Name = "presidentsDataGridViewTextBoxColumn";
            this.presidentsDataGridViewTextBoxColumn.Visible = false;
            // 
            // shopClothesDataGridViewTextBoxColumn
            // 
            this.shopClothesDataGridViewTextBoxColumn.DataPropertyName = "ShopClothes";
            this.shopClothesDataGridViewTextBoxColumn.HeaderText = "ShopClothes";
            this.shopClothesDataGridViewTextBoxColumn.Name = "shopClothesDataGridViewTextBoxColumn";
            this.shopClothesDataGridViewTextBoxColumn.Visible = false;
            // 
            // cLIDDataGridViewTextBoxColumn
            // 
            this.cLIDDataGridViewTextBoxColumn.DataPropertyName = "CL_ID";
            this.cLIDDataGridViewTextBoxColumn.HeaderText = "CL_ID";
            this.cLIDDataGridViewTextBoxColumn.Name = "cLIDDataGridViewTextBoxColumn";
            this.cLIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // cLFHDataGridViewTextBoxColumn
            // 
            this.cLFHDataGridViewTextBoxColumn.DataPropertyName = "CL_FH";
            this.cLFHDataGridViewTextBoxColumn.DataSource = this.fashionHousesBindingSource;
            this.cLFHDataGridViewTextBoxColumn.DisplayMember = "FH_NAME";
            this.cLFHDataGridViewTextBoxColumn.HeaderText = "Дом Моди";
            this.cLFHDataGridViewTextBoxColumn.Name = "cLFHDataGridViewTextBoxColumn";
            this.cLFHDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cLFHDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cLFHDataGridViewTextBoxColumn.ValueMember = "FH_ID";
            // 
            // cLDESDataGridViewTextBoxColumn
            // 
            this.cLDESDataGridViewTextBoxColumn.DataPropertyName = "CL_DES";
            this.cLDESDataGridViewTextBoxColumn.DataSource = this.designersBindingSource;
            this.cLDESDataGridViewTextBoxColumn.DisplayMember = "DES_FULLNAME";
            this.cLDESDataGridViewTextBoxColumn.HeaderText = "Дизайнер";
            this.cLDESDataGridViewTextBoxColumn.Name = "cLDESDataGridViewTextBoxColumn";
            this.cLDESDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cLDESDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cLDESDataGridViewTextBoxColumn.ValueMember = "DES_ID";
            // 
            // cLDESCRIPTIONDataGridViewTextBoxColumn
            // 
            this.cLDESCRIPTIONDataGridViewTextBoxColumn.DataPropertyName = "CL_DESCRIPTION";
            this.cLDESCRIPTIONDataGridViewTextBoxColumn.HeaderText = "Опис";
            this.cLDESCRIPTIONDataGridViewTextBoxColumn.Name = "cLDESCRIPTIONDataGridViewTextBoxColumn";
            // 
            // cLCATEGORYDataGridViewTextBoxColumn
            // 
            this.cLCATEGORYDataGridViewTextBoxColumn.DataPropertyName = "CL_CATEGORY";
            this.cLCATEGORYDataGridViewTextBoxColumn.HeaderText = "Категорiя";
            this.cLCATEGORYDataGridViewTextBoxColumn.Name = "cLCATEGORYDataGridViewTextBoxColumn";
            // 
            // cLCOLORDataGridViewTextBoxColumn
            // 
            this.cLCOLORDataGridViewTextBoxColumn.DataPropertyName = "CL_COLOR";
            this.cLCOLORDataGridViewTextBoxColumn.HeaderText = "Колiр";
            this.cLCOLORDataGridViewTextBoxColumn.Name = "cLCOLORDataGridViewTextBoxColumn";
            // 
            // designersDataGridViewTextBoxColumn
            // 
            this.designersDataGridViewTextBoxColumn.DataPropertyName = "Designers";
            this.designersDataGridViewTextBoxColumn.HeaderText = "Designers";
            this.designersDataGridViewTextBoxColumn.Name = "designersDataGridViewTextBoxColumn";
            this.designersDataGridViewTextBoxColumn.Visible = false;
            // 
            // fashionHousesDataGridViewTextBoxColumn
            // 
            this.fashionHousesDataGridViewTextBoxColumn.DataPropertyName = "FashionHouses";
            this.fashionHousesDataGridViewTextBoxColumn.HeaderText = "FashionHouses";
            this.fashionHousesDataGridViewTextBoxColumn.Name = "fashionHousesDataGridViewTextBoxColumn";
            this.fashionHousesDataGridViewTextBoxColumn.Visible = false;
            // 
            // clothesInShopDataGridViewTextBoxColumn
            // 
            this.clothesInShopDataGridViewTextBoxColumn.DataPropertyName = "ClothesInShop";
            this.clothesInShopDataGridViewTextBoxColumn.HeaderText = "ClothesInShop";
            this.clothesInShopDataGridViewTextBoxColumn.Name = "clothesInShopDataGridViewTextBoxColumn";
            this.clothesInShopDataGridViewTextBoxColumn.Visible = false;
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
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.tabControlMain.ResumeLayout(false);
            this.tabPageCL.ResumeLayout(false);
            this.tabPageCL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fashionHousesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.designersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clothesBindingSource)).EndInit();
            this.tabPageFH.ResumeLayout(false);
            this.tabPageFH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fashionHousesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.presidentsBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource clothesBindingSource;
        private System.Windows.Forms.BindingSource fashionHousesBindingSource;
        private System.Windows.Forms.BindingSource designersBindingSource;
        private System.Windows.Forms.BindingSource presidentsBindingSource;
        private System.Windows.Forms.BindingSource fashionHousesBindingSource1;
        private System.Windows.Forms.DataGridViewComboBoxColumn FH_President;
        private System.Windows.Forms.DataGridViewTextBoxColumn fHNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fHADRESSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fHIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clothesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn designersDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn divisionsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn presidentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shopClothesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn cLFHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn cLDESDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLDESCRIPTIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLCATEGORYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLCOLORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn designersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fashionHousesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clothesInShopDataGridViewTextBoxColumn;
    }
}

