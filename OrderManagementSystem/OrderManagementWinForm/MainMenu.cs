namespace OrderManagementWinForm
{
    public partial class mainMenu : Form
    {
        public OrderManagementSystem.OrderService orderService;

        public mainMenu()
        {
            orderService = new OrderManagementSystem.OrderService();
            InitializeComponent();
        }

        private void createOrderBotton_Click(object sender, EventArgs e)
        {
            using (var OrderInfoSettingForm = new OrderInfoSetting())
            {
                OrderInfoSettingForm.ShowDialog();
                if(OrderInfoSettingForm.DialogResult == DialogResult.OK)
                {
                    orderService.AddOrder(OrderInfoSettingForm.theOrderDetail);
                }
            }
        }
    }
}
