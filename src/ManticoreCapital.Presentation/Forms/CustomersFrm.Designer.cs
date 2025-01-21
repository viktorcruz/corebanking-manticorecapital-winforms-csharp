namespace ManticoreCapital.Presentation.Forms
{
    partial class CustomersFrm
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
            tlpCustomers = new TableLayoutPanel();
            pnlCustomersFrmBottom = new Panel();
            lblUserId = new Label();
            btnPreview = new Button();
            btnNext = new Button();
            pnlCustomersFrmBody = new Panel();
            dgUsers = new DataGridView();
            pnlCustomersFrmTop = new Panel();
            lblTotalCount = new Label();
            txtSearch = new TextBox();
            btnLoad = new Button();
            btnSearch = new Button();
            lblCurrentRegisters = new Label();
            lblPage = new Label();
            tlpCustomers.SuspendLayout();
            pnlCustomersFrmBottom.SuspendLayout();
            pnlCustomersFrmBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgUsers).BeginInit();
            pnlCustomersFrmTop.SuspendLayout();
            SuspendLayout();
            // 
            // tlpCustomers
            // 
            tlpCustomers.ColumnCount = 1;
            tlpCustomers.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpCustomers.Controls.Add(pnlCustomersFrmBottom, 0, 2);
            tlpCustomers.Controls.Add(pnlCustomersFrmBody, 0, 1);
            tlpCustomers.Controls.Add(pnlCustomersFrmTop, 0, 0);
            tlpCustomers.Location = new Point(12, 58);
            tlpCustomers.Name = "tlpCustomers";
            tlpCustomers.RowCount = 3;
            tlpCustomers.RowStyles.Add(new RowStyle(SizeType.Percent, 22.5733643F));
            tlpCustomers.RowStyles.Add(new RowStyle(SizeType.Percent, 77.4266357F));
            tlpCustomers.RowStyles.Add(new RowStyle(SizeType.Absolute, 59F));
            tlpCustomers.Size = new Size(1055, 523);
            tlpCustomers.TabIndex = 2;
            // 
            // pnlCustomersFrmBottom
            // 
            pnlCustomersFrmBottom.Controls.Add(lblUserId);
            pnlCustomersFrmBottom.Controls.Add(btnPreview);
            pnlCustomersFrmBottom.Controls.Add(btnNext);
            pnlCustomersFrmBottom.Dock = DockStyle.Fill;
            pnlCustomersFrmBottom.Location = new Point(3, 466);
            pnlCustomersFrmBottom.Name = "pnlCustomersFrmBottom";
            pnlCustomersFrmBottom.Size = new Size(1049, 54);
            pnlCustomersFrmBottom.TabIndex = 1;
            // 
            // lblUserId
            // 
            lblUserId.AutoSize = true;
            lblUserId.Location = new Point(12, 18);
            lblUserId.Name = "lblUserId";
            lblUserId.Size = new Size(27, 20);
            lblUserId.TabIndex = 8;
            lblUserId.Text = "ID:";
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
            // pnlCustomersFrmBody
            // 
            pnlCustomersFrmBody.Controls.Add(dgUsers);
            pnlCustomersFrmBody.Dock = DockStyle.Fill;
            pnlCustomersFrmBody.Location = new Point(3, 107);
            pnlCustomersFrmBody.Name = "pnlCustomersFrmBody";
            pnlCustomersFrmBody.Size = new Size(1049, 353);
            pnlCustomersFrmBody.TabIndex = 2;
            // 
            // dgUsers
            // 
            dgUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgUsers.Dock = DockStyle.Fill;
            dgUsers.Location = new Point(0, 0);
            dgUsers.Name = "dgUsers";
            dgUsers.RowHeadersWidth = 51;
            dgUsers.Size = new Size(1049, 353);
            dgUsers.TabIndex = 0;
            // 
            // pnlCustomersFrmTop
            // 
            pnlCustomersFrmTop.Controls.Add(lblTotalCount);
            pnlCustomersFrmTop.Controls.Add(txtSearch);
            pnlCustomersFrmTop.Controls.Add(btnLoad);
            pnlCustomersFrmTop.Controls.Add(btnSearch);
            pnlCustomersFrmTop.Controls.Add(lblCurrentRegisters);
            pnlCustomersFrmTop.Controls.Add(lblPage);
            pnlCustomersFrmTop.Dock = DockStyle.Fill;
            pnlCustomersFrmTop.Location = new Point(3, 3);
            pnlCustomersFrmTop.Name = "pnlCustomersFrmTop";
            pnlCustomersFrmTop.Size = new Size(1049, 98);
            pnlCustomersFrmTop.TabIndex = 3;
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
            // CustomersFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1076, 638);
            Controls.Add(tlpCustomers);
            Name = "CustomersFrm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CustomersFrm";
            Load += CustomersFrm_Load;
            tlpCustomers.ResumeLayout(false);
            pnlCustomersFrmBottom.ResumeLayout(false);
            pnlCustomersFrmBottom.PerformLayout();
            pnlCustomersFrmBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgUsers).EndInit();
            pnlCustomersFrmTop.ResumeLayout(false);
            pnlCustomersFrmTop.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpCustomers;
        private Panel pnlCustomersFrmBottom;
        private Label lblUserId;
        private Button btnPreview;
        private Button btnNext;
        private Panel pnlCustomersFrmBody;
        private DataGridView dgUsers;
        private Panel pnlCustomersFrmTop;
        private Label lblTotalCount;
        private TextBox txtSearch;
        private Button btnLoad;
        private Button btnSearch;
        private Label lblCurrentRegisters;
        private Label lblPage;
    }
}