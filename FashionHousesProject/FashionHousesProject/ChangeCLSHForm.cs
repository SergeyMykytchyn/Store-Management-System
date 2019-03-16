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
    public partial class ChangeCLSHForm : Form
    {
        private ClassLibraryFashionHousesEF.FashionHousesEntities ctx;
        private int CLSH_ID;

        public ChangeCLSHForm(ClassLibraryFashionHousesEF.FashionHousesEntities ctx, int CLSH_ID)
        {
            InitializeComponent();
            this.ctx = ctx;
            this.CLSH_ID = CLSH_ID;
        }

        private void btn_CHANGE_CLSH_Click(object sender, EventArgs e)
        {
            int CLSH_QTY;
            int CLSH_COST = -1;

            if((!Int32.TryParse(textBox_CLSH_COST.Text, out CLSH_COST) && textBox_CLSH_COST.Text != String.Empty) || (!Int32.TryParse(textBox_CLSH_QTY.Text, out CLSH_QTY) && textBox_CLSH_QTY.Text != String.Empty))
            {
                MessageBox.Show("Iнформацiя про одяг не змiнилася, помилка вхiдних даних", "Повiдомлення");
                return;
            }

            if(textBox_CLSH_COST.Text != String.Empty && CLSH_COST <= 0 || textBox_CLSH_QTY.Text != String.Empty && CLSH_QTY < 1)
            {
                MessageBox.Show("Iнформацiя про одяг не змiнилася, помилка вхiдних даних", "Повiдомлення");
                return;
            }

            var CLSH_to_change = (from c in ctx.ClothesInShop where c.CLSH_ID == CLSH_ID select c).First();

            if (textBox_CLSH_COST.Text != String.Empty)
                CLSH_to_change.CLSH_COST = CLSH_COST;

            if (textBox_CLSH_QTY.Text != String.Empty)
                CLSH_to_change.CLSH_QTY = CLSH_QTY;

            ctx.SaveChanges();

            MessageBox.Show("Iнформацiя про одяг успiшно змiнилася", "Повiдомлення");
        }
    }
}
