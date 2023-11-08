namespace WinFormsApp30
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonleft_Click(object sender, EventArgs e)
        {
            TogglePanelVisibility();
        }

        private void TogglePanelVisibility()
        {
            rightPanel.Visible = !rightPanel.Visible;
        }
    }
}