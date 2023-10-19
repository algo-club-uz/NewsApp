namespace NewsApp.ViewModel;

public class NewsViewModel
{
    public Command SignInCommand { get; set; }

    public NewsViewModel()
    {
        SignInCommand = new Command(SignIn);
    }

    private void SignIn(object obj)
    {
        
    }
}