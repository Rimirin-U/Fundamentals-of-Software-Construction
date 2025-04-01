namespace OrderManagementWinForm
{
    partial class mainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            createOrderBotton = new Button();
            panel1 = new Panel();
            panel4 = new Panel();
            deleteOrderBotton = new Button();
            modifyOrderBotton = new Button();
            panel2 = new Panel();
            searchInputTextBox = new TextBox();
            searchOrderBotton = new Button();
            searchSelectionComboBox = new ComboBox();
            panel3 = new Panel();
            dataGridView1 = new DataGridView();
            orderBindingSource = new BindingSource(components);
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            orderDetailTimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            orderDetailCustomerNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderBindingSource).BeginInit();
            SuspendLayout();
            // 
            // createOrderBotton
            // 
            createOrderBotton.Dock = DockStyle.Bottom;
            createOrderBotton.Location = new Point(10, 624);
            createOrderBotton.Margin = new Padding(4);
            createOrderBotton.Name = "createOrderBotton";
            createOrderBotton.Size = new Size(178, 70);
            createOrderBotton.TabIndex = 1;
            createOrderBotton.Text = "创建订单";
            createOrderBotton.UseVisualStyleBackColor = true;
            createOrderBotton.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(createOrderBotton);
            panel1.Dock = DockStyle.Left;
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10);
            panel1.Size = new Size(200, 706);
            panel1.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.AutoScroll = true;
            panel4.Controls.Add(deleteOrderBotton);
            panel4.Controls.Add(modifyOrderBotton);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(10, 10);
            panel4.Name = "panel4";
            panel4.Size = new Size(178, 614);
            panel4.TabIndex = 5;
            // 
            // deleteOrderBotton
            // 
            deleteOrderBotton.Dock = DockStyle.Top;
            deleteOrderBotton.Location = new Point(0, 70);
            deleteOrderBotton.Margin = new Padding(4, 8, 4, 8);
            deleteOrderBotton.Name = "deleteOrderBotton";
            deleteOrderBotton.Size = new Size(178, 70);
            deleteOrderBotton.TabIndex = 7;
            deleteOrderBotton.Text = "删除订单";
            deleteOrderBotton.UseVisualStyleBackColor = true;
            // 
            // modifyOrderBotton
            // 
            modifyOrderBotton.Dock = DockStyle.Top;
            modifyOrderBotton.Location = new Point(0, 0);
            modifyOrderBotton.Margin = new Padding(4, 8, 4, 8);
            modifyOrderBotton.Name = "modifyOrderBotton";
            modifyOrderBotton.Size = new Size(178, 70);
            modifyOrderBotton.TabIndex = 6;
            modifyOrderBotton.Text = "修改订单";
            modifyOrderBotton.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(searchInputTextBox);
            panel2.Controls.Add(searchOrderBotton);
            panel2.Controls.Add(searchSelectionComboBox);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(200, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(948, 64);
            panel2.TabIndex = 3;
            // 
            // searchInputTextBox
            // 
            searchInputTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            searchInputTextBox.Font = new Font("Microsoft YaHei UI", 9.5F);
            searchInputTextBox.Location = new Point(170, 16);
            searchInputTextBox.Name = "searchInputTextBox";
            searchInputTextBox.Size = new Size(618, 32);
            searchInputTextBox.TabIndex = 2;
            // 
            // searchOrderBotton
            // 
            searchOrderBotton.Anchor = AnchorStyles.Right;
            searchOrderBotton.Location = new Point(815, 16);
            searchOrderBotton.Name = "searchOrderBotton";
            searchOrderBotton.Size = new Size(120, 32);
            searchOrderBotton.TabIndex = 1;
            searchOrderBotton.Text = "查找订单";
            searchOrderBotton.UseVisualStyleBackColor = true;
            // 
            // searchSelectionComboBox
            // 
            searchSelectionComboBox.Anchor = AnchorStyles.Left;
            searchSelectionComboBox.FormattingEnabled = true;
            searchSelectionComboBox.Location = new Point(10, 16);
            searchSelectionComboBox.Name = "searchSelectionComboBox";
            searchSelectionComboBox.Size = new Size(128, 32);
            searchSelectionComboBox.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(dataGridView1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(200, 64);
            panel3.Name = "panel3";
            panel3.Size = new Size(948, 642);
            panel3.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, orderDetailTimeDataGridViewTextBoxColumn, orderDetailCustomerNameDataGridViewTextBoxColumn, Column1, Column2, Column3, Column4 });
            dataGridView1.DataSource = orderBindingSource;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(946, 640);
            dataGridView1.TabIndex = 0;
            // 
            // orderBindingSource
            // 
            orderBindingSource.DataSource = typeof(OrderManagementSystem.Order);
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "id";
            idDataGridViewTextBoxColumn.HeaderText = "ID";
            idDataGridViewTextBoxColumn.MinimumWidth = 8;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Width = 150;
            // 
            // orderDetailTimeDataGridViewTextBoxColumn
            // 
            orderDetailTimeDataGridViewTextBoxColumn.DataPropertyName = "orderDetail.time";
            orderDetailTimeDataGridViewTextBoxColumn.HeaderText = "时间";
            orderDetailTimeDataGridViewTextBoxColumn.MinimumWidth = 8;
            orderDetailTimeDataGridViewTextBoxColumn.Name = "orderDetailTimeDataGridViewTextBoxColumn";
            orderDetailTimeDataGridViewTextBoxColumn.Width = 150;
            // 
            // orderDetailCustomerNameDataGridViewTextBoxColumn
            // 
            orderDetailCustomerNameDataGridViewTextBoxColumn.DataPropertyName = "orderDetail.customer.name";
            orderDetailCustomerNameDataGridViewTextBoxColumn.HeaderText = "顾客姓名";
            orderDetailCustomerNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            orderDetailCustomerNameDataGridViewTextBoxColumn.Name = "orderDetailCustomerNameDataGridViewTextBoxColumn";
            orderDetailCustomerNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "orderDetail.goods.kind";
            Column1.HeaderText = "货物类型";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.Width = 150;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "orderDetail.goods.amount";
            Column2.HeaderText = "货物数量";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.Width = 150;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "orderDetail.goods.price";
            Column3.HeaderText = "货物单价";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.Width = 150;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "orderDetail.money";
            Column4.HeaderText = "总价";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.Width = 150;
            // 
            // mainMenu
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1148, 706);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MinimumSize = new Size(800, 400);
            Name = "mainMenu";
            Text = "OrderManagementSystem";
            Load += mainMenu_Load;
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button createOrderBotton;
        private Panel panel1;
        private Panel panel2;
        private Button searchOrderBotton;
        private ComboBox searchSelectionComboBox;
        private TextBox searchInputTextBox;
        private Panel panel3;
        private Panel panel4;
        private Button deleteOrderBotton;
        private Button modifyOrderBotton;
        private DataGridView dataGridView1;
        private BindingSource orderBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn orderDetailTimeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn orderDetailCustomerNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}
