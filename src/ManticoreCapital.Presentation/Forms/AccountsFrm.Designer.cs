namespace ManticoreCapital.Presentation.Forms
{
    partial class AccountsFrm
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
            tlpAccounts = new TableLayoutPanel();
            pnlAccountsFrmBottom = new Panel();
            lblId = new Label();
            btnPreview = new Button();
            btnNext = new Button();
            pnlAccountsFrmBody = new Panel();
            dgAccounts = new DataGridView();
            pnlAccountsFrmTop = new Panel();
            lblTotalCount = new Label();
            txtSearch = new TextBox();
            btnLoad = new Button();
            btnSearch = new Button();
            lblCurrentRegisters = new Label();
            lblPage = new Label();
            tlpAccounts.SuspendLayout();
            pnlAccountsFrmBottom.SuspendLayout();
            pnlAccountsFrmBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgAccounts).BeginInit();
            pnlAccountsFrmTop.SuspendLayout();
            SuspendLayout();
            // 
            // tlpAccounts
            // 
            tlpAccounts.ColumnCount = 1;
            tlpAccounts.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpAccounts.Controls.Add(pnlAccountsFrmBottom, 0, 2);
            tlpAccounts.Controls.Add(pnlAccountsFrmBody, 0, 1);
            tlpAccounts.Controls.Add(pnlAccountsFrmTop, 0, 0);
            tlpAccounts.Location = new Point(41, 65);
            tlpAccounts.Name = "tlpAccounts";
            tlpAccounts.RowCount = 3;
            tlpAccounts.RowStyles.Add(new RowStyle(SizeType.Percent, 22.5733643F));
            tlpAccounts.RowStyles.Add(new RowStyle(SizeType.Percent, 77.4266357F));
            tlpAccounts.RowStyles.Add(new RowStyle(SizeType.Absolute, 59F));
            tlpAccounts.Size = new Size(1055, 523);
            tlpAccounts.TabIndex = 3;
            // 
            // pnlAccountsFrmBottom
            // 
            pnlAccountsFrmBottom.Controls.Add(lblId);
            pnlAccountsFrmBottom.Controls.Add(btnPreview);
            pnlAccountsFrmBottom.Controls.Add(btnNext);
            pnlAccountsFrmBottom.Dock = DockStyle.Fill;
            pnlAccountsFrmBottom.Location = new Point(3, 466);
            pnlAccountsFrmBottom.Name = "pnlAccountsFrmBottom";
            pnlAccountsFrmBottom.Size = new Size(1049, 54);
            pnlAccountsFrmBottom.TabIndex = 1;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(12, 18);
            lblId.Name = "lblId";
            lblId.Size = new Size(27, 20);
            lblId.TabIndex = 8;
            lblId.Text = "ID:";
            // 
            // btnPreview
            // 
            btnPreview.Location = new Point(836, 9);
            btnPreview.Name = "btnPreview";
            btnPreview.Size = new Size(99, 38);
            btnPreview.TabIndex = 2;
            btnPreview.Text = "Preview";
            btnPreview.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(941, 9);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(99, 38);
            btnNext.TabIndex = 0;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            // 
            // pnlAccountsFrmBody
            // 
            pnlAccountsFrmBody.Controls.Add(dgAccounts);
            pnlAccountsFrmBody.Dock = DockStyle.Fill;
            pnlAccountsFrmBody.Location = new Point(3, 107);
            pnlAccountsFrmBody.Name = "pnlAccountsFrmBody";
            pnlAccountsFrmBody.Size = new Size(1049, 353);
            pnlAccountsFrmBody.TabIndex = 2;
            // 
            // dgAccounts
            // 
            dgAccounts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgAccounts.Dock = DockStyle.Fill;
            dgAccounts.Location = new Point(0, 0);
            dgAccounts.Name = "dgAccounts";
            dgAccounts.RowHeadersWidth = 51;
            dgAccounts.Size = new Size(1049, 353);
            dgAccounts.TabIndex = 0;
            // 
            // pnlAccountsFrmTop
            // 
            pnlAccountsFrmTop.Controls.Add(lblTotalCount);
            pnlAccountsFrmTop.Controls.Add(txtSearch);
            pnlAccountsFrmTop.Controls.Add(btnLoad);
            pnlAccountsFrmTop.Controls.Add(btnSearch);
            pnlAccountsFrmTop.Controls.Add(lblCurrentRegisters);
            pnlAccountsFrmTop.Controls.Add(lblPage);
            pnlAccountsFrmTop.Dock = DockStyle.Fill;
            pnlAccountsFrmTop.Location = new Point(3, 3);
            pnlAccountsFrmTop.Name = "pnlAccountsFrmTop";
            pnlAccountsFrmTop.Size = new Size(1049, 98);
            pnlAccountsFrmTop.TabIndex = 3;
            // 
            // lblTotalCount
            // 
            lblTotalCount.AutoSize = true;
            lblTotalCount.Location = new Point(221, 59);
            lblTotalCount.Name = "lblTotalCount";
            lblTotalCount.Size = new Size(48, 20);
            lblTotalCount.TabIndex = 12;
            lblTotalCount.Text = "Count";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(610, 54);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(419, 27);
            txtSearch.TabIndex = 11;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(930, 9);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(99, 38);
            btnLoad.TabIndex = 10;
            btnLoad.Text = "R";
            btnLoad.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(825, 9);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(99, 38);
            btnSearch.TabIndex = 9;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // lblCurrentRegisters
            // 
            lblCurrentRegisters.AutoSize = true;
            lblCurrentRegisters.Location = new Point(12, 59);
            lblCurrentRegisters.Name = "lblCurrentRegisters";
            lblCurrentRegisters.Size = new Size(69, 20);
            lblCurrentRegisters.TabIndex = 8;
            lblCurrentRegisters.Text = "Registers";
            // 
            // lblPage
            // 
            lblPage.AutoSize = true;
            lblPage.Location = new Point(12, 20);
            lblPage.Name = "lblPage";
            lblPage.Size = new Size(41, 20);
            lblPage.TabIndex = 7;
            lblPage.Text = "Page";
            // 
            // AccountsFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1137, 652);
            Controls.Add(tlpAccounts);
            Name = "AccountsFrm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AccountsFrm";
            Load += AccountsFrm_Load;
            tlpAccounts.ResumeLayout(false);
            pnlAccountsFrmBottom.ResumeLayout(false);
            pnlAccountsFrmBottom.PerformLayout();
            pnlAccountsFrmBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgAccounts).EndInit();
            pnlAccountsFrmTop.ResumeLayout(false);
            pnlAccountsFrmTop.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpAccounts;
        private Panel pnlAccountsFrmBottom;
        private Label lblId;
        private Button btnPreview;
        private Button btnNext;
        private Panel pnlAccountsFrmBody;
        private DataGridView dgAccounts;
        private Panel pnlAccountsFrmTop;
        private Label lblTotalCount;
        private TextBox txtSearch;
        private Button btnLoad;
        private Button btnSearch;
        private Label lblCurrentRegisters;
        private Label lblPage;
    }
}