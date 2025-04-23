namespace SeegaUI
{
    partial class StartWindow
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
            hostButton = new Button();
            joinButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(titleLabel, 1, 0);
            tableLayoutPanel1.Controls.Add(hostButton, 1, 1);
            tableLayoutPanel1.Controls.Add(joinButton, 1, 3);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 41.34425F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.4032764F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.9099803F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.4032764F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25.9392185F));
            tableLayoutPanel1.Size = new Size(308, 379);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Dock = DockStyle.Fill;
            titleLabel.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            titleLabel.Location = new Point(64, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(178, 156);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Seega";
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // hostButton
            // 
            hostButton.AutoSize = true;
            hostButton.Dock = DockStyle.Fill;
            hostButton.Location = new Point(64, 159);
            hostButton.Name = "hostButton";
            hostButton.Size = new Size(178, 41);
            hostButton.TabIndex = 1;
            hostButton.Text = "Host Match";
            hostButton.UseVisualStyleBackColor = true;
            hostButton.Click += hostButton_Click;
            // 
            // joinButton
            // 
            joinButton.AutoSize = true;
            joinButton.Dock = DockStyle.Fill;
            joinButton.Location = new Point(64, 235);
            joinButton.Name = "joinButton";
            joinButton.Size = new Size(178, 41);
            joinButton.TabIndex = 2;
            joinButton.Text = "Join Match";
            joinButton.UseVisualStyleBackColor = true;
            joinButton.Click += joinButton_Click;
            // 
            // StartWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(332, 403);
            Controls.Add(tableLayoutPanel1);
            Name = "StartWindow";
            Text = "Seega";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button hostButton;
        private Button joinButton;
        private Label titleLabel;
    }
}