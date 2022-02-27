namespace WinFormsApp1
{
    public partial class UserInteractiveForm : Form
    {
        public UserInteractiveForm()
        {
            InitializeComponent();
        }

        private void button_enter_username_Click(object sender, EventArgs e)
        {
            string username = textBox_username.Text;
            if (!string.IsNullOrWhiteSpace(username))
                MessageBox.Show($"Hello {username}");
        }
    }
}