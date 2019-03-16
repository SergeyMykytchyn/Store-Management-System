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
    public partial class AddDivisionForm : Form
    {
        private ClassLibraryFashionHousesEF.FashionHousesEntities ctx;
        private int FH_ID;

        public AddDivisionForm(ClassLibraryFashionHousesEF.FashionHousesEntities ctx, int FH_ID)
        {
            InitializeComponent();
            this.ctx = ctx;
            this.FH_ID = FH_ID;
        }

        private bool CheckForDuplicates(string DIV_NAME)
        {
            return (from c in ctx.Divisions where c.DIV_NAME == DIV_NAME select c.DIV_ID).Any();
        }

        private void btn_DIV_ADD_Click(object sender, EventArgs e)
        {
            string DIV_NAME = textBox_DIV_NAME.Text;
            string DIV_ADRESS = textBox_DIV_ADRESS.Text;
            int DIV_QTY;

            if(DIV_NAME == string.Empty || DIV_ADRESS == String.Empty || !Int32.TryParse(textBox_DIV_QTY.Text, out DIV_QTY) || DIV_QTY < 1)
            {
                MessageBox.Show("Помилка вхiдних даних, пiдроздiл не додано", "Повiдомлення");
                return;
            }

            if(CheckForDuplicates(DIV_NAME))
            {
                MessageBox.Show("Такий пiдроздiл вже існує, пiдроздiл не додано", "Повiдомлення");
                return;
            }

            ClassLibraryFashionHousesEF.Divisions div = new ClassLibraryFashionHousesEF.Divisions();

            div.DIV_NAME = DIV_NAME;
            div.DIV_ADRESS = DIV_ADRESS;
            div.DIV_QTY = DIV_QTY;
            div.DIV_FH = FH_ID;

            ctx.Divisions.Add(div);
            ctx.SaveChanges();

            MessageBox.Show("Пiдроздiл успiшно додано", "Повiдомлення");
        }
    }
}
