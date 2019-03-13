namespace FashionHousesProject
{
    partial class AddClothToShopForm
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
            this.dataGridView_SH_CL = new System.Windows.Forms.DataGridView();
            this.fashionHousesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shopClothesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label_CLSH_QTY = new System.Windows.Forms.Label();
            this.label_CLSH_COST = new System.Windows.Forms.Label();
            this.textBox_CLSH_QTY = new System.Windows.Forms.TextBox();
            this.textBox_CLSH_COST = new System.Windows.Forms.TextBox();
            this.btn_add_CL_to_SH = new System.Windows.Forms.Button();
            this.sHIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sHADRESSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sHQTYEMPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sHFHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.clothesInShopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fashionHousesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SH_CL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fashionHousesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopClothesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_SH_CL
            // 
            this.dataGridView_SH_CL.AutoGenerateColumns = false;
            this.dataGridView_SH_CL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_SH_CL.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sHIDDataGridViewTextBoxColumn,
            this.sHADRESSDataGridViewTextBoxColumn,
            this.sHQTYEMPDataGridViewTextBoxColumn,
            this.sHFHDataGridViewTextBoxColumn,
            this.clothesInShopDataGridViewTextBoxColumn,
            this.fashionHousesDataGridViewTextBoxColumn});
            this.dataGridView_SH_CL.DataSource = this.shopClothesBindingSource;
            this.dataGridView_SH_CL.Location = new System.Drawing.Point(13, 100);
            this.dataGridView_SH_CL.Name = "dataGridView_SH_CL";
            this.dataGridView_SH_CL.ReadOnly = true;
            this.dataGridView_SH_CL.RowTemplate.Height = 24;
            this.dataGridView_SH_CL.Size = new System.Drawing.Size(445, 150);
            this.dataGridView_SH_CL.TabIndex = 0;
            this.dataGridView_SH_CL.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView_SH_CL_DataError);
            // 
            // fashionHousesBindingSource
            // 
            this.fashionHousesBindingSource.DataSource = typeof(ClassLibraryFashionHousesEF.FashionHouses);
            // 
            // shopClothesBindingSource
            // 
            this.shopClothesBindingSource.DataSource = typeof(ClassLibraryFashionHousesEF.ShopClothes);
            // 
            // label_CLSH_QTY
            // 
            this.label_CLSH_QTY.AutoSize = true;
            this.label_CLSH_QTY.Location = new System.Drawing.Point(527, 100);
            this.label_CLSH_QTY.Name = "label_CLSH_QTY";
            this.label_CLSH_QTY.Size = new System.Drawing.Size(106, 17);
            this.label_CLSH_QTY.TabIndex = 1;
            this.label_CLSH_QTY.Text = "Кiлькiсть одягу";
            // 
            // label_CLSH_COST
            // 
            this.label_CLSH_COST.AutoSize = true;
            this.label_CLSH_COST.Location = new System.Drawing.Point(530, 143);
            this.label_CLSH_COST.Name = "label_CLSH_COST";
            this.label_CLSH_COST.Size = new System.Drawing.Size(64, 17);
            this.label_CLSH_COST.TabIndex = 2;
            this.label_CLSH_COST.Text = "Вартiсть";
            // 
            // textBox_CLSH_QTY
            // 
            this.textBox_CLSH_QTY.Location = new System.Drawing.Point(654, 100);
            this.textBox_CLSH_QTY.Name = "textBox_CLSH_QTY";
            this.textBox_CLSH_QTY.Size = new System.Drawing.Size(123, 22);
            this.textBox_CLSH_QTY.TabIndex = 3;
            // 
            // textBox_CLSH_COST
            // 
            this.textBox_CLSH_COST.Location = new System.Drawing.Point(654, 143);
            this.textBox_CLSH_COST.Name = "textBox_CLSH_COST";
            this.textBox_CLSH_COST.Size = new System.Drawing.Size(123, 22);
            this.textBox_CLSH_COST.TabIndex = 4;
            // 
            // btn_add_CL_to_SH
            // 
            this.btn_add_CL_to_SH.Location = new System.Drawing.Point(543, 208);
            this.btn_add_CL_to_SH.Name = "btn_add_CL_to_SH";
            this.btn_add_CL_to_SH.Size = new System.Drawing.Size(140, 42);
            this.btn_add_CL_to_SH.TabIndex = 5;
            this.btn_add_CL_to_SH.Text = "Додати Одяг до магазину";
            this.btn_add_CL_to_SH.UseVisualStyleBackColor = true;
            this.btn_add_CL_to_SH.Click += new System.EventHandler(this.btn_add_CL_to_SH_Click);
            // 
            // sHIDDataGridViewTextBoxColumn
            // 
            this.sHIDDataGridViewTextBoxColumn.DataPropertyName = "SH_ID";
            this.sHIDDataGridViewTextBoxColumn.HeaderText = "SH_ID";
            this.sHIDDataGridViewTextBoxColumn.Name = "sHIDDataGridViewTextBoxColumn";
            this.sHIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // sHADRESSDataGridViewTextBoxColumn
            // 
            this.sHADRESSDataGridViewTextBoxColumn.DataPropertyName = "SH_ADRESS";
            this.sHADRESSDataGridViewTextBoxColumn.HeaderText = "Адреса Магазину";
            this.sHADRESSDataGridViewTextBoxColumn.Name = "sHADRESSDataGridViewTextBoxColumn";
            // 
            // sHQTYEMPDataGridViewTextBoxColumn
            // 
            this.sHQTYEMPDataGridViewTextBoxColumn.DataPropertyName = "SH_QTY_EMP";
            this.sHQTYEMPDataGridViewTextBoxColumn.HeaderText = "Кiлькiсть працiвникiв";
            this.sHQTYEMPDataGridViewTextBoxColumn.Name = "sHQTYEMPDataGridViewTextBoxColumn";
            // 
            // sHFHDataGridViewTextBoxColumn
            // 
            this.sHFHDataGridViewTextBoxColumn.DataPropertyName = "SH_FH";
            this.sHFHDataGridViewTextBoxColumn.DataSource = this.fashionHousesBindingSource;
            this.sHFHDataGridViewTextBoxColumn.DisplayMember = "FH_NAME";
            this.sHFHDataGridViewTextBoxColumn.HeaderText = "Дом Моди";
            this.sHFHDataGridViewTextBoxColumn.Name = "sHFHDataGridViewTextBoxColumn";
            this.sHFHDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.sHFHDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.sHFHDataGridViewTextBoxColumn.ValueMember = "FH_ID";
            // 
            // clothesInShopDataGridViewTextBoxColumn
            // 
            this.clothesInShopDataGridViewTextBoxColumn.DataPropertyName = "ClothesInShop";
            this.clothesInShopDataGridViewTextBoxColumn.HeaderText = "ClothesInShop";
            this.clothesInShopDataGridViewTextBoxColumn.Name = "clothesInShopDataGridViewTextBoxColumn";
            this.clothesInShopDataGridViewTextBoxColumn.Visible = false;
            // 
            // fashionHousesDataGridViewTextBoxColumn
            // 
            this.fashionHousesDataGridViewTextBoxColumn.DataPropertyName = "FashionHouses";
            this.fashionHousesDataGridViewTextBoxColumn.HeaderText = "FashionHouses";
            this.fashionHousesDataGridViewTextBoxColumn.Name = "fashionHousesDataGridViewTextBoxColumn";
            this.fashionHousesDataGridViewTextBoxColumn.Visible = false;
            // 
            // AddClothToShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_add_CL_to_SH);
            this.Controls.Add(this.textBox_CLSH_COST);
            this.Controls.Add(this.textBox_CLSH_QTY);
            this.Controls.Add(this.label_CLSH_COST);
            this.Controls.Add(this.label_CLSH_QTY);
            this.Controls.Add(this.dataGridView_SH_CL);
            this.Name = "AddClothToShopForm";
            this.Text = "Додати Одяг до магазину";
            this.Load += new System.EventHandler(this.AddClothToShop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SH_CL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fashionHousesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopClothesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_SH_CL;
        private System.Windows.Forms.BindingSource fashionHousesBindingSource;
        private System.Windows.Forms.BindingSource shopClothesBindingSource;
        private System.Windows.Forms.Label label_CLSH_QTY;
        private System.Windows.Forms.Label label_CLSH_COST;
        private System.Windows.Forms.TextBox textBox_CLSH_QTY;
        private System.Windows.Forms.TextBox textBox_CLSH_COST;
        private System.Windows.Forms.Button btn_add_CL_to_SH;
        private System.Windows.Forms.DataGridViewTextBoxColumn sHIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sHADRESSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sHQTYEMPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn sHFHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clothesInShopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fashionHousesDataGridViewTextBoxColumn;
    }
}