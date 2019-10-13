private static UserListControl _instance;

//Declaring instance of user control, so we only open one at a time
public static UserListControl Instance
{
    get
    {
        if (_instance == null)
            _instance = new UserListControl();
        return _instance;
    }
}
