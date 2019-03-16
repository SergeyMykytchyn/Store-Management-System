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
    public partial class ChangeDivision : Form
    {
        private ClassLibraryFashionHousesEF.FashionHousesEntities ctx;
        private int DIV_ID;

        public ChangeDivision(ClassLibraryFashionHousesEF.FashionHousesEntities ctx, int DIV_ID)
        {
            InitializeComponent();
            this.ctx = ctx;
            this.DIV_ID = DIV_ID;
        }

        private void btn_CHANGE_DIV_Click(object sender, EventArgs e)
        {
            string DIV_ADRESS = textBox_DIV_ADRESS.Text;
            string DIV_NAME = textBox_DIV_NAME.Text;
            int DIV_QTY;

            if(!Int32.TryParse(textBox_DIV_QTY.Text, out DIV_QTY) && textBox_DIV_QTY.Text != String.Empty)
            {
                MessageBox.Show("Iнформацiя про пiдроздiл не змiнилася, помилка вхiдних даних", "Повiдомлення");
                return;
            }

            var Div_to_change = (from c in ctx.Divisions where c.DIV_ID == DIV_ID select c).First();

            if (DIV_NAME != String.Empty)
                Div_to_change.DIV_NAME = DIV_NAME;

            if (DIV_ADRESS != String.Empty)
                Div_to_change.DIV_ADRESS = DIV_ADRESS;

            if (textBox_DIV_QTY.Text != String.Empty)
                Div_to_change.DIV_QTY = DIV_QTY;

            ctx.SaveChanges();

            MessageBox.Show("Iнформацiя про пiдроздiл успiшно змiнилася", "Повiдомлення");
        }
    }
}
