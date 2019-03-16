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
    public partial class AddFashionHouse : Form
    {
        private ClassLibraryFashionHousesEF.FashionHousesEntities ctx;

        public AddFashionHouse(ClassLibraryFashionHousesEF.FashionHousesEntities ctx1)
        {
            InitializeComponent();
            ctx = ctx1;
        }

        private bool CheckForDuplicates(string FH_NAME, int PR_PASSPORT)
        {
            bool result;

            result = (from c in ctx.FashionHouses where c.FH_NAME == FH_NAME select c.FH_ID).Any();
            if (result)
                return false;

            result = (from c in ctx.Presidents where c.PR_PASSPORT == PR_PASSPORT select c.PR_ID).Any();
            return !result;
        }

        private void btn_ADD_FH_Click(object sender, EventArgs e)
        {
            string FH_NAME = textBox_FH_NAME.Text;
            string FH_ADRESS = textBox_FH_ADRESS.Text;

            string PR_NAME = textBox_PR_NAME.Text;
            int PR_PASSPORT;

            if(FH_NAME == String.Empty || FH_ADRESS == String.Empty || !Int32.TryParse(textBox_PR_PASSPORT.Text, out PR_PASSPORT))
            {
                MessageBox.Show("Помилка вхiдних даних, дом моди не додався", "Повiдомлення");
                return;
            }

            if(!CheckForDuplicates(FH_NAME, PR_PASSPORT))
            {
                MessageBox.Show("Такий дом моди або президент вже iснують, дом моди не додався", "Повiдомлення");
                return;
            }

            ClassLibraryFashionHousesEF.FashionHouses fh = new ClassLibraryFashionHousesEF.FashionHouses();

            fh.FH_NAME = FH_NAME;
            fh.FH_ADRESS = FH_ADRESS;

            ctx.FashionHouses.Add(fh);
            ctx.SaveChanges();

            ClassLibraryFashionHousesEF.Presidents pr = new ClassLibraryFashionHousesEF.Presidents();

            pr.PR_FULLNAME = PR_NAME;
            pr.PR_PASSPORT = PR_PASSPORT;
            pr.PR_FH = fh.FH_ID;

            ctx.Presidents.Add(pr);
            ctx.SaveChanges();

            MessageBox.Show("Дом Моди додався успiшно", "Повiдомлення");
        }
    }
}
