using Birthday_Manager.Models;

namespace Birthday_Manager.Views;

public partial class AddPerson : ContentPage
{
	public AddPerson()
	{
		InitializeComponent();
	}

	private void OnAddPerson(object sender, EventArgs e)
	{
		Person person = new Person();
		person.FirstName = FirstName.Text;
		person.LastName = LastName.Text;
		person.Birthday = Birtday.Date;

	}
}