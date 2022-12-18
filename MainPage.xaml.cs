namespace Test_CollectionView;

public partial class MainPage : ContentPage
{

	private MainPageViewModel lc_VM;

    public MainPage()
	{
		InitializeComponent();

        lc_VM = new MainPageViewModel();

        this.BindingContext = lc_VM;

    }

}

