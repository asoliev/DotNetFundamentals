using ConcatetionLogicLibrary;
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
            {
                ConcatetionLogic library = new();
                MessageBox.Show(library.Output(username));
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Enter valid username.", "Invalid input",
                    MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
                if (dialogResult == DialogResult.Cancel)
                {
                    Application.Exit();
                }
                else
                {
                    textBox_username.Focus();
                }
            }
        }
    }
}