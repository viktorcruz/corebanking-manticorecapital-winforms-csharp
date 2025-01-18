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
            usersToolStripMenuItem = new ToolStripMenuItem();
            mnStrip.SuspendLayout();
            SuspendLayout();
            // 
            // mnStrip
            // 
            mnStrip.ImageScalingSize = new Size(20, 20);
            mnStrip.Items.AddRange(new ToolStripItem[] { formsToolStripMenuItem });
            mnStrip.Location = new Point(0, 0);
            mnStrip.Name = "mnStrip";
            mnStrip.Size = new Size(1051, 28);
            mnStrip.TabIndex = 1;
            mnStrip.Text = "menuStrip1";
            // 
            // formsToolStripMenuItem
            // 
            formsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { usersToolStripMenuItem });
            formsToolStripMenuItem.Name = "formsToolStripMenuItem";
            formsToolStripMenuItem.Size = new Size(63, 24);
            formsToolStripMenuItem.Text = "Forms";
            // 
            // usersToolStripMenuItem
            // 
            usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            usersToolStripMenuItem.Size = new Size(224, 26);
            usersToolStripMenuItem.Text = "Users";
            usersToolStripMenuItem.Click += usersToolStripMenuItem_Click;
            // 
            // StartupFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1051, 609);
            Controls.Add(mnStrip);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            IsMdiContainer = true;
            MainMenuStrip = mnStrip;
            Name = "StartupFrm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Startup";
            mnStrip.ResumeLayout(false);
            mnStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnStrip;
        private ToolStripMenuItem formsToolStripMenuItem;
        private ToolStripMenuItem usersToolStripMenuItem;
    }
}