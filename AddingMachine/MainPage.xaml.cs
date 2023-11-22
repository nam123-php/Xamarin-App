using System.Collections.ObjectModel;

namespace HikerManagementApp
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        App thisApp = Microsoft.Maui.Controls.Application.Current as App;

        public MainPage()
        {
            InitializeComponent();
            this.cbxNameofHike.Items.Add("Snowdon");
            this.cbxNameofHike.Items.Add("Trosley Country park");

            thisApp.HikeList = new ObservableCollection<Hike>();
        }

        private async void btnSubmit_Clicked(object sender, EventArgs e)
        {
            var response = await DisplayAlert("Confirmation", "Do you want to submit?", "OK", "Cancel");
            if (response)
            {
                Hike h = new Hike(count++, this.cbxNameofHike.SelectedItem.ToString(), this.txtLocation.Text,
                    this.dtpDateoftheHike.Date, this.cbxParkingavailable.SelectedItem.ToString(),
                    this.txtLengththehike.Text, this.txtLevelofdifficulty.Text,
                    this.txtDescription.Text, this.txtName.Text, this.dtpDateofBirth.Date,
                    this.swtGender.IsToggled, this.cbxHeartbeat.SelectedItem.ToString());

                thisApp.HikeList.Add(h);
                await DisplayAlert("Information", "Information submitted", "Ok");
            }
            SemanticScreenReader.Announce(btnSubmit.Text);
        }

        private void btnView_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new HikeList(), true);
        }
    }
}