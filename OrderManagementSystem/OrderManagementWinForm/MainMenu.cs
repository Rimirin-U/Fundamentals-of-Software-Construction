using System.DirectoryServices;

namespace OrderManagementWinForm
{
    public partial class mainMenu : Form
    {
        public OrderManagementSystem.OrderService orderService;
        public List<OrderManagementSystem.Order> searchResult;
        public List<OrderWidget> orderWidgets;

        public mainMenu()
        {
            orderService = new OrderManagementSystem.OrderService();
            searchResult = new List<OrderManagementSystem.Order>() { };
            orderWidgets = new List<OrderWidget>() { };
            InitializeComponent();
        }

        private void createOrderBotton_Click(object sender, EventArgs e)
        {
            using (var OrderInfoSettingForm = new OrderInfoSetting())
            {
                OrderInfoSettingForm.ShowDialog();
                if (OrderInfoSettingForm.DialogResult == DialogResult.OK)
                {
                    orderService.AddOrder(OrderInfoSettingForm.theOrderDetail);
                }
            }
        }

        private void infoFlowLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void updateInfoFlowLayoutPanel(object sender, PaintEventArgs e)
        {
            //先清理infoFlowLayoutPanel中原有的控件
            foreach(var widgets in orderWidgets)
            {
                widgets.clear();
            }
            //遍历searchResult中的所有Orders，并为其创建控件
            foreach(OrderManagementSystem.Order order in searchResult)
            {
                var widget = new OrderWidget(order, infoFlowLayoutPanel);

            }
        }
    }

    public class OrderWidget
    {
        private Panel panel;
        private TextBox textBox;
        private RadioButton radioButton;
        private FlowLayoutPanel father;
        private static int index = 0;

        public OrderWidget(OrderManagementSystem.Order order, FlowLayoutPanel father)
        {
            //create
            panel = new Panel();
            textBox = new TextBox();
            radioButton = new RadioButton();
            this.father = father;

            //initialize
            textBox.Dock = DockStyle.Fill;
            textBox.Location = new Point(10, 10);
            textBox.Multiline = true;
            textBox.Name = $"textBox{index}";
            textBox.ReadOnly = true;
            textBox.ScrollBars = ScrollBars.Horizontal;
            textBox.Size = new Size(416, 168);
            textBox.TabIndex = 1;
            textBox.Text = order.ToString();

            radioButton.AutoCheck = false;
            radioButton.AutoSize = true;
            radioButton.Dock = DockStyle.Bottom;
            radioButton.Location = new Point(10, 178);
            radioButton.Name = $"radioButton{index}";
            radioButton.Size = new Size(416, 28);
            radioButton.TabIndex = 0;
            radioButton.TabStop = true;
            radioButton.Text = "选择";
            radioButton.UseVisualStyleBackColor = true;

            panel.BorderStyle = BorderStyle.Fixed3D;
            panel.Controls.Add(textBox);
            panel.Controls.Add(radioButton);
            panel.Location = new Point(13, 13);
            panel.Name = $"panel{index}";
            panel.Padding = new Padding(10);
            panel.Size = new Size(440, 220);
            panel.TabIndex = 0;

            index++;
        }
        public void show() {
            father.Controls.Add(panel);
        }
        public void clear() {
            panel.Controls.Clear();
        }
    }

}
