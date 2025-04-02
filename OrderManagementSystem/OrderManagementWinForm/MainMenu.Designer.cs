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
            searchResultBindingSource = new BindingSource(components);
            infoFlowLayoutPanel = new FlowLayoutPanel();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)searchResultBindingSource).BeginInit();
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
            createOrderBotton.Click += createOrderBotton_Click;
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
            searchOrderBotton.Click += searchOrderBotton_Click;
            // 
            // searchSelectionComboBox
            // 
            searchSelectionComboBox.Anchor = AnchorStyles.Left;
            searchSelectionComboBox.FormattingEnabled = true;
            searchSelectionComboBox.Items.AddRange(new object[] { "按ID查找", "按顾客查找" });
            searchSelectionComboBox.Location = new Point(10, 16);
            searchSelectionComboBox.Name = "searchSelectionComboBox";
            searchSelectionComboBox.Size = new Size(128, 32);
            searchSelectionComboBox.TabIndex = 0;
            // 
            // searchResultBindingSource
            // 
            searchResultBindingSource.AllowNew = true;
            searchResultBindingSource.DataSource = typeof(OrderManagementSystem.Order);
            // 
            // infoFlowLayoutPanel
            // 
            infoFlowLayoutPanel.AutoScroll = true;
            infoFlowLayoutPanel.BorderStyle = BorderStyle.FixedSingle;
            infoFlowLayoutPanel.Dock = DockStyle.Fill;
            infoFlowLayoutPanel.Location = new Point(200, 64);
            infoFlowLayoutPanel.Name = "infoFlowLayoutPanel";
            infoFlowLayoutPanel.Padding = new Padding(10);
            infoFlowLayoutPanel.Size = new Size(948, 642);
            infoFlowLayoutPanel.TabIndex = 4;
            // 
            // mainMenu
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1148, 706);
            Controls.Add(infoFlowLayoutPanel);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MinimumSize = new Size(800, 400);
            Name = "mainMenu";
            Text = "OrderManagementSystem";
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)searchResultBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button createOrderBotton;
        private Panel panel1;
        private Panel panel2;
        private Button searchOrderBotton;
        private ComboBox searchSelectionComboBox;
        private TextBox searchInputTextBox;
        private Panel panel4;
        private Button deleteOrderBotton;
        private Button modifyOrderBotton;
        private DataGridViewTextBoxColumn orderDetailTimeDataGridViewTextBoxColumn;
        private BindingSource searchResultBindingSource;
        private FlowLayoutPanel infoFlowLayoutPanel;
    }
}
