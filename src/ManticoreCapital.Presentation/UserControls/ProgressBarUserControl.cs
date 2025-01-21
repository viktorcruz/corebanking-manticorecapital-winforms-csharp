namespace ManticoreCapital.Presentation.UserControls
{
    public partial class ProgressBarUserControl : UserControl
    {
        public event EventHandler CancelRequested;

        public ProgressBarUserControl()
        {
            InitializeComponent();

            progressBar.Style = ProgressBarStyle.Marquee;
            this.Width = 1000;
            this.Height = 45;
        }

        public int Progress
        {
            get => progressBar.Value;
            set
            {
                if (value >= progressBar.Minimum && value <= progressBar.Maximum)
                {
                    progressBar.Value = value;
                }
            }
        }

        public string Message
        {
            get => lblMessage.Text;
            set => lblMessage.Text = value;
        }

        public void Show(string message = "Processing...")
        {
            this.Visible = true;
            lblMessage.Text = message;
            progressBar.Value = 0;
        }

        public void Hide()
        {
            this.Visible = false;
        }

        public void Reset()
        {
            lblMessage.Text = string.Empty;
            progressBar.Value = 0;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Hide();
            CancelRequested?.Invoke(this, EventArgs.Empty);
        }
    }
}
