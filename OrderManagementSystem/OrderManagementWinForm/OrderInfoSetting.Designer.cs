namespace OrderManagementWinForm
{
    partial class OrderInfoSetting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            orderDetailInfo = new GroupBox();
            goodsInfo = new GroupBox();
            amountTextBox = new TextBox();
            label4 = new Label();
            priceTextBox = new TextBox();
            label3 = new Label();
            kindTextBox = new TextBox();
            label2 = new Label();
            customerInfo = new GroupBox();
            nameTextBox = new TextBox();
            label1 = new Label();
            orderInfo = new GroupBox();
            idTextBox = new TextBox();
            IDLabel = new Label();
            panel3 = new Panel();
            saveBotton = new Button();
            cancelBotton = new Button();
            panel1.SuspendLayout();
            orderDetailInfo.SuspendLayout();
            goodsInfo.SuspendLayout();
            customerInfo.SuspendLayout();
            orderInfo.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(orderDetailInfo);
            panel1.Controls.Add(orderInfo);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10);
            panel1.Size = new Size(738, 744);
            panel1.TabIndex = 0;
            // 
            // orderDetailInfo
            // 
            orderDetailInfo.AutoSize = true;
            orderDetailInfo.Controls.Add(goodsInfo);
            orderDetailInfo.Controls.Add(customerInfo);
            orderDetailInfo.Dock = DockStyle.Top;
            orderDetailInfo.Location = new Point(10, 106);
            orderDetailInfo.Name = "orderDetailInfo";
            orderDetailInfo.Padding = new Padding(10);
            orderDetailInfo.Size = new Size(718, 335);
            orderDetailInfo.TabIndex = 1;
            orderDetailInfo.TabStop = false;
            orderDetailInfo.Text = "订单详情";
            // 
            // goodsInfo
            // 
            goodsInfo.AutoSize = true;
            goodsInfo.Controls.Add(amountTextBox);
            goodsInfo.Controls.Add(label4);
            goodsInfo.Controls.Add(priceTextBox);
            goodsInfo.Controls.Add(label3);
            goodsInfo.Controls.Add(kindTextBox);
            goodsInfo.Controls.Add(label2);
            goodsInfo.Dock = DockStyle.Top;
            goodsInfo.Location = new Point(10, 129);
            goodsInfo.Name = "goodsInfo";
            goodsInfo.Padding = new Padding(10);
            goodsInfo.Size = new Size(698, 196);
            goodsInfo.TabIndex = 5;
            goodsInfo.TabStop = false;
            goodsInfo.Text = "货物信息";
            // 
            // amountTextBox
            // 
            amountTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            amountTextBox.Location = new Point(394, 130);
            amountTextBox.Name = "amountTextBox";
            amountTextBox.Size = new Size(160, 30);
            amountTextBox.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(150, 133);
            label4.Name = "label4";
            label4.Size = new Size(46, 24);
            label4.TabIndex = 6;
            label4.Text = "数量";
            // 
            // priceTextBox
            // 
            priceTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            priceTextBox.Location = new Point(394, 80);
            priceTextBox.Name = "priceTextBox";
            priceTextBox.Size = new Size(160, 30);
            priceTextBox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(150, 83);
            label3.Name = "label3";
            label3.Size = new Size(46, 24);
            label3.TabIndex = 4;
            label3.Text = "单价";
            // 
            // kindTextBox
            // 
            kindTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            kindTextBox.Location = new Point(394, 30);
            kindTextBox.Name = "kindTextBox";
            kindTextBox.Size = new Size(160, 30);
            kindTextBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(150, 33);
            label2.Name = "label2";
            label2.Size = new Size(46, 24);
            label2.TabIndex = 1;
            label2.Text = "种类";
            // 
            // customerInfo
            // 
            customerInfo.AutoSize = true;
            customerInfo.Controls.Add(nameTextBox);
            customerInfo.Controls.Add(label1);
            customerInfo.Dock = DockStyle.Top;
            customerInfo.Location = new Point(10, 33);
            customerInfo.Name = "customerInfo";
            customerInfo.Padding = new Padding(10);
            customerInfo.Size = new Size(698, 96);
            customerInfo.TabIndex = 4;
            customerInfo.TabStop = false;
            customerInfo.Text = "顾客信息";
            // 
            // nameTextBox
            // 
            nameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nameTextBox.Location = new Point(394, 30);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(160, 30);
            nameTextBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(150, 33);
            label1.Name = "label1";
            label1.Size = new Size(46, 24);
            label1.TabIndex = 0;
            label1.Text = "姓名";
            // 
            // orderInfo
            // 
            orderInfo.AutoSize = true;
            orderInfo.Controls.Add(idTextBox);
            orderInfo.Controls.Add(IDLabel);
            orderInfo.Dock = DockStyle.Top;
            orderInfo.Location = new Point(10, 10);
            orderInfo.Name = "orderInfo";
            orderInfo.Padding = new Padding(10);
            orderInfo.Size = new Size(718, 96);
            orderInfo.TabIndex = 0;
            orderInfo.TabStop = false;
            orderInfo.Text = "订单信息";
            // 
            // idTextBox
            // 
            idTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            idTextBox.Location = new Point(404, 30);
            idTextBox.Name = "idTextBox";
            idTextBox.ReadOnly = true;
            idTextBox.Size = new Size(160, 30);
            idTextBox.TabIndex = 1;
            // 
            // IDLabel
            // 
            IDLabel.AutoSize = true;
            IDLabel.Location = new Point(160, 33);
            IDLabel.Name = "IDLabel";
            IDLabel.Size = new Size(29, 24);
            IDLabel.TabIndex = 0;
            IDLabel.Text = "ID";
            // 
            // panel3
            // 
            panel3.AutoSize = true;
            panel3.Controls.Add(saveBotton);
            panel3.Controls.Add(cancelBotton);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 686);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(10);
            panel3.Size = new Size(738, 58);
            panel3.TabIndex = 1;
            // 
            // saveBotton
            // 
            saveBotton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            saveBotton.Location = new Point(616, 12);
            saveBotton.Name = "saveBotton";
            saveBotton.Size = new Size(112, 34);
            saveBotton.TabIndex = 1;
            saveBotton.Text = "保存";
            saveBotton.UseVisualStyleBackColor = true;
            saveBotton.Click += saveBotton_Click;
            // 
            // cancelBotton
            // 
            cancelBotton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cancelBotton.Location = new Point(498, 12);
            cancelBotton.Name = "cancelBotton";
            cancelBotton.Size = new Size(112, 34);
            cancelBotton.TabIndex = 0;
            cancelBotton.Text = "取消";
            cancelBotton.UseVisualStyleBackColor = true;
            cancelBotton.Click += cancelBotton_Click;
            // 
            // OrderInfoSetting
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(738, 744);
            Controls.Add(panel3);
            Controls.Add(panel1);
            MinimumSize = new Size(620, 400);
            Name = "OrderInfoSetting";
            Tag = "";
            Text = "设置订单信息";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            orderDetailInfo.ResumeLayout(false);
            orderDetailInfo.PerformLayout();
            goodsInfo.ResumeLayout(false);
            goodsInfo.PerformLayout();
            customerInfo.ResumeLayout(false);
            customerInfo.PerformLayout();
            orderInfo.ResumeLayout(false);
            orderInfo.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private GroupBox orderDetailInfo;
        private GroupBox orderInfo;
        private GroupBox goodsInfo;
        private GroupBox customerInfo;
        private Panel panel3;
        private Button saveBotton;
        private Button cancelBotton;
        private Label IDLabel;
        private TextBox priceTextBox;
        private Label label3;
        private TextBox kindTextBox;
        private Label label2;
        private TextBox nameTextBox;
        private Label label1;
        private TextBox idTextBox;
        private TextBox amountTextBox;
        private Label label4;
    }
}