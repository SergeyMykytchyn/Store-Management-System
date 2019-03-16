using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FashionHousesProject
{
    public partial class ShowFashionHouseShops : Form
    {
        private ClassLibraryFashionHousesEF.FashionHousesEntities ctx;
        private int FH_ID;
        public ShowFashionHouseShops(ClassLibraryFashionHousesEF.FashionHousesEntities ctx, int FH_ID)
        {
            InitializeComponent();
            this.ctx = ctx;
            this.FH_ID = FH_ID;
        }

        private void UpdateGataGridViewSH()
        {
            dataGridViewSH.DataSource = (from c in ctx.ShopClothes where c.SH_FH == FH_ID select c).ToList();
        }

        private void btn_ADD_SH_Click(object sender, EventArgs e)
        {
            AddShopForm addsh = new AddShopForm(ctx, FH_ID);
            addsh.ShowDialog();

            UpdateGataGridViewSH();
        }

        private void ShowFashionHouseShops_Load(object sender, EventArgs e)
        {
            UpdateGataGridViewSH();
        }

        private void btn_DEL_SH_Click(object sender, EventArgs e)
        {
            try
            {
                int SH_ID = Convert.ToInt32(dataGridViewSH.CurrentRow.Cells["sHIDDataGridViewTextBoxColumn"].Value);

                var CLSH_to_remove = (from c in ctx.ClothesInShop where c.CLSH_SH == SH_ID select c).ToList();
                var SH_to_remove = (from c in ctx.ShopClothes where c.SH_ID == SH_ID select c).First();

                foreach (var CLSH in CLSH_to_remove)
                    ctx.ClothesInShop.Remove(CLSH);

                ctx.ShopClothes.Remove(SH_to_remove);

                ctx.SaveChanges();

                UpdateGataGridViewSH();
            }
            catch
            {

            }
        }

        private void btn_CHANGE_SH_Click(object sender, EventArgs e)
        {
            try
            {
                int SH_ID = Convert.ToInt32(dataGridViewSH.CurrentRow.Cells["sHIDDataGridViewTextBoxColumn"].Value);

                ChangeShopForm cgsh = new ChangeShopForm(ctx, SH_ID);
                cgsh.ShowDialog();

                UpdateGataGridViewSH();
            }
            catch
            {

            }
        }
    }
}
