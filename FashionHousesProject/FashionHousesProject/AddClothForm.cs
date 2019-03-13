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
    public partial class AddClothForm : Form
    {
        private ClassLibraryFashionHousesEF.FashionHousesEntities ctx;

        public AddClothForm()
        {
            InitializeComponent();
        }

        private void AddClothForm_Load(object sender, EventArgs e)
        {
            ctx = new ClassLibraryFashionHousesEF.FashionHousesEntities();

            ctx.Clothes.Load();
            ctx.ClothesInShop.Load();
            ctx.Designers.Load();
            ctx.Divisions.Load();
            ctx.FashionHouses.Load();
            ctx.Presidents.Load();
            ctx.ShopClothes.Load();

            fashionHousesBindingSource.DataSource = ctx.FashionHouses.Local.ToBindingList();
            clothesBindingSource.DataSource = ctx.Clothes.Local.ToBindingList();
            clothesBindingSource1.DataSource = ctx.Clothes.Local.ToBindingList();
            designersBindingSource.DataSource = ctx.Designers.Local.ToBindingList();
        }

        private void dataGridViewDES_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            return;
        }


        private void button_Filter_By_NAME_Click(object sender, EventArgs e)
        {
            string name = comboBox_ENTER_DES_NAME.Text;
            var table = (from c in ctx.Designers where c.DES_FULLNAME == name select c).ToList();
            if (table.Count == 0)
                dataGridViewDES.DataSource = ctx.Designers.Local.ToBindingList();
            else
                dataGridViewDES.DataSource = table;
        }

        private int getFH_ID_by_CL_DES(int CL_DES)
        {
            return (from c in ctx.Designers where c.DES_ID == CL_DES select c.DES_FH).First();
        }

        private bool Check_if_DES_ID_EXISTS(int DES_ID)
        {
            return (from c in ctx.Designers where c.DES_ID == DES_ID select c.DES_ID).Any();
        }

        private bool All_DATA_IS_OK()
        {
            if (textBox_DES.Text == String.Empty || comboBox_CAT.Text == String.Empty || comboBox_COLOR.Text == String.Empty)
                return false;

            return true;
        }

        private bool CheckForDuplicates(int CL_DES, int CL_FH, string CL_DESCRIPTION, string CL_CATEGOTY, string CL_COLOR)
        {
            return (from c in ctx.Clothes where c.CL_DES == CL_DES && c.CL_FH == CL_FH && c.CL_DESCRIPTION == CL_DESCRIPTION
                    && c.CL_CATEGORY == CL_CATEGOTY && c.CL_COLOR == CL_COLOR select c.CL_ID).Any();
        }

        private void button_ADD_CL_Click(object sender, EventArgs e)
        {
            int CL_DES;
            try
            {
                var row = dataGridViewDES.CurrentCell.OwningRow;
                CL_DES = Convert.ToInt32(row.Cells["dESIDDataGridViewTextBoxColumn"].Value);
            }
            catch
            {
                return;
            }
            if (!All_DATA_IS_OK())
            {
                MessageBox.Show("Одяг не додався, помилка вхiдних даних", "Повiдомлення");
                return;
            }

            int CL_FH = getFH_ID_by_CL_DES(CL_DES);
            string CL_DESCRIPTION = textBox_DES.Text;
            string CL_CATEGOTY = comboBox_CAT.Text;
            string CL_COLOR = comboBox_COLOR.Text;

            if(CheckForDuplicates(CL_DES, CL_FH, CL_DESCRIPTION, CL_CATEGOTY, CL_COLOR))
            {
                MessageBox.Show("Такий самий одяг вже додано, тому вiн не додався", "Повiдомлення");
                return;
            }

            ClassLibraryFashionHousesEF.Clothes cl = new ClassLibraryFashionHousesEF.Clothes();

            cl.CL_DES = CL_DES;
            cl.CL_FH = CL_FH;
            cl.CL_DESCRIPTION = CL_DESCRIPTION;
            cl.CL_CATEGORY = CL_CATEGOTY;
            cl.CL_COLOR = CL_COLOR;

            ctx.Clothes.Add(cl);
            ctx.SaveChanges();

            MessageBox.Show("Одяг додався успiшно", "Повiдомлення");

            DialogResult dialogResult = MessageBox.Show("Ви хочете додати одяг до магазину?", "Повiдомлення", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                AddClothToShopForm cl_sh = new AddClothToShopForm(cl.CL_ID);
                cl_sh.ShowDialog();
            }
        }
    }
}
