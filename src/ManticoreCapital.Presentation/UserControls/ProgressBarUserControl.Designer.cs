namespace ManticoreCapital.Presentation.UserControls
{
    partial class ProgressBarUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            pnlProgressMessage = new Panel();
            lblMessage = new Label();
            pnlProgressBar = new Panel();
            progressBar = new ProgressBar();
            pnlProgressButton = new Panel();
            btnClose = new Button();
            tableLayoutPanel1.SuspendLayout();
            pnlProgressMessage.SuspendLayout();
            pnlProgressBar.SuspendLayout();
            pnlProgressButton.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.Info;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1.910828F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 98.08917F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 612F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 49F));
            tableLayoutPanel1.Controls.Add(pnlProgressMessage, 1, 0);
            tableLayoutPanel1.Controls.Add(pnlProgressBar, 2, 0);
            tableLayoutPanel1.Controls.Add(pnlProgressButton, 3, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1000, 41);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // pnlProgressMessage
            // 
            pnlProgressMessage.Controls.Add(lblMessage);
            pnlProgressMessage.Dock = DockStyle.Fill;
            pnlProgressMessage.Location = new Point(9, 3);
            pnlProgressMessage.Name = "pnlProgressMessage";
            pnlProgressMessage.Size = new Size(326, 35);
            pnlProgressMessage.TabIndex = 4;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(0, 7);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(50, 20);
            lblMessage.TabIndex = 3;
            lblMessage.Text = "label1";
            // 
            // pnlProgressBar
            // 
            pnlProgressBar.Controls.Add(progressBar);
            pnlProgressBar.Location = new Point(341, 3);
            pnlProgressBar.Name = "pnlProgressBar";
            pnlProgressBar.Size = new Size(606, 35);
            pnlProgressBar.TabIndex = 5;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(3, 10);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(603, 15);
            progressBar.TabIndex = 0;
            // 
            // pnlProgressButton
            // 
            pnlProgressButton.Controls.Add(btnClose);
            pnlProgressButton.Location = new Point(953, 3);
            pnlProgressButton.Name = "pnlProgressButton";
            pnlProgressButton.Size = new Size(38, 35);
            pnlProgressButton.TabIndex = 6;
            // 
            // btnClose
            // 
            btnClose.Image = Properties.Resources.close;
            btnClose.Location = new Point(6, 7);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(20, 20);
            btnClose.TabIndex = 2;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // ProgressBarUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "ProgressBarUserControl";
            Size = new Size(1000, 41);
            tableLayoutPanel1.ResumeLayout(false);
            pnlProgressMessage.ResumeLayout(false);
            pnlProgressMessage.PerformLayout();
            pnlProgressBar.ResumeLayout(false);
            pnlProgressButton.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel pnlProgressMessage;
        private Label lblMessage;
        private Button btnClose;
        private ProgressBar progressBar;
        private Panel pnlProgressBar;
        private Panel pnlProgressButton;
    }
}
