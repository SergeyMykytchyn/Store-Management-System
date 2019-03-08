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
    public partial class Form1 : Form
    {
        private ClassLibraryFashionHousesEF.FashionHousesEntities ctx;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ctx = new ClassLibraryFashionHousesEF.FashionHousesEntities();

            ctx.Clothes.Load();
            ctx.ClothesInShop.Load();
            ctx.Designers.Load();
            ctx.Divisions.Load();
            ctx.FashionHouses.Load();
            ctx.Presidents.Load();
            ctx.ShopClothes.Load();
        }
    }
}
