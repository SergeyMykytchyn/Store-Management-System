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
    public partial class ChangeCloth : Form
    {
        private ClassLibraryFashionHousesEF.FashionHousesEntities ctx;

        private int CL_ID, CL_DES, CL_FH;
        private string CL_DESCRIPTION, CL_COLOR, CL_CATEGORY;

        private void btn_CL_CHANGE_Click(object sender, EventArgs e)
        {
            string CL_DESCRIPTION_ = textBox_DESCRIPTION_TO_CHANGE.Text;
            string CL_COLOR_ = textBox_COLOR_TO_CHANGE.Text;
            string CL_CATEGORY_ = textBox_CAT_TO_CHANGE.Text;

            if (CL_DESCRIPTION_ == String.Empty)
                CL_DESCRIPTION_ = this.CL_DESCRIPTION;

            if (CL_COLOR_ == String.Empty)
                CL_COLOR_ = this.CL_COLOR;

            if (CL_CATEGORY_ == String.Empty)
                CL_CATEGORY_ = this.CL_CATEGORY;

            if(comboBox_FH_TO_CHANGE.SelectedIndex < 0 || comboBox_DES_TO_CHANGE.SelectedIndex < 0)
            {
                MessageBox.Show("Ви не вибрали Дом моди або Дизайнера, одяг не змiнено", "Повiдомлення");
                return;
            }

            int CL_FH_ = Convert.ToInt32(comboBox_FH_TO_CHANGE.SelectedValue.ToString());
            int CL_DES_ = Convert.ToInt32(comboBox_DES_TO_CHANGE.SelectedValue.ToString());

            if (this.CL_FH != CL_FH_)
            {
                var ItemsToDelete = (from c in ctx.ClothesInShop where c.CLSH_CL == this.CL_ID select c).ToList();

                foreach (var item in ItemsToDelete)
                    ctx.ClothesInShop.Remove(item);
                ctx.SaveChanges();
            }

            var CLtoChange = ctx.Clothes.SingleOrDefault(x => x.CL_ID == this.CL_ID);

            CLtoChange.CL_DES = CL_DES_;
            CLtoChange.CL_FH = CL_FH_;
            CLtoChange.CL_DESCRIPTION = CL_DESCRIPTION_;
            CLtoChange.CL_COLOR = CL_COLOR_;
            CLtoChange.CL_CATEGORY = CL_CATEGORY_;

            ctx.SaveChanges();
            MessageBox.Show("Одяг успiшно змiнено", "Повiдомлення");
        }

        public ChangeCloth(int CL_ID, int CL_DES, int CL_FH, string CL_DESCRIPTION, string CL_COLOR, string CL_CATEGORY, ref ClassLibraryFashionHousesEF.FashionHousesEntities ctx1)
        {
            InitializeComponent();
            this.CL_ID = CL_ID;
            this.CL_DES = CL_DES;
            this.CL_FH = CL_FH;
            this.CL_DESCRIPTION = CL_DESCRIPTION;
            this.CL_CATEGORY = CL_CATEGORY;
            this.CL_COLOR = CL_COLOR;
            ctx = ctx1;
        }

        private void ChangeCloth_Load(object sender, EventArgs e)
        {
            //ctx = new ClassLibraryFashionHousesEF.FashionHousesEntities();

            //ctx.Clothes.Load();
            //ctx.ClothesInShop.Load();
            //ctx.Designers.Load();
            //ctx.Divisions.Load();
            //ctx.FashionHouses.Load();
            //ctx.Presidents.Load();
            //ctx.ShopClothes.Load();

            fashionHousesBindingSource.DataSource = ctx.FashionHouses.Local.ToBindingList();
            designersBindingSource.DataSource = ctx.Designers.Local.ToBindingList();
        }
    }
}
