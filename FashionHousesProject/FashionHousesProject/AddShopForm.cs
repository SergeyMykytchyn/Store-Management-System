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
    public partial class AddShopForm : Form
    {
        private ClassLibraryFashionHousesEF.FashionHousesEntities ctx;
        private int FH_ID;

        public AddShopForm(ClassLibraryFashionHousesEF.FashionHousesEntities ctx, int FH_ID)
        {
            InitializeComponent();
            this.ctx = ctx;
            this.FH_ID = FH_ID;
        }

        private bool CheckForDuplicates(string SH_ADRESS)
        {
            return (from c in ctx.ShopClothes where c.SH_ADRESS == SH_ADRESS select c.SH_ID).Any();
        }

        private void btn_ADD_SH_Click(object sender, EventArgs e)
        {
            int SH_QTY_EMP;
            string SH_ADRESS = textBox_SH_ADRESS.Text;

            if(!Int32.TryParse(textBox_SH_QTY_EMP.Text, out SH_QTY_EMP) || SH_ADRESS == String.Empty || SH_QTY_EMP < 1)
            {
                MessageBox.Show("Помилка вхiдних даних, магазин не додано", "Повiдомлення");
                return;
            }

            if(CheckForDuplicates(SH_ADRESS))
            {
                MessageBox.Show("Магазин за такою самою адресою вже існує, магазин не додано", "Повiдомлення");
                return;
            }

            ClassLibraryFashionHousesEF.ShopClothes sh = new ClassLibraryFashionHousesEF.ShopClothes();

            sh.SH_QTY_EMP = SH_QTY_EMP;
            sh.SH_ADRESS = SH_ADRESS;
            sh.SH_FH = FH_ID;

            ctx.ShopClothes.Add(sh);
            ctx.SaveChanges();

            MessageBox.Show("Иагазин успiшно додано", "Повiдомлення");
        }
    }
}
