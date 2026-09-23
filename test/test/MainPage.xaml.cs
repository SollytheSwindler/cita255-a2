namespace test
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        private int games = int.Parse(gameEntry.Text);
        private double hours = double.Parse(hourEntry.Text);

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object? sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }
}
