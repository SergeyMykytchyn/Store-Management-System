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
    public partial class MainForm : Form
    {
        private ClassLibraryFashionHousesEF.FashionHousesEntities ctx;

        public MainForm()
        {
            InitializeComponent();
        }


        private void tabControlMain_Selected(object sender, TabControlEventArgs e)
        {
            if(e.TabPage == tabPageCL)
            {
              
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ctx = new ClassLibraryFashionHousesEF.FashionHousesEntities();

            ctx.Clothes.Load();
            ctx.ClothesInShop.Load();
            ctx.Designers.Load();
            ctx.Divisions.Load();
            ctx.FashionHouses.Load();
            ctx.Presidents.Load();
            ctx.ShopClothes.Load();

            clothesBindingSource.DataSource = ctx.Clothes.Local.ToBindingList();
            fashionHousesBindingSource.DataSource = ctx.FashionHouses.Local.ToBindingList();
            designersBindingSource.DataSource = ctx.Designers.Local.ToBindingList();

            fashionHousesBindingSource1.DataSource = ctx.FashionHouses.Local.ToBindingList();
            presidentsBindingSource.DataSource = ctx.Presidents.Local.ToBindingList();
        }

        private void dataGridViewCL_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            return;
        }
    }
}
