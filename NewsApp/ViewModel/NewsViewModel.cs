namespace NewsApp.ViewModel;

public class NewsViewModel
{
    public Command SignInCommand { get; set; }

    private string userName;

    public string UserName
    {
        get => userName;
        set => userName = value;
    }


    public NewsViewModel()
    {
        SignInCommand = new Command(SignIn);
    }

    private void SignIn(object obj)
    {
        var user = UserName;
    }
}