namespace SeegaUI.GameWindow
{
    partial class ClientGameWindow
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
            dataGridView1 = new DataGridView();
            label2 = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            tableLayoutPanel1.Controls.Add(dataGridView1, 1, 1);
            tableLayoutPanel1.Controls.Add(label2, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 23.6786461F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 56.02537F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20.2959824F));
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
            SendButton.Location = new Point(188, 3);
            SendButton.Name = "SendButton";
            SendButton.Size = new Size(94, 30);
            SendButton.TabIndex = 1;
            SendButton.Text = "Send";
            SendButton.UseVisualStyleBackColor = true;
            SendButton.Click += SendButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(149, 109);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(354, 246);
            dataGridView1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 25F);
            label2.Location = new Point(149, 0);
            label2.Name = "label2";
            label2.Size = new Size(354, 106);
            label2.TabIndex = 2;
            label2.Text = "Client";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ClientGameWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "ClientGameWindow";
            Text = "ClientGameWindow";
            Load += ClientGameWindow_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private DataGridView dataGridView1;
        private Label label2;
    }
}