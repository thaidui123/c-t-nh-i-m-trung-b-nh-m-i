using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace c__tính_điểm_trung_bình_mới
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        

        private void txtthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txttb_Click(object sender, EventArgs e)
        {
            double toan,van,tb;
            toan = Convert.ToDouble(txttoan.Text);
            van = Convert.ToDouble(txtvan.Text);
            tb = (toan + van) / 2;
            txttb.Text = tb.ToString();

            if(tb<5)
            {
                txtxl.Text = "yếu";
            }    
            else if (tb <= 6) { txtxl.Text = "tb"; }
            else if (tb < 8) { txtxl.Text = "khá"; }
            else if (tb > 8) { txtxl.Text = "giỏi"; }

        }



    }
}
