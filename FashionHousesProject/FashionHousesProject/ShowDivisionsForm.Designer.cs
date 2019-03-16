namespace FashionHousesProject
{
    partial class ShowDivisionsForm
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
            this.dataGridViewDIV = new System.Windows.Forms.DataGridView();
            this.dIVIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIVFHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.fashionHousesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dIVNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIVADRESSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIVQTYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fashionHousesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.divisionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_ADD_DIV = new System.Windows.Forms.Button();
            this.btn_DEL_DIV = new System.Windows.Forms.Button();
            this.btn_CHANGE_DIV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDIV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fashionHousesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.divisionsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDIV
            // 
            this.dataGridViewDIV.AutoGenerateColumns = false;
            this.dataGridViewDIV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDIV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dIVIDDataGridViewTextBoxColumn,
            this.dIVFHDataGridViewTextBoxColumn,
            this.dIVNAMEDataGridViewTextBoxColumn,
            this.dIVADRESSDataGridViewTextBoxColumn,
            this.dIVQTYDataGridViewTextBoxColumn,
            this.fashionHousesDataGridViewTextBoxColumn});
            this.dataGridViewDIV.DataSource = this.divisionsBindingSource;
            this.dataGridViewDIV.Location = new System.Drawing.Point(12, 121);
            this.dataGridViewDIV.Name = "dataGridViewDIV";
            this.dataGridViewDIV.ReadOnly = true;
            this.dataGridViewDIV.RowTemplate.Height = 24;
            this.dataGridViewDIV.Size = new System.Drawing.Size(603, 270);
            this.dataGridViewDIV.TabIndex = 0;
            this.dataGridViewDIV.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridViewDIV_DataError);
            // 
            // dIVIDDataGridViewTextBoxColumn
            // 
            this.dIVIDDataGridViewTextBoxColumn.DataPropertyName = "DIV_ID";
            this.dIVIDDataGridViewTextBoxColumn.HeaderText = "DIV_ID";
            this.dIVIDDataGridViewTextBoxColumn.Name = "dIVIDDataGridViewTextBoxColumn";
            this.dIVIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.dIVIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // dIVFHDataGridViewTextBoxColumn
            // 
            this.dIVFHDataGridViewTextBoxColumn.DataPropertyName = "DIV_FH";
            this.dIVFHDataGridViewTextBoxColumn.DataSource = this.fashionHousesBindingSource;
            this.dIVFHDataGridViewTextBoxColumn.DisplayMember = "FH_NAME";
            this.dIVFHDataGridViewTextBoxColumn.HeaderText = "Дом Моди";
            this.dIVFHDataGridViewTextBoxColumn.Name = "dIVFHDataGridViewTextBoxColumn";
            this.dIVFHDataGridViewTextBoxColumn.ReadOnly = true;
            this.dIVFHDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dIVFHDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dIVFHDataGridViewTextBoxColumn.ValueMember = "FH_ID";
            // 
            // fashionHousesBindingSource
            // 
            this.fashionHousesBindingSource.DataSource = typeof(ClassLibraryFashionHousesEF.FashionHouses);
            // 
            // dIVNAMEDataGridViewTextBoxColumn
            // 
            this.dIVNAMEDataGridViewTextBoxColumn.DataPropertyName = "DIV_NAME";
            this.dIVNAMEDataGridViewTextBoxColumn.HeaderText = "Назва";
            this.dIVNAMEDataGridViewTextBoxColumn.Name = "dIVNAMEDataGridViewTextBoxColumn";
            this.dIVNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dIVADRESSDataGridViewTextBoxColumn
            // 
            this.dIVADRESSDataGridViewTextBoxColumn.DataPropertyName = "DIV_ADRESS";
            this.dIVADRESSDataGridViewTextBoxColumn.HeaderText = "Адреса";
            this.dIVADRESSDataGridViewTextBoxColumn.Name = "dIVADRESSDataGridViewTextBoxColumn";
            this.dIVADRESSDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dIVQTYDataGridViewTextBoxColumn
            // 
            this.dIVQTYDataGridViewTextBoxColumn.DataPropertyName = "DIV_QTY";
            this.dIVQTYDataGridViewTextBoxColumn.HeaderText = "Кiлькiсть Працiвникiв";
            this.dIVQTYDataGridViewTextBoxColumn.Name = "dIVQTYDataGridViewTextBoxColumn";
            this.dIVQTYDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fashionHousesDataGridViewTextBoxColumn
            // 
            this.fashionHousesDataGridViewTextBoxColumn.DataPropertyName = "FashionHouses";
            this.fashionHousesDataGridViewTextBoxColumn.HeaderText = "FashionHouses";
            this.fashionHousesDataGridViewTextBoxColumn.Name = "fashionHousesDataGridViewTextBoxColumn";
            this.fashionHousesDataGridViewTextBoxColumn.ReadOnly = true;
            this.fashionHousesDataGridViewTextBoxColumn.Visible = false;
            // 
            // divisionsBindingSource
            // 
            this.divisionsBindingSource.DataSource = typeof(ClassLibraryFashionHousesEF.Divisions);
            // 
            // btn_ADD_DIV
            // 
            this.btn_ADD_DIV.Location = new System.Drawing.Point(12, 29);
            this.btn_ADD_DIV.Name = "btn_ADD_DIV";
            this.btn_ADD_DIV.Size = new System.Drawing.Size(150, 70);
            this.btn_ADD_DIV.TabIndex = 1;
            this.btn_ADD_DIV.Text = "Додати Пiдроздiл";
            this.btn_ADD_DIV.UseVisualStyleBackColor = true;
            this.btn_ADD_DIV.Click += new System.EventHandler(this.btn_ADD_DIV_Click);
            // 
            // btn_DEL_DIV
            // 
            this.btn_DEL_DIV.Location = new System.Drawing.Point(236, 29);
            this.btn_DEL_DIV.Name = "btn_DEL_DIV";
            this.btn_DEL_DIV.Size = new System.Drawing.Size(150, 70);
            this.btn_DEL_DIV.TabIndex = 2;
            this.btn_DEL_DIV.Text = "Видалити Пiдроздiл";
            this.btn_DEL_DIV.UseVisualStyleBackColor = true;
            this.btn_DEL_DIV.Click += new System.EventHandler(this.btn_DEL_DIV_Click);
            // 
            // btn_CHANGE_DIV
            // 
            this.btn_CHANGE_DIV.Location = new System.Drawing.Point(451, 29);
            this.btn_CHANGE_DIV.Name = "btn_CHANGE_DIV";
            this.btn_CHANGE_DIV.Size = new System.Drawing.Size(150, 70);
            this.btn_CHANGE_DIV.TabIndex = 3;
            this.btn_CHANGE_DIV.Text = "Змiнити Iнформацiю про пiдроздiл";
            this.btn_CHANGE_DIV.UseVisualStyleBackColor = true;
            this.btn_CHANGE_DIV.Click += new System.EventHandler(this.btn_CHANGE_DIV_Click);
            // 
            // ShowDivisionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 393);
            this.Controls.Add(this.btn_CHANGE_DIV);
            this.Controls.Add(this.btn_DEL_DIV);
            this.Controls.Add(this.btn_ADD_DIV);
            this.Controls.Add(this.dataGridViewDIV);
            this.MaximumSize = new System.Drawing.Size(640, 440);
            this.MinimumSize = new System.Drawing.Size(640, 440);
            this.Name = "ShowDivisionsForm";
            this.Text = "Пiдроздiли Дому Моди";
            this.Load += new System.EventHandler(this.ShowDivisionsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDIV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fashionHousesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.divisionsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDIV;
        private System.Windows.Forms.BindingSource divisionsBindingSource;
        private System.Windows.Forms.Button btn_ADD_DIV;
        private System.Windows.Forms.Button btn_DEL_DIV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIVIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn dIVFHDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource fashionHousesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIVNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIVADRESSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIVQTYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fashionHousesDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_CHANGE_DIV;
    }
}