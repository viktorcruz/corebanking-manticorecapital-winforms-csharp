namespace ManticoreCapital.Presentation.Forms
{
    partial class UsersFrm
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
            tlpUsers = new TableLayoutPanel();
            pnlUsersFrmTop = new Panel();
            btnReload = new Button();
            lblCurrentRegisters = new Label();
            txtId = new TextBox();
            btnSearch = new Button();
            txtSearch = new TextBox();
            lblTotalCount = new Label();
            lblSearch = new Label();
            btnDelete = new Button();
            lblUserId = new Label();
            btnCreate = new Button();
            btnEdit = new Button();
            pnlUsersFrmBottom = new Panel();
            lblPage = new Label();
            btnPrevious = new Button();
            btnNext = new Button();
            pnlUsersFrmGrid = new Panel();
            dgvUsers = new DataGridView();
            tlpUserFrmInsert = new TableLayoutPanel();
            pnlUsersFrmInsertBottom = new Panel();
            btnSave = new Button();
            btnBack = new Button();
            pnlUsersFrmInsertBody = new Panel();
            pbxCreateQrCode = new PictureBox();
            txtCreateLastName = new TextBox();
            lblLastName = new Label();
            ckbCreateActive = new CheckBox();
            cbxCreateRole = new ComboBox();
            lblCurrentDate = new Label();
            lblInsertDate = new Label();
            txtCreateEmail = new TextBox();
            txtCreateName = new TextBox();
            lblInsertName = new Label();
            lblInsertRole = new Label();
            lblInsertEmail = new Label();
            lblNewId = new Label();
            txtNewId = new TextBox();
            tlpUserFrmEdit = new TableLayoutPanel();
            panel1 = new Panel();
            btnEditSave = new Button();
            btnEditBack = new Button();
            panel2 = new Panel();
            txtEditRFC = new TextBox();
            lblEditRFC = new Label();
            pbxEditQrCode = new PictureBox();
            txtEditLastName = new TextBox();
            label1 = new Label();
            ckbEditActive = new CheckBox();
            cbxEditRole = new ComboBox();
            lblEditCurrentDate = new Label();
            label3 = new Label();
            txtEditEmail = new TextBox();
            txtEditName = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtEditId = new TextBox();
            txtNewRFC = new TextBox();
            lblNewRFC = new Label();
            tlpUsers.SuspendLayout();
            pnlUsersFrmTop.SuspendLayout();
            pnlUsersFrmBottom.SuspendLayout();
            pnlUsersFrmGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            tlpUserFrmInsert.SuspendLayout();
            pnlUsersFrmInsertBottom.SuspendLayout();
            pnlUsersFrmInsertBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxCreateQrCode).BeginInit();
            tlpUserFrmEdit.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxEditQrCode).BeginInit();
            SuspendLayout();
            // 
            // tlpUsers
            // 
            tlpUsers.ColumnCount = 1;
            tlpUsers.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpUsers.Controls.Add(pnlUsersFrmTop, 0, 0);
            tlpUsers.Controls.Add(pnlUsersFrmBottom, 0, 3);
            tlpUsers.Controls.Add(pnlUsersFrmGrid, 0, 2);
            tlpUsers.Location = new Point(15, 12);
            tlpUsers.Name = "tlpUsers";
            tlpUsers.RowCount = 4;
            tlpUsers.RowStyles.Add(new RowStyle(SizeType.Percent, 72.72727F));
            tlpUsers.RowStyles.Add(new RowStyle(SizeType.Percent, 27.272728F));
            tlpUsers.RowStyles.Add(new RowStyle(SizeType.Absolute, 440F));
            tlpUsers.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            tlpUsers.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpUsers.Size = new Size(1055, 603);
            tlpUsers.TabIndex = 1;
            // 
            // pnlUsersFrmTop
            // 
            pnlUsersFrmTop.Controls.Add(btnReload);
            pnlUsersFrmTop.Controls.Add(lblCurrentRegisters);
            pnlUsersFrmTop.Controls.Add(txtId);
            pnlUsersFrmTop.Controls.Add(btnSearch);
            pnlUsersFrmTop.Controls.Add(txtSearch);
            pnlUsersFrmTop.Controls.Add(lblTotalCount);
            pnlUsersFrmTop.Controls.Add(lblSearch);
            pnlUsersFrmTop.Controls.Add(btnDelete);
            pnlUsersFrmTop.Controls.Add(lblUserId);
            pnlUsersFrmTop.Controls.Add(btnCreate);
            pnlUsersFrmTop.Controls.Add(btnEdit);
            pnlUsersFrmTop.Dock = DockStyle.Fill;
            pnlUsersFrmTop.Location = new Point(3, 3);
            pnlUsersFrmTop.Name = "pnlUsersFrmTop";
            pnlUsersFrmTop.Size = new Size(1049, 74);
            pnlUsersFrmTop.TabIndex = 6;
            // 
            // btnReload
            // 
            btnReload.Font = new Font("Noto Sans", 10.2F);
            btnReload.Image = Properties.Resources.reload;
            btnReload.Location = new Point(918, 58);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(96, 31);
            btnReload.TabIndex = 6;
            btnReload.UseVisualStyleBackColor = true;
            btnReload.Click += btnReload_Click;
            // 
            // lblCurrentRegisters
            // 
            lblCurrentRegisters.AutoSize = true;
            lblCurrentRegisters.Font = new Font("Segoe UI", 10.2F);
            lblCurrentRegisters.Location = new Point(247, 61);
            lblCurrentRegisters.Name = "lblCurrentRegisters";
            lblCurrentRegisters.Size = new Size(78, 23);
            lblCurrentRegisters.TabIndex = 8;
            lblCurrentRegisters.Text = "Registers";
            // 
            // txtId
            // 
            txtId.Font = new Font("Noto Sans", 10.2F);
            txtId.Location = new Point(72, 9);
            txtId.Name = "txtId";
            txtId.Size = new Size(370, 31);
            txtId.TabIndex = 20;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Noto Sans", 10.2F);
            btnSearch.Image = Properties.Resources.search;
            btnSearch.Location = new Point(918, 9);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(96, 31);
            btnSearch.TabIndex = 2;
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Noto Sans", 10.2F);
            txtSearch.Location = new Point(542, 11);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(370, 31);
            txtSearch.TabIndex = 1;
            txtSearch.KeyPress += txtSearch_KeyPress;
            // 
            // lblTotalCount
            // 
            lblTotalCount.AutoSize = true;
            lblTotalCount.Font = new Font("Segoe UI", 10.2F);
            lblTotalCount.Location = new Point(5, 61);
            lblTotalCount.Name = "lblTotalCount";
            lblTotalCount.Size = new Size(46, 23);
            lblTotalCount.TabIndex = 12;
            lblTotalCount.Text = "Total";
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 10.2F);
            lblSearch.Location = new Point(475, 13);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(61, 23);
            lblSearch.TabIndex = 17;
            lblSearch.Text = "Search";
            // 
            // btnDelete
            // 
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.Image = Properties.Resources.delete;
            btnDelete.ImageAlign = ContentAlignment.MiddleLeft;
            btnDelete.Location = new Point(792, 58);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(96, 31);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "    Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // lblUserId
            // 
            lblUserId.AutoSize = true;
            lblUserId.Font = new Font("Segoe UI", 10.2F);
            lblUserId.Location = new Point(4, 15);
            lblUserId.Name = "lblUserId";
            lblUserId.Size = new Size(25, 23);
            lblUserId.TabIndex = 15;
            lblUserId.Text = "Id";
            // 
            // btnCreate
            // 
            btnCreate.Image = Properties.Resources._new;
            btnCreate.ImageAlign = ContentAlignment.MiddleLeft;
            btnCreate.Location = new Point(539, 58);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(96, 31);
            btnCreate.TabIndex = 3;
            btnCreate.Text = "   Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnEdit
            // 
            btnEdit.Image = Properties.Resources.edit;
            btnEdit.ImageAlign = ContentAlignment.MiddleLeft;
            btnEdit.Location = new Point(666, 58);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(96, 31);
            btnEdit.TabIndex = 4;
            btnEdit.Text = "   Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // pnlUsersFrmBottom
            // 
            pnlUsersFrmBottom.Controls.Add(lblPage);
            pnlUsersFrmBottom.Controls.Add(btnPrevious);
            pnlUsersFrmBottom.Controls.Add(btnNext);
            pnlUsersFrmBottom.Dock = DockStyle.Fill;
            pnlUsersFrmBottom.Location = new Point(3, 553);
            pnlUsersFrmBottom.Name = "pnlUsersFrmBottom";
            pnlUsersFrmBottom.Size = new Size(1049, 47);
            pnlUsersFrmBottom.TabIndex = 4;
            // 
            // lblPage
            // 
            lblPage.AutoSize = true;
            lblPage.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPage.Location = new Point(4, 11);
            lblPage.Name = "lblPage";
            lblPage.Size = new Size(47, 23);
            lblPage.TabIndex = 7;
            lblPage.Text = "Page";
            // 
            // btnPrevious
            // 
            btnPrevious.Image = Properties.Resources.left;
            btnPrevious.Location = new Point(789, 3);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(99, 36);
            btnPrevious.TabIndex = 2;
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnNext
            // 
            btnNext.Image = Properties.Resources.right;
            btnNext.Location = new Point(911, 0);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(99, 39);
            btnNext.TabIndex = 0;
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // pnlUsersFrmGrid
            // 
            pnlUsersFrmGrid.Controls.Add(dgvUsers);
            pnlUsersFrmGrid.Dock = DockStyle.Fill;
            pnlUsersFrmGrid.Location = new Point(3, 113);
            pnlUsersFrmGrid.Name = "pnlUsersFrmGrid";
            pnlUsersFrmGrid.Size = new Size(1049, 434);
            pnlUsersFrmGrid.TabIndex = 5;
            // 
            // dgvUsers
            // 
            dgvUsers.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Dock = DockStyle.Fill;
            dgvUsers.Location = new Point(0, 0);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.ReadOnly = true;
            dgvUsers.RowHeadersWidth = 51;
            dgvUsers.Size = new Size(1049, 434);
            dgvUsers.TabIndex = 2;
            dgvUsers.CellClick += dgUsers_CellClick;
            dgvUsers.CellDoubleClick += dgvUsers_CellDoubleClick;
            dgvUsers.RowPrePaint += dgvUsers_RowPrePaint;
            // 
            // tlpUserFrmInsert
            // 
            tlpUserFrmInsert.ColumnCount = 1;
            tlpUserFrmInsert.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpUserFrmInsert.Controls.Add(pnlUsersFrmInsertBottom, 0, 2);
            tlpUserFrmInsert.Controls.Add(pnlUsersFrmInsertBody, 0, 1);
            tlpUserFrmInsert.Location = new Point(12, 104);
            tlpUserFrmInsert.Name = "tlpUserFrmInsert";
            tlpUserFrmInsert.RowCount = 3;
            tlpUserFrmInsert.RowStyles.Add(new RowStyle(SizeType.Percent, 5.381166F));
            tlpUserFrmInsert.RowStyles.Add(new RowStyle(SizeType.Percent, 94.6188354F));
            tlpUserFrmInsert.RowStyles.Add(new RowStyle(SizeType.Absolute, 61F));
            tlpUserFrmInsert.Size = new Size(1055, 603);
            tlpUserFrmInsert.TabIndex = 2;
            // 
            // pnlUsersFrmInsertBottom
            // 
            pnlUsersFrmInsertBottom.Controls.Add(btnSave);
            pnlUsersFrmInsertBottom.Controls.Add(btnBack);
            pnlUsersFrmInsertBottom.Dock = DockStyle.Fill;
            pnlUsersFrmInsertBottom.Location = new Point(3, 544);
            pnlUsersFrmInsertBottom.Name = "pnlUsersFrmInsertBottom";
            pnlUsersFrmInsertBottom.Size = new Size(1049, 56);
            pnlUsersFrmInsertBottom.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.Image = Properties.Resources.save;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(792, 9);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(99, 39);
            btnSave.TabIndex = 4;
            btnSave.Text = "   Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnBack
            // 
            btnBack.Image = Properties.Resources.left;
            btnBack.Location = new Point(914, 9);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(99, 39);
            btnBack.TabIndex = 3;
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // pnlUsersFrmInsertBody
            // 
            pnlUsersFrmInsertBody.Controls.Add(txtNewRFC);
            pnlUsersFrmInsertBody.Controls.Add(lblNewRFC);
            pnlUsersFrmInsertBody.Controls.Add(pbxCreateQrCode);
            pnlUsersFrmInsertBody.Controls.Add(txtCreateLastName);
            pnlUsersFrmInsertBody.Controls.Add(lblLastName);
            pnlUsersFrmInsertBody.Controls.Add(ckbCreateActive);
            pnlUsersFrmInsertBody.Controls.Add(cbxCreateRole);
            pnlUsersFrmInsertBody.Controls.Add(lblCurrentDate);
            pnlUsersFrmInsertBody.Controls.Add(lblInsertDate);
            pnlUsersFrmInsertBody.Controls.Add(txtCreateEmail);
            pnlUsersFrmInsertBody.Controls.Add(txtCreateName);
            pnlUsersFrmInsertBody.Controls.Add(lblInsertName);
            pnlUsersFrmInsertBody.Controls.Add(lblInsertRole);
            pnlUsersFrmInsertBody.Controls.Add(lblInsertEmail);
            pnlUsersFrmInsertBody.Controls.Add(lblNewId);
            pnlUsersFrmInsertBody.Controls.Add(txtNewId);
            pnlUsersFrmInsertBody.Dock = DockStyle.Fill;
            pnlUsersFrmInsertBody.Location = new Point(3, 32);
            pnlUsersFrmInsertBody.Name = "pnlUsersFrmInsertBody";
            pnlUsersFrmInsertBody.Size = new Size(1049, 506);
            pnlUsersFrmInsertBody.TabIndex = 1;
            // 
            // pbxCreateQrCode
            // 
            pbxCreateQrCode.Location = new Point(656, 71);
            pbxCreateQrCode.Name = "pbxCreateQrCode";
            pbxCreateQrCode.Size = new Size(361, 335);
            pbxCreateQrCode.TabIndex = 42;
            pbxCreateQrCode.TabStop = false;
            // 
            // txtCreateLastName
            // 
            txtCreateLastName.Font = new Font("Noto Sans", 10.2F);
            txtCreateLastName.Location = new Point(133, 131);
            txtCreateLastName.Name = "txtCreateLastName";
            txtCreateLastName.Size = new Size(473, 31);
            txtCreateLastName.TabIndex = 41;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Noto Sans", 10.2F);
            lblLastName.Location = new Point(21, 136);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(98, 26);
            lblLastName.TabIndex = 40;
            lblLastName.Text = "Last Name";
            // 
            // ckbCreateActive
            // 
            ckbCreateActive.AutoSize = true;
            ckbCreateActive.Location = new Point(423, 312);
            ckbCreateActive.Name = "ckbCreateActive";
            ckbCreateActive.Size = new Size(72, 24);
            ckbCreateActive.TabIndex = 39;
            ckbCreateActive.Text = "Active";
            ckbCreateActive.UseVisualStyleBackColor = true;
            // 
            // cbxCreateRole
            // 
            cbxCreateRole.FormattingEnabled = true;
            cbxCreateRole.Location = new Point(133, 310);
            cbxCreateRole.Name = "cbxCreateRole";
            cbxCreateRole.Size = new Size(205, 28);
            cbxCreateRole.TabIndex = 38;
            // 
            // lblCurrentDate
            // 
            lblCurrentDate.AutoSize = true;
            lblCurrentDate.Font = new Font("Noto Sans", 10.2F);
            lblCurrentDate.Location = new Point(778, 23);
            lblCurrentDate.Name = "lblCurrentDate";
            lblCurrentDate.Size = new Size(54, 26);
            lblCurrentDate.TabIndex = 37;
            lblCurrentDate.Text = "--/--/--";
            // 
            // lblInsertDate
            // 
            lblInsertDate.AutoSize = true;
            lblInsertDate.Font = new Font("Noto Sans", 10.2F);
            lblInsertDate.Location = new Point(722, 23);
            lblInsertDate.Name = "lblInsertDate";
            lblInsertDate.Size = new Size(50, 26);
            lblInsertDate.TabIndex = 36;
            lblInsertDate.Text = "Date";
            // 
            // txtCreateEmail
            // 
            txtCreateEmail.Font = new Font("Noto Sans", 10.2F);
            txtCreateEmail.Location = new Point(133, 256);
            txtCreateEmail.Name = "txtCreateEmail";
            txtCreateEmail.Size = new Size(473, 31);
            txtCreateEmail.TabIndex = 34;
            // 
            // txtCreateName
            // 
            txtCreateName.Font = new Font("Noto Sans", 10.2F);
            txtCreateName.Location = new Point(133, 76);
            txtCreateName.Name = "txtCreateName";
            txtCreateName.Size = new Size(473, 31);
            txtCreateName.TabIndex = 33;
            // 
            // lblInsertName
            // 
            lblInsertName.AutoSize = true;
            lblInsertName.Font = new Font("Noto Sans", 10.2F);
            lblInsertName.Location = new Point(21, 81);
            lblInsertName.Name = "lblInsertName";
            lblInsertName.Size = new Size(61, 26);
            lblInsertName.TabIndex = 30;
            lblInsertName.Text = "Name";
            // 
            // lblInsertRole
            // 
            lblInsertRole.AutoSize = true;
            lblInsertRole.Font = new Font("Noto Sans", 10.2F);
            lblInsertRole.Location = new Point(21, 314);
            lblInsertRole.Name = "lblInsertRole";
            lblInsertRole.Size = new Size(47, 26);
            lblInsertRole.TabIndex = 32;
            lblInsertRole.Text = "Role";
            // 
            // lblInsertEmail
            // 
            lblInsertEmail.AutoSize = true;
            lblInsertEmail.Font = new Font("Noto Sans", 10.2F);
            lblInsertEmail.Location = new Point(21, 260);
            lblInsertEmail.Name = "lblInsertEmail";
            lblInsertEmail.Size = new Size(55, 26);
            lblInsertEmail.TabIndex = 31;
            lblInsertEmail.Text = "Email";
            // 
            // lblNewId
            // 
            lblNewId.AutoSize = true;
            lblNewId.Font = new Font("Noto Sans", 10.2F);
            lblNewId.Location = new Point(24, 25);
            lblNewId.Name = "lblNewId";
            lblNewId.Size = new Size(30, 26);
            lblNewId.TabIndex = 28;
            lblNewId.Text = "ID";
            // 
            // txtNewId
            // 
            txtNewId.Font = new Font("Noto Sans", 10.2F);
            txtNewId.Location = new Point(133, 23);
            txtNewId.Name = "txtNewId";
            txtNewId.Size = new Size(560, 31);
            txtNewId.TabIndex = 27;
            // 
            // tlpUserFrmEdit
            // 
            tlpUserFrmEdit.ColumnCount = 1;
            tlpUserFrmEdit.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpUserFrmEdit.Controls.Add(panel1, 0, 2);
            tlpUserFrmEdit.Controls.Add(panel2, 0, 1);
            tlpUserFrmEdit.Location = new Point(46, 54);
            tlpUserFrmEdit.Name = "tlpUserFrmEdit";
            tlpUserFrmEdit.RowCount = 3;
            tlpUserFrmEdit.RowStyles.Add(new RowStyle(SizeType.Percent, 5.381166F));
            tlpUserFrmEdit.RowStyles.Add(new RowStyle(SizeType.Percent, 94.6188354F));
            tlpUserFrmEdit.RowStyles.Add(new RowStyle(SizeType.Absolute, 61F));
            tlpUserFrmEdit.Size = new Size(1055, 603);
            tlpUserFrmEdit.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnEditSave);
            panel1.Controls.Add(btnEditBack);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 544);
            panel1.Name = "panel1";
            panel1.Size = new Size(1049, 56);
            panel1.TabIndex = 0;
            // 
            // btnEditSave
            // 
            btnEditSave.Image = Properties.Resources.save;
            btnEditSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditSave.Location = new Point(792, 9);
            btnEditSave.Name = "btnEditSave";
            btnEditSave.Size = new Size(99, 39);
            btnEditSave.TabIndex = 4;
            btnEditSave.Text = "   Save";
            btnEditSave.UseVisualStyleBackColor = true;
            btnEditSave.Click += btnEditSave_Click;
            // 
            // btnEditBack
            // 
            btnEditBack.Image = Properties.Resources.left;
            btnEditBack.Location = new Point(914, 9);
            btnEditBack.Name = "btnEditBack";
            btnEditBack.Size = new Size(99, 39);
            btnEditBack.TabIndex = 3;
            btnEditBack.UseVisualStyleBackColor = true;
            btnEditBack.Click += btnEditBack_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtEditRFC);
            panel2.Controls.Add(lblEditRFC);
            panel2.Controls.Add(pbxEditQrCode);
            panel2.Controls.Add(txtEditLastName);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(ckbEditActive);
            panel2.Controls.Add(cbxEditRole);
            panel2.Controls.Add(lblEditCurrentDate);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtEditEmail);
            panel2.Controls.Add(txtEditName);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(txtEditId);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 32);
            panel2.Name = "panel2";
            panel2.Size = new Size(1049, 506);
            panel2.TabIndex = 1;
            // 
            // txtEditRFC
            // 
            txtEditRFC.Font = new Font("Noto Sans", 10.2F);
            txtEditRFC.Location = new Point(133, 193);
            txtEditRFC.Name = "txtEditRFC";
            txtEditRFC.Size = new Size(473, 31);
            txtEditRFC.TabIndex = 43;
            // 
            // lblEditRFC
            // 
            lblEditRFC.AutoSize = true;
            lblEditRFC.Font = new Font("Noto Sans", 10.2F);
            lblEditRFC.Location = new Point(21, 198);
            lblEditRFC.Name = "lblEditRFC";
            lblEditRFC.Size = new Size(43, 26);
            lblEditRFC.TabIndex = 44;
            lblEditRFC.Text = "RFC";
            // 
            // pbxEditQrCode
            // 
            pbxEditQrCode.Location = new Point(656, 71);
            pbxEditQrCode.Name = "pbxEditQrCode";
            pbxEditQrCode.Size = new Size(361, 335);
            pbxEditQrCode.TabIndex = 42;
            pbxEditQrCode.TabStop = false;
            // 
            // txtEditLastName
            // 
            txtEditLastName.Font = new Font("Noto Sans", 10.2F);
            txtEditLastName.Location = new Point(133, 131);
            txtEditLastName.Name = "txtEditLastName";
            txtEditLastName.Size = new Size(473, 31);
            txtEditLastName.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Noto Sans", 10.2F);
            label1.Location = new Point(21, 136);
            label1.Name = "label1";
            label1.Size = new Size(98, 26);
            label1.TabIndex = 40;
            label1.Text = "Last Name";
            // 
            // ckbEditActive
            // 
            ckbEditActive.AutoSize = true;
            ckbEditActive.Location = new Point(423, 313);
            ckbEditActive.Name = "ckbEditActive";
            ckbEditActive.Size = new Size(72, 24);
            ckbEditActive.TabIndex = 5;
            ckbEditActive.Text = "Active";
            ckbEditActive.UseVisualStyleBackColor = true;
            // 
            // cbxEditRole
            // 
            cbxEditRole.FormattingEnabled = true;
            cbxEditRole.Location = new Point(133, 311);
            cbxEditRole.Name = "cbxEditRole";
            cbxEditRole.Size = new Size(205, 28);
            cbxEditRole.TabIndex = 4;
            // 
            // lblEditCurrentDate
            // 
            lblEditCurrentDate.AutoSize = true;
            lblEditCurrentDate.Font = new Font("Noto Sans", 10.2F);
            lblEditCurrentDate.Location = new Point(778, 23);
            lblEditCurrentDate.Name = "lblEditCurrentDate";
            lblEditCurrentDate.Size = new Size(54, 26);
            lblEditCurrentDate.TabIndex = 37;
            lblEditCurrentDate.Text = "--/--/--";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Noto Sans", 10.2F);
            label3.Location = new Point(722, 23);
            label3.Name = "label3";
            label3.Size = new Size(50, 26);
            label3.TabIndex = 36;
            label3.Text = "Date";
            // 
            // txtEditEmail
            // 
            txtEditEmail.Font = new Font("Noto Sans", 10.2F);
            txtEditEmail.Location = new Point(133, 257);
            txtEditEmail.Name = "txtEditEmail";
            txtEditEmail.Size = new Size(473, 31);
            txtEditEmail.TabIndex = 3;
            // 
            // txtEditName
            // 
            txtEditName.Font = new Font("Noto Sans", 10.2F);
            txtEditName.Location = new Point(133, 76);
            txtEditName.Name = "txtEditName";
            txtEditName.Size = new Size(473, 31);
            txtEditName.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Noto Sans", 10.2F);
            label4.Location = new Point(21, 81);
            label4.Name = "label4";
            label4.Size = new Size(61, 26);
            label4.TabIndex = 30;
            label4.Text = "Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Noto Sans", 10.2F);
            label5.Location = new Point(21, 315);
            label5.Name = "label5";
            label5.Size = new Size(47, 26);
            label5.TabIndex = 32;
            label5.Text = "Role";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Noto Sans", 10.2F);
            label6.Location = new Point(21, 261);
            label6.Name = "label6";
            label6.Size = new Size(55, 26);
            label6.TabIndex = 31;
            label6.Text = "Email";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Noto Sans", 10.2F);
            label7.Location = new Point(24, 25);
            label7.Name = "label7";
            label7.Size = new Size(30, 26);
            label7.TabIndex = 28;
            label7.Text = "ID";
            // 
            // txtEditId
            // 
            txtEditId.Font = new Font("Noto Sans", 10.2F);
            txtEditId.Location = new Point(133, 23);
            txtEditId.Name = "txtEditId";
            txtEditId.Size = new Size(560, 31);
            txtEditId.TabIndex = 27;
            // 
            // txtNewRFC
            // 
            txtNewRFC.Font = new Font("Noto Sans", 10.2F);
            txtNewRFC.Location = new Point(133, 194);
            txtNewRFC.Name = "txtNewRFC";
            txtNewRFC.Size = new Size(473, 31);
            txtNewRFC.TabIndex = 45;
            // 
            // lblNewRFC
            // 
            lblNewRFC.AutoSize = true;
            lblNewRFC.Font = new Font("Noto Sans", 10.2F);
            lblNewRFC.Location = new Point(21, 199);
            lblNewRFC.Name = "lblNewRFC";
            lblNewRFC.Size = new Size(43, 26);
            lblNewRFC.TabIndex = 46;
            lblNewRFC.Text = "RFC";
            // 
            // UsersFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1147, 710);
            Controls.Add(tlpUserFrmInsert);
            Controls.Add(tlpUsers);
            Controls.Add(tlpUserFrmEdit);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "UsersFrm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UsersFrm";
            Load += UsersFrm_Load;
            tlpUsers.ResumeLayout(false);
            pnlUsersFrmTop.ResumeLayout(false);
            pnlUsersFrmTop.PerformLayout();
            pnlUsersFrmBottom.ResumeLayout(false);
            pnlUsersFrmBottom.PerformLayout();
            pnlUsersFrmGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            tlpUserFrmInsert.ResumeLayout(false);
            pnlUsersFrmInsertBottom.ResumeLayout(false);
            pnlUsersFrmInsertBody.ResumeLayout(false);
            pnlUsersFrmInsertBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxCreateQrCode).EndInit();
            tlpUserFrmEdit.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxEditQrCode).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tlpUsers;
        private Label lblTotalCount;
        private Label lblCurrentRegisters;
        private Label lblPage;
        private TableLayoutPanel tlpUserFrmInsert;
        private Panel pnlUsersFrmInsertBottom;
        private Panel pnlUsersFrmInsertBody;
        private Label lblInsertDate;
        private TextBox txtCreateEmail;
        private TextBox txtCreateName;
        private Label lblInsertName;
        private Label lblInsertRole;
        private Label lblInsertEmail;
        private Label lblNewId;
        private TextBox txtNewId;
        private CheckBox ckbCreateActive;
        private ComboBox cbxCreateRole;
        private Label lblCurrentDate;
        private Panel pnlUsersFrmBottom;
        private Button btnPrevious;
        private Button btnNext;
        private Panel pnlUsersFrmGrid;
        private DataGridView dgvUsers;
        private Button btnCreate;
        private Button btnEdit;
        private Panel pnlUsersFrmTop;
        private Label lblUserId;
        private Button btnDelete;
        private Button btnBack;
        private TextBox txtCreateLastName;
        private Label lblLastName;
        private PictureBox pbxCreateQrCode;
        private Button btnSave;
        private TableLayoutPanel tlpUserFrmEdit;
        private Panel panel1;
        private Button btnEditSave;
        private Button btnEditBack;
        private Panel panel2;
        private PictureBox pbxEditQrCode;
        private TextBox txtEditLastName;
        private Label label1;
        private CheckBox ckbEditActive;
        private ComboBox cbxEditRole;
        private Label lblEditCurrentDate;
        private Label label3;
        private TextBox txtEditEmail;
        private TextBox txtEditName;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtEditId;
        private Button btnSearch;
        private TextBox txtSearch;
        private Label lblSearch;
        private TextBox txtId;
        private Button btnReload;
        private TextBox txtEditRFC;
        private Label lblEditRFC;
        private TextBox txtNewRFC;
        private Label lblNewRFC;
    }
}