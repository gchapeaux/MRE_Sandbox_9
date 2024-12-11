namespace MRE_Sandbox_9
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NewPage1());

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}
