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
    public partial class ChangeFashionHouse : Form
    {
        private ClassLibraryFashionHousesEF.FashionHousesEntities ctx;
        private int FH_ID;

        public ChangeFashionHouse(ClassLibraryFashionHousesEF.FashionHousesEntities ctx, int FH_ID)
        {
            InitializeComponent();
            this.ctx = ctx;
            this.FH_ID = FH_ID;
        }

        private void ChangeFashionHouse_Load(object sender, EventArgs e)
        {

        }

        private void btn_FH_CHANGE_Click(object sender, EventArgs e)
        {
            string FH_NAME = textBox_FH_NAME.Text;
            string FH_ADRESS = textBox_FH_ADRESS.Text;
            string PR_NAME = textBox_PR_NAME.Text;
            int PR_PASSPORT = 0;

            if(textBox_PR_PASSPORT.Text != String.Empty && !Int32.TryParse(textBox_PR_PASSPORT.Text, out PR_PASSPORT))
            {
                MessageBox.Show("Помилка вхiдних даних, дом моди не переiменовано", "Повiдомлення");
                return;
            }

     
            var FHToChange = (from c in ctx.FashionHouses where c.FH_ID == FH_ID select c).First();
            var PRToChange = (from c in ctx.Presidents where c.PR_FH == FH_ID select c).First();

            if (textBox_PR_PASSPORT.Text != String.Empty)
                PRToChange.PR_PASSPORT = PR_PASSPORT;

            if (PR_NAME != String.Empty)
                PRToChange.PR_FULLNAME = PR_NAME;

            if (FH_NAME != String.Empty)
                FHToChange.FH_NAME = FH_NAME;

            if (FH_ADRESS != String.Empty)
                FHToChange.FH_ADRESS = FH_ADRESS;

            ctx.SaveChanges();
            MessageBox.Show("Дом моди успiшно змiнено", "Повiдомлення");
        }
    }
}
