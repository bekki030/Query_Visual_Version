namespace Query_Visual_Version
{
    public partial class Form1 : Form
    {
        public static string connectionString;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            connectionString = $@"Host = {txtHost.Text} ; Port = {txtPort.Text}; Database = {txtDatabase.Text};UserName = {txtUserName.Text}; Password = {txtPassword.Text}";
            Tables tables = new Tables();
            Hide();
            tables.ShowDialog();
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtHost.Text = "localhost";
            txtPort.Text = "5433";
            txtDatabase.Text = "transactions";
            txtUserName.Text = "postgres";
            txtPassword.Text = "bekki030";
        }

        private void txtHost_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
