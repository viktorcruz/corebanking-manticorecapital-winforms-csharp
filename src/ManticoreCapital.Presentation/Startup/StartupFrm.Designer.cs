namespace ManticoreCapital.Presentation.Startup
{
    partial class StartupFrm
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
            mnStrip = new MenuStrip();
            formsToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            userManagementToolStripMenuItem = new ToolStripMenuItem();
            usersToolStripMenuItem1 = new ToolStripMenuItem();
            customersToolStripMenuItem = new ToolStripMenuItem();
            accountsToolStripMenuItem = new ToolStripMenuItem();
            customerManagementToolStripMenuItem = new ToolStripMenuItem();
            usersToolStripMenuItem2 = new ToolStripMenuItem();
            customersToolStripMenuItem1 = new ToolStripMenuItem();
            accountsToolStripMenuItem1 = new ToolStripMenuItem();
            accountManagementToolStripMenuItem = new ToolStripMenuItem();
            databaseToolStripMenuItem = new ToolStripMenuItem();
            optionsToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            mnStrip.SuspendLayout();
            SuspendLayout();
            // 
            // mnStrip
            // 
            mnStrip.ImageScalingSize = new Size(20, 20);
            mnStrip.Items.AddRange(new ToolStripItem[] { formsToolStripMenuItem, userManagementToolStripMenuItem, customerManagementToolStripMenuItem, accountManagementToolStripMenuItem, helpToolStripMenuItem });
            mnStrip.Location = new Point(0, 0);
            mnStrip.Name = "mnStrip";
            mnStrip.Size = new Size(1302, 28);
            mnStrip.TabIndex = 1;
            mnStrip.Text = "menuStrip1";
            // 
            // formsToolStripMenuItem
            // 
            formsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            formsToolStripMenuItem.Name = "formsToolStripMenuItem";
            formsToolStripMenuItem.Size = new Size(46, 24);
            formsToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(116, 26);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // userManagementToolStripMenuItem
            // 
            userManagementToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { usersToolStripMenuItem1, customersToolStripMenuItem, accountsToolStripMenuItem });
            userManagementToolStripMenuItem.Name = "userManagementToolStripMenuItem";
            userManagementToolStripMenuItem.Size = new Size(111, 24);
            userManagementToolStripMenuItem.Text = "Management";
            // 
            // usersToolStripMenuItem1
            // 
            usersToolStripMenuItem1.Name = "usersToolStripMenuItem1";
            usersToolStripMenuItem1.Size = new Size(161, 26);
            usersToolStripMenuItem1.Text = "Users";
            usersToolStripMenuItem1.Click += usersToolStripMenuItem1_Click;
            // 
            // customersToolStripMenuItem
            // 
            customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            customersToolStripMenuItem.Size = new Size(161, 26);
            customersToolStripMenuItem.Text = "Customers";
            customersToolStripMenuItem.Click += customersToolStripMenuItem_Click;
            // 
            // accountsToolStripMenuItem
            // 
            accountsToolStripMenuItem.Name = "accountsToolStripMenuItem";
            accountsToolStripMenuItem.Size = new Size(161, 26);
            accountsToolStripMenuItem.Text = "Accounts";
            accountsToolStripMenuItem.Click += accountsToolStripMenuItem_Click;
            // 
            // customerManagementToolStripMenuItem
            // 
            customerManagementToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { usersToolStripMenuItem2, customersToolStripMenuItem1, accountsToolStripMenuItem1 });
            customerManagementToolStripMenuItem.Name = "customerManagementToolStripMenuItem";
            customerManagementToolStripMenuItem.Size = new Size(74, 24);
            customerManagementToolStripMenuItem.Text = "Reports";
            // 
            // usersToolStripMenuItem2
            // 
            usersToolStripMenuItem2.Name = "usersToolStripMenuItem2";
            usersToolStripMenuItem2.Size = new Size(161, 26);
            usersToolStripMenuItem2.Text = "Users";
            // 
            // customersToolStripMenuItem1
            // 
            customersToolStripMenuItem1.Name = "customersToolStripMenuItem1";
            customersToolStripMenuItem1.Size = new Size(161, 26);
            customersToolStripMenuItem1.Text = "Customers";
            // 
            // accountsToolStripMenuItem1
            // 
            accountsToolStripMenuItem1.Name = "accountsToolStripMenuItem1";
            accountsToolStripMenuItem1.Size = new Size(161, 26);
            accountsToolStripMenuItem1.Text = "Accounts";
            // 
            // accountManagementToolStripMenuItem
            // 
            accountManagementToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { databaseToolStripMenuItem, optionsToolStripMenuItem });
            accountManagementToolStripMenuItem.Name = "accountManagementToolStripMenuItem";
            accountManagementToolStripMenuItem.Size = new Size(114, 24);
            accountManagementToolStripMenuItem.Text = "Configuration";
            // 
            // databaseToolStripMenuItem
            // 
            databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            databaseToolStripMenuItem.Size = new Size(161, 26);
            databaseToolStripMenuItem.Text = "Databases";
            // 
            // optionsToolStripMenuItem
            // 
            optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            optionsToolStripMenuItem.Size = new Size(161, 26);
            optionsToolStripMenuItem.Text = "Options";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(55, 24);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(133, 26);
            aboutToolStripMenuItem.Text = "About";
            // 
            // StartupFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1302, 952);
            Controls.Add(mnStrip);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            IsMdiContainer = true;
            MainMenuStrip = mnStrip;
            Name = "StartupFrm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Startup";
            Load += StartupFrm_Load;
            mnStrip.ResumeLayout(false);
            mnStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnStrip;
        private ToolStripMenuItem formsToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem userManagementToolStripMenuItem;
        private ToolStripMenuItem customerManagementToolStripMenuItem;
        private ToolStripMenuItem accountManagementToolStripMenuItem;
        private ToolStripMenuItem usersToolStripMenuItem1;
        private ToolStripMenuItem customersToolStripMenuItem;
        private ToolStripMenuItem accountsToolStripMenuItem;
        private ToolStripMenuItem usersToolStripMenuItem2;
        private ToolStripMenuItem customersToolStripMenuItem1;
        private ToolStripMenuItem accountsToolStripMenuItem1;
        private ToolStripMenuItem databaseToolStripMenuItem;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
    }
}