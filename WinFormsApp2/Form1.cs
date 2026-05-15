namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public static string verifiedUsername;
        public Form1()
        {
            InitializeComponent();
            LoadLogin();
            
        }

        public void LoadLogin()
        {
            LogInPanel.Controls.Clear();

            UCLogInForm login = new UCLogInForm();

            login.Dock = DockStyle.Fill;

            LogInPanel.Controls.Add(login);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
