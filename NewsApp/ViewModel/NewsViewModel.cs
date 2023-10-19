using System.ComponentModel;

namespace NewsApp.ViewModel;

public class NewsViewModel:INotifyPropertyChanged
{
    public Command SignInCommand { get; set; }

    public event PropertyChangedEventHandler PropertyChanged;

    private string userName;

    public string UserName
    {
        get => userName;
        set
        {
            userName = value;
            OnPropertyChanged("UserName");
        }
    }


    public NewsViewModel()
    {
        SignInCommand = new Command(SignIn);
    }

    private void SignIn(object obj)
    {
        var user = UserName;
    }

    void OnPropertyChanged(string name)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }

}