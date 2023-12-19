using Plugin.Maui.ScreenBrightness;
using RedOpalInnovationsHRApp.ViewModel;

namespace RedOpalInnovationsHRApp
{
	public partial class SettingsPage : ContentPage
	{
		public SettingsPage(SettingsViewModel vm)
		{
			InitializeComponent();
			BindingContext = vm;

			sliderBrightness.Value = ScreenBrightness.Default.Brightness;

		}



		private void OnBackTapped(object sender, EventArgs e)
		{
			Shell.Current.GoToAsync("//MainPage");
		}

        private void sliderBrightness_ValueChanged(object sender, ValueChangedEventArgs e)
        {
			ScreenBrightness.Default.Brightness = (float)e.NewValue;
        }
    }
}