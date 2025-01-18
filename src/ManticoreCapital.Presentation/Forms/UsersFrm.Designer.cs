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
            btnClientes = new Button();
            SuspendLayout();
            // 
            // btnClientes
            // 
            btnClientes.Location = new Point(83, 84);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(94, 29);
            btnClientes.TabIndex = 0;
            btnClientes.Text = "button1";
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
            // 
            // UsersFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClientes);
            Name = "UsersFrm";
            Text = "UsersFrm";
            ResumeLayout(false);
        }

        #endregion

        private Button btnClientes;
    }
}