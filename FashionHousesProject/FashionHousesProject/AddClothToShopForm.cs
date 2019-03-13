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
    public partial class AddClothToShopForm : Form
    {
        private ClassLibraryFashionHousesEF.FashionHousesEntities ctx;
        private int CL_ID;

        public AddClothToShopForm(int CL_ID)
        {
            InitializeComponent();
            this.CL_ID = CL_ID;
        }

        private int get_FH_ID_by_CL_ID(int CL_ID)
        {
            return (from c in ctx.Clothes where c.CL_ID == CL_ID select c.CL_FH).First();
        }

        private void AddClothToShop_Load(object sender, EventArgs e)
        {
            ctx = new ClassLibraryFashionHousesEF.FashionHousesEntities();

            ctx.Clothes.Load();
            ctx.ClothesInShop.Load();
            ctx.Designers.Load();
            ctx.Divisions.Load();
            ctx.FashionHouses.Load();
            ctx.Presidents.Load();
            ctx.ShopClothes.Load();

            shopClothesBindingSource.DataSource = ctx.ShopClothes.Local.ToBindingList();
            fashionHousesBindingSource.DataSource = ctx.FashionHouses.Local.ToBindingList();

            int SH_FH = get_FH_ID_by_CL_ID(CL_ID);

            dataGridView_SH_CL.DataSource = (from c in ctx.ShopClothes where c.SH_FH == SH_FH select c).ToList();
        }

        private void dataGridView_SH_CL_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            return;
        }

        private bool DATA_IS_CORRECT()
        {
            int CLSH_QTY = 0;

            if (!Int32.TryParse(textBox_CLSH_QTY.Text, out CLSH_QTY))
                return false;

            if (CLSH_QTY <= 0)
                return false;

            double CLSH_COST = 0;

            if (!Double.TryParse(textBox_CLSH_COST.Text, out CLSH_COST))
                return false;

            if (CLSH_COST <= 0)
                return false;

            return true;
        }

        private bool CheckForDuplicates(int CLSH_CL, int CLSH_SH)
        {
            return (from c in ctx.ClothesInShop where c.CLSH_CL == CLSH_CL && c.CLSH_SH == CLSH_SH select c.CLSH_ID).Any();
        }

        private void btn_add_CL_to_SH_Click(object sender, EventArgs e)
        {
            if(!DATA_IS_CORRECT())
            {
                MessageBox.Show("Одяг не додався до магазину, помилка вхiдних даних", "Повiдомлення");
                return;
            }

            int CLSH_SH;

            try
            {
                var row = dataGridView_SH_CL.CurrentCell.OwningRow;
                CLSH_SH = Convert.ToInt32(row.Cells["sHIDDataGridViewTextBoxColumn"].Value);
            }
            catch
            {
                MessageBox.Show("Одяг не додався до магазину, бо магазину не iснує", "Повiдомлення");
                return;
            }

            if(CheckForDuplicates(CL_ID, CLSH_SH))
            {
                MessageBox.Show("Такий одяг вже додано до цього магазину, тому вiн не додався", "Повiдомлення");
                return;
            }

            int CLSH_QTY = Int32.Parse(textBox_CLSH_QTY.Text);
            double CLSH_COST = Double.Parse(textBox_CLSH_COST.Text);

            ClassLibraryFashionHousesEF.ClothesInShop clsh = new ClassLibraryFashionHousesEF.ClothesInShop();

            clsh.CLSH_CL = CL_ID;
            clsh.CLSH_SH = CLSH_SH;
            clsh.CLSH_QTY = CLSH_QTY;
            clsh.CLSH_COST = (float)CLSH_COST;

            ctx.ClothesInShop.Add(clsh);
            ctx.SaveChanges();

            MessageBox.Show("Одяг додався до магазину", "Повiдомлення");
        }

    }
}
