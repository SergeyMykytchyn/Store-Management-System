using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.Entity;

namespace FashionHousesProject
{
    public partial class ShowDivisionsForm : Form
    {
        private ClassLibraryFashionHousesEF.FashionHousesEntities ctx;
        private int FH_ID;

        public ShowDivisionsForm(ClassLibraryFashionHousesEF.FashionHousesEntities ctx, int FH_ID)
        {
            InitializeComponent();
            this.ctx = ctx;
            this.FH_ID = FH_ID;
        }

        private void dataGridViewDIV_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            return;
        }

        private void UpdateDataGridViewDiv()
        {
            dataGridViewDIV.DataSource = (from c in ctx.Divisions where c.DIV_FH == FH_ID select c).ToList();
        }

        private void ShowDivisionsForm_Load(object sender, EventArgs e)
        {
            divisionsBindingSource.DataSource = ctx.Divisions.Local.ToBindingList();
            fashionHousesBindingSource.DataSource = ctx.FashionHouses.Local.ToBindingList();

            UpdateDataGridViewDiv();
        }

        private void btn_ADD_DIV_Click(object sender, EventArgs e)
        {
            AddDivisionForm add_div = new AddDivisionForm(ctx, FH_ID);
            add_div.ShowDialog();

            UpdateDataGridViewDiv();
        }

        private void btn_DEL_DIV_Click(object sender, EventArgs e)
        {
            try
            {
                int DIV_ID = Convert.ToInt32(dataGridViewDIV.CurrentRow.Cells["dIVIDDataGridViewTextBoxColumn"].Value);

                var DivToRemove = ctx.Divisions.SingleOrDefault(x => x.DIV_ID == DIV_ID);

                ctx.Divisions.Remove(DivToRemove);
                ctx.SaveChanges();

                UpdateDataGridViewDiv();
            }
            catch
            {

            }
        }

        private void btn_CHANGE_DIV_Click(object sender, EventArgs e)
        {
            try
            {
                int DIV_ID = Convert.ToInt32(dataGridViewDIV.CurrentRow.Cells["dIVIDDataGridViewTextBoxColumn"].Value);

                ChangeDivision cgdiv = new ChangeDivision(ctx, DIV_ID);
                cgdiv.ShowDialog();

                UpdateDataGridViewDiv();
            }
            catch
            {

            }
        }
    }
}
