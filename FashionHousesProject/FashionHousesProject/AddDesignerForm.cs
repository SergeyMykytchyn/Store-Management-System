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
    public partial class AddDesignerForm : Form
    {
        private ClassLibraryFashionHousesEF.FashionHousesEntities ctx;

        public AddDesignerForm(ClassLibraryFashionHousesEF.FashionHousesEntities ctx)
        {
            InitializeComponent();
            this.ctx = ctx;
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

        private void btn_ADD_DES_Click(object sender, EventArgs e)
        {
            string DES_NAME = textBox_DES_NAME.Text;
            int DES_PASSPORT;
            string DES_GENDER = textBox_DES_GENDER.Text;
            string DES_FH_NAME = comboBox_DES_FH_NAME.Text;
            string DES_BIRTHDAY = textBox_DES_BIRTHDAY.Text;

            DateTime temp;

            if(!Int32.TryParse(textBox_DES_PASSPORT.Text, out DES_PASSPORT) || DES_NAME == String.Empty || DES_GENDER == String.Empty
                || !DateTime.TryParse(textBox_DES_BIRTHDAY.Text, out temp) || !FHexists(DES_FH_NAME))
            {
                MessageBox.Show("Помилка вхiдних даних, дизайнер не додався", "Повiдомлення");
                return;
            }

            if(DES_GENDER != "Ч" && DES_GENDER != "Ж" && DES_GENDER != "-")
            {
                MessageBox.Show("Пол дизайнера вказан неправильно, можливi значення Ч, Ж або -, дизайнер не додався", "Повiдомлення");
                return;
            }

            if(CheckForDuplicates(DES_PASSPORT))
            {
                MessageBox.Show("Такий дизайнер вже в базi даних, дизайнер не додався", "Повiдомлення");
                return;
            }

            int DES_FH = get_FH_ID_by_FH_NAME(DES_FH_NAME);

            ClassLibraryFashionHousesEF.Designers des = new ClassLibraryFashionHousesEF.Designers();

            des.DES_FH = DES_FH;
            des.DES_FULLNAME = DES_NAME;
            des.DES_GENDER = DES_GENDER;
            des.DES_PASSPORT = DES_PASSPORT;
            des.DES_BIRTHDAY = DES_BIRTHDAY;

            ctx.Designers.Add(des);
            ctx.SaveChanges();

            MessageBox.Show("Дизайнер додався, успiшно", "Повiдомлення");
        }

        private void AddDesignerForm_Load(object sender, EventArgs e)
        {
            fashionHousesBindingSource.DataSource = ctx.FashionHouses.Local.ToBindingList();
        }
    }
}
