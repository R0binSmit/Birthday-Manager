using Birthday_Manager.Views;

namespace Birthday_Manager;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void OnAddPerson(object sender, EventArgs e)
	{
		App.Current.MainPage = new AddPerson();
	}

}

