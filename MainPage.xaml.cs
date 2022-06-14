namespace Test_CollectionView;

public partial class MainPage : ContentPage
{

	private MainPage_ViewModel lc_MainPage_ViewModel;

    public MainPage()
	{
		InitializeComponent();

        lc_MainPage_ViewModel = new MainPage_ViewModel();

        this.BindingContext = lc_MainPage_ViewModel;

    }

}

