namespace SeegaUI
{
    partial class ClientConfigWindow
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
            tableLayoutPanel1 = new TableLayoutPanel();
            titleLabel = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            nameLabel = new Label();
            nameTextBox = new TextBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            ipAddressLabel = new Label();
            ipAddressTextBox = new TextBox();
            flowLayoutPanel3 = new FlowLayoutPanel();
            portLabel = new Label();
            portTextBox = new TextBox();
            JoinButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2.71084332F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 95.1807251F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2.40963864F));
            tableLayoutPanel1.Controls.Add(titleLabel, 1, 0);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 1, 1);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel2, 1, 2);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel3, 1, 3);
            tableLayoutPanel1.Controls.Add(JoinButton, 1, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(332, 403);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Dock = DockStyle.Fill;
            titleLabel.Font = new Font("Segoe UI", 22F);
            titleLabel.Location = new Point(11, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(309, 80);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Client Options";
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(nameLabel);
            flowLayoutPanel1.Controls.Add(nameTextBox);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(11, 83);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(309, 74);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(3, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(102, 20);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Player's Name";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(3, 23);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(294, 27);
            nameTextBox.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(ipAddressLabel);
            flowLayoutPanel2.Controls.Add(ipAddressTextBox);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel2.Location = new Point(11, 163);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(309, 74);
            flowLayoutPanel2.TabIndex = 2;
            // 
            // ipAddressLabel
            // 
            ipAddressLabel.AutoSize = true;
            ipAddressLabel.Location = new Point(3, 0);
            ipAddressLabel.Name = "ipAddressLabel";
            ipAddressLabel.Size = new Size(78, 20);
            ipAddressLabel.TabIndex = 0;
            ipAddressLabel.Text = "IP Address";
            // 
            // ipAddressTextBox
            // 
            ipAddressTextBox.Dock = DockStyle.Right;
            ipAddressTextBox.Location = new Point(3, 23);
            ipAddressTextBox.Name = "ipAddressTextBox";
            ipAddressTextBox.Size = new Size(294, 27);
            ipAddressTextBox.TabIndex = 1;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(portLabel);
            flowLayoutPanel3.Controls.Add(portTextBox);
            flowLayoutPanel3.Dock = DockStyle.Fill;
            flowLayoutPanel3.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel3.Location = new Point(11, 243);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(309, 74);
            flowLayoutPanel3.TabIndex = 3;
            // 
            // portLabel
            // 
            portLabel.AutoSize = true;
            portLabel.Location = new Point(3, 0);
            portLabel.Name = "portLabel";
            portLabel.Size = new Size(35, 20);
            portLabel.TabIndex = 0;
            portLabel.Text = "Port";
            // 
            // portTextBox
            // 
            portTextBox.Dock = DockStyle.Right;
            portTextBox.Location = new Point(3, 23);
            portTextBox.Name = "portTextBox";
            portTextBox.Size = new Size(294, 27);
            portTextBox.TabIndex = 1;
            // 
            // JoinButton
            // 
            JoinButton.Dock = DockStyle.Top;
            JoinButton.Location = new Point(11, 323);
            JoinButton.Name = "JoinButton";
            JoinButton.Size = new Size(309, 29);
            JoinButton.TabIndex = 4;
            JoinButton.Text = "Join";
            JoinButton.UseVisualStyleBackColor = true;
            JoinButton.Click += JoinButton_Click;
            // 
            // ClientConfigWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(332, 403);
            Controls.Add(tableLayoutPanel1);
            Name = "ClientConfigWindow";
            Text = "Seega";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label titleLabel;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label nameLabel;
        private TextBox nameTextBox;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label ipAddressLabel;
        private TextBox ipAddressTextBox;
        private FlowLayoutPanel flowLayoutPanel3;
        private Label portLabel;
        private TextBox portTextBox;
        private Button JoinButton;
    }
}
