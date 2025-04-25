namespace SeegaUI
{
    partial class GameWindow
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
            tableLayoutPanel2 = new TableLayoutPanel();
            label1 = new Label();
            ChatPanel = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            SendButton = new Button();
            dataGridView1 = new DataGridView();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label2 = new Label();
            playerNameLabel = new Label();
            ChatTextBox = new RichTextBox();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.BurlyWood;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.76029F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 43.8256645F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 2, 0);
            tableLayoutPanel1.Controls.Add(dataGridView1, 1, 1);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 23.6786461F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 56.02537F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20.2959824F));
            tableLayoutPanel1.Size = new Size(836, 485);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.WhiteSmoke;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(ChatPanel, 0, 1);
            tableLayoutPanel2.Controls.Add(flowLayoutPanel2, 0, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(556, 0);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel1.SetRowSpan(tableLayoutPanel2, 3);
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 13.5440178F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 77.60181F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 9.049774F));
            tableLayoutPanel2.Size = new Size(280, 485);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 19F);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(274, 65);
            label1.TabIndex = 0;
            label1.Text = "Chat";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ChatPanel
            // 
            ChatPanel.BackColor = Color.Transparent;
            ChatPanel.Dock = DockStyle.Fill;
            ChatPanel.FlowDirection = FlowDirection.TopDown;
            ChatPanel.Location = new Point(3, 68);
            ChatPanel.Name = "ChatPanel";
            ChatPanel.Size = new Size(274, 369);
            ChatPanel.TabIndex = 2;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoScroll = true;
            flowLayoutPanel2.BackColor = Color.Transparent;
            flowLayoutPanel2.Controls.Add(ChatTextBox);
            flowLayoutPanel2.Controls.Add(SendButton);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(3, 443);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(274, 39);
            flowLayoutPanel2.TabIndex = 3;
            // 
            // SendButton
            // 
            SendButton.AutoSize = true;
            SendButton.Dock = DockStyle.Right;
            SendButton.Location = new Point(134, 3);
            SendButton.Name = "SendButton";
            SendButton.Size = new Size(94, 120);
            SendButton.TabIndex = 1;
            SendButton.Text = "Send";
            SendButton.UseVisualStyleBackColor = true;
            SendButton.Click += SendMessage;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(193, 117);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(360, 265);
            dataGridView1.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(playerNameLabel);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(193, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(360, 108);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(357, 49);
            label2.TabIndex = 0;
            label2.Text = "Turno de...";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // playerNameLabel
            // 
            playerNameLabel.AutoSize = true;
            playerNameLabel.Dock = DockStyle.Fill;
            playerNameLabel.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
            playerNameLabel.Location = new Point(3, 49);
            playerNameLabel.Name = "playerNameLabel";
            playerNameLabel.Size = new Size(357, 45);
            playerNameLabel.TabIndex = 1;
            playerNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ChatTextBox
            // 
            ChatTextBox.Location = new Point(3, 3);
            ChatTextBox.Name = "ChatTextBox";
            ChatTextBox.Size = new Size(125, 120);
            ChatTextBox.TabIndex = 2;
            ChatTextBox.Text = "";
            // 
            // GameWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(836, 485);
            Controls.Add(tableLayoutPanel1);
            Name = "GameWindow";
            Text = "Seega";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button SendButton;
        private DataGridView dataGridView1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label2;
        private Label playerNameLabel;
        private FlowLayoutPanel ChatPanel;
        private RichTextBox ChatTextBox;
    }
}
