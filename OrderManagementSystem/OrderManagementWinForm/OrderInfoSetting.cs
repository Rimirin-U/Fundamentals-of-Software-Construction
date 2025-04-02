using OrderManagementSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderManagementWinForm
{
    public partial class OrderInfoSetting : Form
    {
        public OrderDetail theOrderDetail;

        public OrderInfoSetting(Order order)
        {
            theOrderDetail = order.orderDetail;
            idTextBox.Text = order.id.ToString();
            InitializeComponent();
        }

        public OrderInfoSetting()
        {
            theOrderDetail = new OrderDetail(new Customer(""),
                        new Goods("", 0, 0));
            InitializeComponent();
        }

        private void saveBotton_Click(object sender, EventArgs e)
        {
            theOrderDetail.customer.name = nameTextBox.Text;
            theOrderDetail.goods.kind = kindTextBox.Text;
            theOrderDetail.goods.amount = double.Parse(amountTextBox.Text);
            theOrderDetail.goods.price = double.Parse(priceTextBox.Text);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void cancelBotton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
