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
            ChatTextbox = new RichTextBox();
            SendButton = new Button();
            GameBoardPanel = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            PlayerLabel = new Label();
            SurrenderLabel = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.BurlyWood;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.75F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 2, 0);
            tableLayoutPanel1.Controls.Add(GameBoardPanel, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 23.6786461F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 56.02537F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20.2959824F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 2;
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
            tableLayoutPanel2.Location = new Point(506, 0);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel1.SetRowSpan(tableLayoutPanel2, 3);
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 13.5440178F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 77.60181F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 9.049774F));
            tableLayoutPanel2.Size = new Size(294, 450);
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
            label1.Size = new Size(288, 60);
            label1.TabIndex = 0;
            label1.Text = "Chat";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ChatPanel
            // 
            ChatPanel.BackColor = Color.Transparent;
            ChatPanel.Dock = DockStyle.Fill;
            ChatPanel.FlowDirection = FlowDirection.TopDown;
            ChatPanel.Location = new Point(3, 63);
            ChatPanel.Name = "ChatPanel";
            ChatPanel.Size = new Size(288, 342);
            ChatPanel.TabIndex = 2;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(ChatTextbox);
            flowLayoutPanel2.Controls.Add(SendButton);
            flowLayoutPanel2.Location = new Point(3, 411);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(288, 36);
            flowLayoutPanel2.TabIndex = 3;
            // 
            // ChatTextbox
            // 
            ChatTextbox.Location = new Point(3, 3);
            ChatTextbox.Name = "ChatTextbox";
            ChatTextbox.Size = new Size(179, 33);
            ChatTextbox.TabIndex = 0;
            ChatTextbox.Text = "";
            // 
            // SendButton
            // 
            SendButton.AutoSize = true;
            SendButton.Font = new Font("Segoe UI", 9F);
            SendButton.Location = new Point(188, 3);
            SendButton.Name = "SendButton";
            SendButton.Size = new Size(94, 30);
            SendButton.TabIndex = 1;
            SendButton.Text = "Send";
            SendButton.UseVisualStyleBackColor = true;
            SendButton.Click += SendButton_Click;
            // 
            // GameBoardPanel
            // 
            GameBoardPanel.BackColor = SystemColors.Control;
            GameBoardPanel.ColumnCount = 5;
            tableLayoutPanel1.SetColumnSpan(GameBoardPanel, 2);
            GameBoardPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            GameBoardPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            GameBoardPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            GameBoardPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            GameBoardPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            GameBoardPanel.Dock = DockStyle.Fill;
            GameBoardPanel.Location = new Point(50, 116);
            GameBoardPanel.Margin = new Padding(50, 10, 50, 10);
            GameBoardPanel.Name = "GameBoardPanel";
            GameBoardPanel.RowCount = 5;
            tableLayoutPanel1.SetRowSpan(GameBoardPanel, 2);
            GameBoardPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            GameBoardPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            GameBoardPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            GameBoardPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            GameBoardPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            GameBoardPanel.Size = new Size(406, 324);
            GameBoardPanel.TabIndex = 3;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel1.SetColumnSpan(tableLayoutPanel3, 2);
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(PlayerLabel, 0, 0);
            tableLayoutPanel3.Controls.Add(SurrenderLabel, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 61F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 39F));
            tableLayoutPanel3.Size = new Size(500, 100);
            tableLayoutPanel3.TabIndex = 4;
            // 
            // PlayerLabel
            // 
            PlayerLabel.AutoSize = true;
            PlayerLabel.Dock = DockStyle.Fill;
            PlayerLabel.Font = new Font("Segoe UI", 14F);
            PlayerLabel.Location = new Point(3, 0);
            PlayerLabel.Name = "PlayerLabel";
            PlayerLabel.Size = new Size(494, 61);
            PlayerLabel.TabIndex = 0;
            PlayerLabel.Text = "Current Player";
            PlayerLabel.TextAlign = ContentAlignment.BottomCenter;
            // 
            // SurrenderLabel
            // 
            SurrenderLabel.AutoSize = true;
            SurrenderLabel.Dock = DockStyle.Fill;
            SurrenderLabel.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            SurrenderLabel.ForeColor = Color.Red;
            SurrenderLabel.Location = new Point(3, 61);
            SurrenderLabel.Name = "SurrenderLabel";
            SurrenderLabel.Padding = new Padding(0, 0, 5, 5);
            SurrenderLabel.Size = new Size(494, 39);
            SurrenderLabel.TabIndex = 1;
            SurrenderLabel.Text = "Surrender";
            SurrenderLabel.TextAlign = ContentAlignment.BottomRight;
            SurrenderLabel.Click += SurrenderLabel_Click;
            // 
            // GameWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "GameWindow";
            Text = "Seega";
            Load += ServerGameWindow_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private FlowLayoutPanel ChatPanel;
        private FlowLayoutPanel flowLayoutPanel2;
        private RichTextBox ChatTextbox;
        private Button SendButton;
        private TableLayoutPanel GameBoardPanel;
        private TableLayoutPanel tableLayoutPanel3;
        private Label PlayerLabel;
        private Label SurrenderLabel;
    }
}