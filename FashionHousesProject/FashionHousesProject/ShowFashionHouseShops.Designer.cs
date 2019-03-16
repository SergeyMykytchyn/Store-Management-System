namespace FashionHousesProject
{
    partial class ShowFashionHouseShops
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
            this.dataGridViewSH = new System.Windows.Forms.DataGridView();
            this.btn_ADD_SH = new System.Windows.Forms.Button();
            this.btn_DEL_SH = new System.Windows.Forms.Button();
            this.btn_CHANGE_SH = new System.Windows.Forms.Button();
            this.sHIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sHADRESSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sHQTYEMPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sHFHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clothesInShopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fashionHousesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shopClothesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopClothesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSH
            // 
            this.dataGridViewSH.AutoGenerateColumns = false;
            this.dataGridViewSH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sHIDDataGridViewTextBoxColumn,
            this.sHADRESSDataGridViewTextBoxColumn,
            this.sHQTYEMPDataGridViewTextBoxColumn,
            this.sHFHDataGridViewTextBoxColumn,
            this.clothesInShopDataGridViewTextBoxColumn,
            this.fashionHousesDataGridViewTextBoxColumn});
            this.dataGridViewSH.DataSource = this.shopClothesBindingSource;
            this.dataGridViewSH.Location = new System.Drawing.Point(21, 141);
            this.dataGridViewSH.Name = "dataGridViewSH";
            this.dataGridViewSH.RowTemplate.Height = 24;
            this.dataGridViewSH.Size = new System.Drawing.Size(329, 150);
            this.dataGridViewSH.TabIndex = 0;
            // 
            // btn_ADD_SH
            // 
            this.btn_ADD_SH.Location = new System.Drawing.Point(21, 42);
            this.btn_ADD_SH.Name = "btn_ADD_SH";
            this.btn_ADD_SH.Size = new System.Drawing.Size(103, 68);
            this.btn_ADD_SH.TabIndex = 1;
            this.btn_ADD_SH.Text = "Додати магазин";
            this.btn_ADD_SH.UseVisualStyleBackColor = true;
            this.btn_ADD_SH.Click += new System.EventHandler(this.btn_ADD_SH_Click);
            // 
            // btn_DEL_SH
            // 
            this.btn_DEL_SH.Location = new System.Drawing.Point(140, 44);
            this.btn_DEL_SH.Name = "btn_DEL_SH";
            this.btn_DEL_SH.Size = new System.Drawing.Size(97, 66);
            this.btn_DEL_SH.TabIndex = 2;
            this.btn_DEL_SH.Text = "Видалити Магазин";
            this.btn_DEL_SH.UseVisualStyleBackColor = true;
            this.btn_DEL_SH.Click += new System.EventHandler(this.btn_DEL_SH_Click);
            // 
            // btn_CHANGE_SH
            // 
            this.btn_CHANGE_SH.Location = new System.Drawing.Point(243, 42);
            this.btn_CHANGE_SH.Name = "btn_CHANGE_SH";
            this.btn_CHANGE_SH.Size = new System.Drawing.Size(107, 68);
            this.btn_CHANGE_SH.TabIndex = 3;
            this.btn_CHANGE_SH.Text = "Змiнити Iнформацiю про магазин";
            this.btn_CHANGE_SH.UseVisualStyleBackColor = true;
            this.btn_CHANGE_SH.Click += new System.EventHandler(this.btn_CHANGE_SH_Click);
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
            this.sHADRESSDataGridViewTextBoxColumn.HeaderText = "Адреса";
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
            this.sHFHDataGridViewTextBoxColumn.HeaderText = "SH_FH";
            this.sHFHDataGridViewTextBoxColumn.Name = "sHFHDataGridViewTextBoxColumn";
            this.sHFHDataGridViewTextBoxColumn.Visible = false;
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
            // shopClothesBindingSource
            // 
            this.shopClothesBindingSource.DataSource = typeof(ClassLibraryFashionHousesEF.ShopClothes);
            // 
            // ShowFashionHouseShops
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 303);
            this.Controls.Add(this.btn_CHANGE_SH);
            this.Controls.Add(this.btn_DEL_SH);
            this.Controls.Add(this.btn_ADD_SH);
            this.Controls.Add(this.dataGridViewSH);
            this.MaximumSize = new System.Drawing.Size(380, 350);
            this.MinimumSize = new System.Drawing.Size(380, 350);
            this.Name = "ShowFashionHouseShops";
            this.Text = "Магазини Дому Моди";
            this.Load += new System.EventHandler(this.ShowFashionHouseShops_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopClothesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSH;
        private System.Windows.Forms.Button btn_ADD_SH;
        private System.Windows.Forms.Button btn_DEL_SH;
        private System.Windows.Forms.DataGridViewTextBoxColumn sHIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sHADRESSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sHQTYEMPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sHFHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clothesInShopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fashionHousesDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource shopClothesBindingSource;
        private System.Windows.Forms.Button btn_CHANGE_SH;
    }
}