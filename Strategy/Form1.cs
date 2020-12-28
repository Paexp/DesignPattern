using System;
using System.Windows.Forms;

namespace Strategy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cbxType.Items.AddRange(new []{"正常收费", "满300返100", "打8折"});
            cbxType.SelectedIndex = 0;
        }

        // 用于总计
        private double total = 0.0d; 

        private void btnOk_Click(object sender, EventArgs e)
        {
            CashContext csuper = new CashContext(cbxType.SelectedItem.ToString());

            double totalPrices = csuper.GetResult(Convert.ToDouble(txtPrice.Text) 
                                                  * Convert.ToDouble(txtNum.Text));
            
            total = total + totalPrices;

            lbxList.Items.Add("单价：" + txtPrice.Text + "数量：" + txtNum.Text
                              + " " + cbxType.SelectedItem + " 合计：" + totalPrices.ToString());
            lblResult.Text = total.ToString();
        }
    }
}
