public EditUserPage()
{
    InitializeComponent();

    List<Users> users = new List<Users>();

    DataAccess db = new DataAccess();

    users = db.GetUsers();

    var usernames = users.Select(l => l.UserName).ToList();

    ComboBox.DataSource = usernames;

    ComboBox.SelectedIndex = -1;
}
