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
    public partial class ChangeDesignerForm : Form
    {
        private ClassLibraryFashionHousesEF.FashionHousesEntities ctx;
        private int DES_ID;

        public ChangeDesignerForm(ClassLibraryFashionHousesEF.FashionHousesEntities ctx, int DES_ID)
        {
            InitializeComponent();
            this.ctx = ctx;
            this.DES_ID = DES_ID;
        }

        private bool FHexists(string FH_NAME)
        {
            return (from c in ctx.FashionHouses where c.FH_NAME == FH_NAME select c).Any();
        }

        private int get_FH_ID_by_FH_NAME(string FH_NAME)
        {
            return (from c in ctx.FashionHouses where c.FH_NAME == FH_NAME select c.FH_ID).First();
        }

        private bool CheckForDuplicates(int DES_PASSPORT)
        {
            return (from c in ctx.Designers where c.DES_PASSPORT == DES_PASSPORT select c).Any();
        }

        private void btn_DES_CHANGE_Click(object sender, EventArgs e)
        {
            string DES_NAME = textBox_DES_NAME.Text;
            string DES_GENDER = textBox_DES_GENDER.Text;
            string DES_FH_NAME = comboBox_DES_FH_NAME.Text;
            string DES_BIRTHDAY = textBox_DES_BIRTHDAY.Text;
            int DES_PASSPORT;

            DateTime temp;

            if ((!Int32.TryParse(textBox_DES_PASSPORT.Text, out DES_PASSPORT) && textBox_DES_PASSPORT.Text != String.Empty) 
                || (!DateTime.TryParse(textBox_DES_BIRTHDAY.Text, out temp) && textBox_DES_BIRTHDAY.Text != String.Empty) 
                || (!FHexists(DES_FH_NAME) && DES_FH_NAME != String.Empty))
            {
                MessageBox.Show("Помилка вхiдних даних, дизайнер не додався", "Повiдомлення");
                return;
            }

            if (DES_GENDER != "Ч" && DES_GENDER != "Ж" && DES_GENDER != "-" && DES_GENDER != String.Empty)
            {
                MessageBox.Show("Пол дизайнера вказан неправильно, можливi значення Ч, Ж або -, дизайнер не додався", "Повiдомлення");
                return;
            }

            if (CheckForDuplicates(DES_PASSPORT) && textBox_DES_PASSPORT.Text != String.Empty)
            {
                MessageBox.Show("Такий дизайнер вже в базi даних, дизайнер не додався", "Повiдомлення");
                return;
            }

            var des = ctx.Designers.SingleOrDefault(x => x.DES_ID == DES_ID);

            if(DES_FH_NAME != String.Empty)
            {
                int DES_FH = get_FH_ID_by_FH_NAME(DES_FH_NAME);
                des.DES_FH = DES_FH;
            }

            if(DES_NAME != String.Empty)
                des.DES_FULLNAME = DES_NAME;
            
            if(DES_GENDER != String.Empty)
                des.DES_GENDER = DES_GENDER;

            if(textBox_DES_PASSPORT.Text != String.Empty)
                des.DES_PASSPORT = DES_PASSPORT;

            if(DES_BIRTHDAY != String.Empty)
                des.DES_BIRTHDAY = DES_BIRTHDAY;

            ctx.SaveChanges();
            MessageBox.Show("Дизайнера успiшно змiнено", "Повiдомлення");
        }

        private void ChangeDesignerForm_Load(object sender, EventArgs e)
        {
            fashionHousesBindingSource.DataSource = ctx.FashionHouses.Local.ToBindingList();
        }
    }
}
