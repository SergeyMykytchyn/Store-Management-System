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
    public partial class ShowMeClothInShops : Form
    {
        private ClassLibraryFashionHousesEF.FashionHousesEntities ctx;
        private int CLSH_CL;

        public ShowMeClothInShops(int CLSH_CL)
        {
            InitializeComponent();
            this.CLSH_CL = CLSH_CL;
        }

        private void ShowClothesInShops()
        {
            var table = from c in ctx.ClothesInShop where c.CLSH_CL == CLSH_CL select c;
            var Newtable = from c in ctx.ShopClothes
                           join t in table on c.SH_ID equals t.CLSH_SH
                           select new
                           {
                               SH_FH = c.SH_FH,
                               SH_ID = c.SH_ID,
                               SH_ADRESS = c.SH_ADRESS,
                               SH_QTY_EMP = c.SH_QTY_EMP,
                               CLSH_QTY = t.CLSH_QTY,
                               CLSH_COST = t.CLSH_COST,
                               CLSH_ID = t.CLSH_ID
                           };
            var FinalTable = from c in ctx.FashionHouses
                             join t in Newtable on c.FH_ID equals t.SH_FH
                             select new
                             {
                                 SH_FH = c.FH_NAME,
                                 SH_ADRESS = t.SH_ADRESS,
                                 SH_QTY_EMP = t.SH_QTY_EMP,
                                 CLSH_QTY = t.CLSH_QTY,
                                 CLSH_COST = t.CLSH_COST,
                                 CLSH_ID = t.CLSH_ID,
                                 SH_ID = t.SH_ID
                             };

            dataGridView_CLSH.DataSource = FinalTable.ToList();
            dataGridView_CLSH.Columns["SH_FH"].HeaderText = "Дом Моди";
            dataGridView_CLSH.Columns["SH_ADRESS"].HeaderText = "Адрес Магазину";
            dataGridView_CLSH.Columns["SH_QTY_EMP"].HeaderText = "Кiлькiсть Працiвникiв";
            dataGridView_CLSH.Columns["CLSH_QTY"].HeaderText = "Кiлькiсть Одягу у магазинi";
            dataGridView_CLSH.Columns["CLSH_COST"].HeaderText = "Вартiсть одягу у магазинi";
            dataGridView_CLSH.Columns["SH_ID"].Visible = false;
            dataGridView_CLSH.Columns["CLSH_ID"].Visible = false;
        }

        private void ShowMeClothInShops_Load(object sender, EventArgs e)
        {
            ctx = new ClassLibraryFashionHousesEF.FashionHousesEntities();

            ctx.Clothes.Load();
            ctx.ClothesInShop.Load();
            ctx.Designers.Load();
            ctx.Divisions.Load();
            ctx.FashionHouses.Load();
            ctx.Presidents.Load();
            ctx.ShopClothes.Load();

            ShowClothesInShops();
        }

        private void btn_DEL_CL_FROM_SH_Click(object sender, EventArgs e)
        {
            try
            {
                var row = dataGridView_CLSH.CurrentCell.OwningRow;
                int SH_ID = Convert.ToInt32(row.Cells["SH_ID"].Value);
                
                var ToRemove = (from c in ctx.ClothesInShop where c.CLSH_CL == c.CLSH_CL && c.CLSH_SH == SH_ID select c).First();
                ctx.ClothesInShop.Remove(ToRemove);
                ctx.SaveChanges();

                ShowClothesInShops();
            }
            catch
            {
                return;
            }
        }

        private void btn_CHANGE_CLSH_Click(object sender, EventArgs e)
        {
            try
            {
                int CLSH_ID = Convert.ToInt32(dataGridView_CLSH.CurrentRow.Cells["CLSH_ID"].Value);
                ChangeCLSHForm clsh = new ChangeCLSHForm(ctx, CLSH_ID);
                clsh.ShowDialog();

                ShowClothesInShops();
            }
            catch
            {

            }
        }
    }
}
