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
            clothesBindingSource1.DataSource = ctx.Clothes.Local.ToBindingList();
            clothesBindingSource2.DataSource = ctx.Clothes.Local.ToBindingList();
            fashionHousesBindingSource.DataSource = ctx.FashionHouses.Local.ToBindingList();
            fashionHousesBindingSource1.DataSource = ctx.FashionHouses.Local.ToBindingList();
            fashionHousesBindingSource2.DataSource = ctx.FashionHouses.Local.ToBindingList();
            fashionHousesBindingSource3.DataSource = ctx.FashionHouses.Local.ToBindingList();
            fashionHousesBindingSource4.DataSource = ctx.FashionHouses.Local.ToBindingList();
            fashionHousesBindingSource5.DataSource = ctx.FashionHouses.Local.ToBindingList();
            fashionHousesBindingSource6.DataSource = ctx.FashionHouses.Local.ToBindingList();
            designersBindingSource.DataSource = ctx.Designers.Local.ToBindingList();
            designersBindingSource1.DataSource = ctx.Designers.Local.ToBindingList();
            designersBindingSource2.DataSource = ctx.Designers.Local.ToBindingList();
            designersBindingSource3.DataSource = ctx.Designers.Local.ToBindingList();
            designersBindingSource4.DataSource = ctx.Designers.Local.ToBindingList();
            designersBindingSource5.DataSource = ctx.Designers.Local.ToBindingList();
            designersBindingSource6.DataSource = ctx.Designers.Local.ToBindingList();
            presidentsBindingSource.DataSource = ctx.Presidents.Local.ToBindingList();
            presidentsBindingSource1.DataSource = ctx.Presidents.Local.ToBindingList();

            UpdateDataGridViewCL();
            UpdateDataGridViewFH();
            UpdateDataGridViewDES();
        }

        private void dataGridViewCL_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            return;
        }

        private void dataGridViewFH_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            return;
        }

        private void btnAddCL_Click(object sender, EventArgs e)
        {
            AddClothForm add_cloth_form = new AddClothForm();
            add_cloth_form.ShowDialog();

            dataGridViewCL.DataSource = (from c in ctx.Clothes select c).ToList();
        }

        private int get_FH_ID_by_FH_NAME(string FH_NAME)
        {
            return (from c in ctx.FashionHouses where c.FH_NAME == FH_NAME select c.FH_ID).First();
        }

        private List<int> get_DES_IDs_by_DES_NAME(string DES_NAME)
        {
            return (from c in ctx.Designers where c.DES_FULLNAME == DES_NAME select c.DES_ID).ToList();
        }

        private bool FHexists(string FH_NAME)
        {
            return (from c in ctx.FashionHouses where c.FH_NAME == FH_NAME select c.FH_ID).Any();
        }
        private void btn_CL_Filter_Click(object sender, EventArgs e)
        {
            string CL_FH_NAME = comboBox_CL_FH.Text;
            string CL_DES_NAME = comboBox_CL_DES.Text;
            string CL_CAT = comboBox_CL_CAT.Text;
            string CL_COLOR = comboBox_CL_COLOR.Text;

            if (!FHexists(CL_FH_NAME) && CL_FH_NAME != String.Empty)
            {
                List<ClassLibraryFashionHousesEF.Clothes> empList = new List<ClassLibraryFashionHousesEF.Clothes>();
                dataGridViewCL.DataSource = empList;
                return;
            }

            var table = from c in ctx.Clothes select c;

            if (CL_FH_NAME != String.Empty)
            {
                int CL_FH = get_FH_ID_by_FH_NAME(CL_FH_NAME);
                table = from t in table where t.CL_FH == CL_FH select t;
            }

            if (CL_DES_NAME != String.Empty)
            {
                List<int> CL_DES_IDs = get_DES_IDs_by_DES_NAME(CL_DES_NAME);
                table = from t in table join id in CL_DES_IDs on t.CL_DES equals id select t;

            }

            if(CL_CAT != String.Empty)
            {
                table = from t in table where t.CL_CATEGORY == CL_CAT select t;
            }

            if(CL_COLOR != String.Empty)
            {
                table = from t in table where t.CL_COLOR == CL_COLOR select t;
            }

            dataGridViewCL.DataSource = table.ToList();
        }

        private List<int> get_CLSH_IDs_by_CLSH_CL(int CLSH_CL)
        {
            return (from c in ctx.ClothesInShop where c.CLSH_CL == CLSH_CL select c.CLSH_ID).ToList();
        }

        private void btnDelCL_Click(object sender, EventArgs e)
        {
            int CL_ID;
            try
            {
                var row = dataGridViewCL.CurrentCell.OwningRow;
                CL_ID = Convert.ToInt32(row.Cells["cLIDDataGridViewTextBoxColumn"].Value);
            }
            catch
            {
                return;
            }

            List<int> CLSH_IDs = get_CLSH_IDs_by_CLSH_CL(CL_ID);
            foreach (int CLSH_ID in CLSH_IDs)
            {
                var CLSHToRemove = ctx.ClothesInShop.SingleOrDefault(x => x.CLSH_ID == CLSH_ID);

                ctx.ClothesInShop.Remove(CLSHToRemove);
                ctx.SaveChanges();
            }

            var CLToRemove = ctx.Clothes.SingleOrDefault(x => x.CL_ID == CL_ID);
            ctx.Clothes.Remove(CLToRemove);
            ctx.SaveChanges();
            MessageBox.Show("Одяг видалився успiшно", "Повiдомлення");

            dataGridViewCL.DataSource = (from c in ctx.Clothes select c).ToList();
        }

        private void button_FH_Filter_Click(object sender, EventArgs e)
        {
            string FH_NAME = comboBox_FH_FH.Text;
            string FH_ADRESS = comboBox_FH_ADRESS.Text;
            string FH_PR = comboBox_FH_PR.Text;

            var table = from c in ctx.FashionHouses select c;

            if(FH_NAME != String.Empty)
            {
                table = from t in table where t.FH_NAME == FH_NAME select t;
            }

            if(FH_ADRESS != String.Empty)
            {
                table = from t in table where t.FH_ADRESS == FH_ADRESS select t;
            }

            if (FH_PR != String.Empty)
            {
                var tablePR = from c in ctx.Presidents where c.PR_FULLNAME == FH_PR select c;
                table = from t in table join tPR in tablePR on t.FH_ID equals tPR.PR_FH select t;
            }

            dataGridViewFH.DataSource = table.ToList();
        }

        private void btn_add_CL_to_SH_Click(object sender, EventArgs e)
        {
            var row = dataGridViewCL.CurrentCell.OwningRow;
            int CL_ID = Convert.ToInt32(row.Cells["cLIDDataGridViewTextBoxColumn"].Value);

            AddClothToShopForm cl_sh = new AddClothToShopForm(CL_ID);
            cl_sh.ShowDialog();
        }

        private void dataGridViewCL_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dataGridViewCL.CurrentCell.OwningRow;
            int CL_ID = Convert.ToInt32(row.Cells["cLIDDataGridViewTextBoxColumn"].Value);

            ShowMeClothInShops clsh = new ShowMeClothInShops(CL_ID);
            clsh.ShowDialog();
        }

        private void btn_Change_CL_Click(object sender, EventArgs e)
        {
            
            try
            {
                var row = dataGridViewCL.CurrentCell.OwningRow;
                int CL_ID = Convert.ToInt32(row.Cells["cLIDDataGridViewTextBoxColumn"].Value);

                var CLtoChange = ctx.Clothes.SingleOrDefault(x => x.CL_ID == CL_ID);

                ChangeCloth cgcl = new ChangeCloth(CL_ID, CLtoChange.CL_DES, CLtoChange.CL_FH, CLtoChange.CL_DESCRIPTION, CLtoChange.CL_COLOR, CLtoChange.CL_CATEGORY, ref ctx);
                cgcl.ShowDialog();

                UpdateDataGridViewCL();
            }
            catch
            {
                return;
            }
        }

        private void UpdateDataGridViewFH()
        {
            dataGridViewFH.DataSource = (from c in ctx.FashionHouses select c).ToList();
        }

        private void UpdateDataGridViewCL()
        {
            dataGridViewCL.DataSource = (from c in ctx.Clothes select c).ToList();
        }

        private void btnAddFH_Click(object sender, EventArgs e)
        {
            AddFashionHouse fh_form = new AddFashionHouse(ctx);
            fh_form.ShowDialog();

            UpdateDataGridViewFH();
        }

        private void btnDelFH_Click(object sender, EventArgs e)
        {
            try
            {
                int FH_ID = Convert.ToInt32(dataGridViewFH.CurrentRow.Cells["fHIDDataGridViewTextBoxColumn"].Value);

                var FHToRemove = ctx.FashionHouses.SingleOrDefault(x => x.FH_ID == FH_ID);
                var PRToRemove = ctx.Presidents.SingleOrDefault(x => x.PR_FH == FH_ID);
                var DesToRemove = (from c in ctx.Designers where c.DES_FH == FH_ID select c).ToList();
                var DivToRemove = (from c in ctx.Divisions where c.DIV_FH == FH_ID select c).ToList();
                var CLToRemove = (from c in ctx.Clothes where c.CL_FH == FH_ID select c).ToList();
                var CL_IDsToRemove = (from c in ctx.Clothes where c.CL_FH == FH_ID select c.CL_ID).ToList();
                var CLSHToRemove = (from c in ctx.ClothesInShop join cl in CL_IDsToRemove on c.CLSH_CL equals cl select c).ToList();
                var SHToRemove = (from c in ctx.ShopClothes where c.SH_FH == FH_ID select c).ToList();

                foreach (var sh in SHToRemove)
                    ctx.ShopClothes.Remove(sh);
                foreach (var clsh in CLSHToRemove)
                    ctx.ClothesInShop.Remove(clsh);
                foreach (var cl in CLToRemove)
                    ctx.Clothes.Remove(cl);
                foreach (var div in DivToRemove)
                    ctx.Divisions.Remove(div);
                foreach (var des in DesToRemove)
                    ctx.Designers.Remove(des);
                ctx.Presidents.Remove(PRToRemove);
                ctx.FashionHouses.Remove(FHToRemove);

                ctx.SaveChanges();
                UpdateDataGridViewFH();
                UpdateDataGridViewCL();
            }
            catch
            {

            }
        }

        private void dataGridViewFH_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int FH_ID = Convert.ToInt32(dataGridViewFH.CurrentRow.Cells["fHIDDataGridViewTextBoxColumn"].Value);

            ShowDivisionsForm df = new ShowDivisionsForm(ctx, FH_ID);
            df.ShowDialog();
        }

        private void btn_CHANGE_FH_Click(object sender, EventArgs e)
        {
            try
            {
                int FH_ID = Convert.ToInt32(dataGridViewFH.CurrentRow.Cells["fHIDDataGridViewTextBoxColumn"].Value);

                ChangeFashionHouse chfh = new ChangeFashionHouse(ctx, FH_ID);
                chfh.ShowDialog();
                UpdateDataGridViewCL();
                UpdateDataGridViewFH();
            }
            catch
            {

            }
        }

        private void btn_SHOW_SH_Click(object sender, EventArgs e)
        {
            try
            {
                int FH_ID = Convert.ToInt32(dataGridViewFH.CurrentRow.Cells["fHIDDataGridViewTextBoxColumn"].Value);

                ShowFashionHouseShops fhsh = new ShowFashionHouseShops(ctx, FH_ID);
                fhsh.ShowDialog();

                UpdateDataGridViewCL();
                UpdateDataGridViewFH();
            }
            catch
            {

            }
        }

        private void UpdateDataGridViewDES()
        {
            dataGridViewDES.DataSource = (from c in ctx.Designers select c).ToList();
        }

        private void btn_FILTER_Click(object sender, EventArgs e)
        {
            string DES_NAME = comboBox_DES_NAME.Text;
            string DES_GENDER = comboBox_DES_GENDER.Text;
            string DES_FH_NAME = comboBox_DES_FH.Text;
            string DES_BIRTHDAY = comboBox_DES_BIRTHDAY.Text;
            int DES_PASSPORT;

            if (!FHexists(DES_FH_NAME) && DES_FH_NAME != String.Empty)
            {
                List<ClassLibraryFashionHousesEF.Designers> empList = new List<ClassLibraryFashionHousesEF.Designers>();
                dataGridViewDES.DataSource = empList;
                return;
            }

            if (!Int32.TryParse(comboBox_DES_PASSPORT.Text, out DES_PASSPORT) && comboBox_DES_PASSPORT.Text != String.Empty)
            {
                List<ClassLibraryFashionHousesEF.Designers> empList = new List<ClassLibraryFashionHousesEF.Designers>();
                dataGridViewDES.DataSource = empList;
                return;
            }

            var table = from c in ctx.Designers select c;

            if (DES_NAME != String.Empty)
                table = from t in table where t.DES_FULLNAME == DES_NAME select t;

            if (DES_GENDER != String.Empty)
                table = from t in table where t.DES_GENDER == DES_GENDER select t;

            if (comboBox_DES_FH.Text != String.Empty)
            {
                int FH_ID = get_FH_ID_by_FH_NAME(DES_FH_NAME);
                table = from t in table where t.DES_FH == FH_ID select t;
            }

            if (DES_BIRTHDAY != String.Empty)
                table = from t in table where t.DES_BIRTHDAY == DES_BIRTHDAY select t;

            if (comboBox_DES_PASSPORT.Text != String.Empty)
                table = from t in table where t.DES_PASSPORT == DES_PASSPORT select t;

            dataGridViewDES.DataSource = table.ToList();
        }

        private void btn_ADD_DES_Click(object sender, EventArgs e)
        {
            AddDesignerForm desform = new AddDesignerForm(ctx);
            desform.ShowDialog();

            UpdateDataGridViewCL();
            UpdateDataGridViewFH();
            UpdateDataGridViewDES();
        }

        private List<int> get_CL_IDs_by_CL_DES(int CL_DES)
        {
            return (from c in ctx.Clothes where c.CL_DES == CL_DES select c.CL_ID).ToList();
        }

        private void btn_DEL_DES_Click(object sender, EventArgs e)
        {
            try
            {
                int DES_ID = Convert.ToInt32(dataGridViewDES.CurrentRow.Cells["dESIDDataGridViewTextBoxColumn"].Value);

                var DEsToRmove = ctx.Designers.SingleOrDefault(x => x.DES_ID == DES_ID);

                List<int> CL_IDs = get_CL_IDs_by_CL_DES(DES_ID);
                
                foreach(int CL_ID in CL_IDs)
                {
                    var CLToRemove = ctx.Clothes.SingleOrDefault(x => x.CL_ID == CL_ID);

                    ctx.Clothes.Remove(CLToRemove);

                    var CLSHToReove = (from c in ctx.ClothesInShop where c.CLSH_CL == CL_ID select c).ToList();

                    foreach (var CLSH in CLSHToReove)
                        ctx.ClothesInShop.Remove(CLSH);
                }

                ctx.Designers.Remove(DEsToRmove);
                ctx.SaveChanges();

                UpdateDataGridViewCL();
                UpdateDataGridViewDES();
                UpdateDataGridViewFH();
            }
            catch
            {

            }
        }

        private void btn_CHANGE_DES_Click(object sender, EventArgs e)
        {
            try
            {
                int DES_ID = Convert.ToInt32(dataGridViewDES.CurrentRow.Cells["dESIDDataGridViewTextBoxColumn"].Value);

                ChangeDesignerForm cgdes = new ChangeDesignerForm(ctx, DES_ID);
                cgdes.ShowDialog();

                UpdateDataGridViewCL();
                UpdateDataGridViewDES();
                UpdateDataGridViewFH();
            }
            catch
            {

            }
        }
    }
}
