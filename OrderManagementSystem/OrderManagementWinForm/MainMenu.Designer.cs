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
            createOrderBotton = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            searchInputTextBox = new TextBox();
            searchOrderBotton = new Button();
            searchSelectionComboBox = new ComboBox();
            panel3 = new Panel();
            panel4 = new Panel();
            modifyOrderBotton = new Button();
            deleteOrderBotton = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
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
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(200, 64);
            panel3.Name = "panel3";
            panel3.Size = new Size(948, 642);
            panel3.TabIndex = 4;
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
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
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
    }
}
