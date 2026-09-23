namespace CITA255_a2
{
    public partial class MainPage : ContentPage
    {
        List<string> game = new List<string> {"Elden Ring", "Clair Obscur: Expedition 33", "Bloodborne", "Lies of P",
        "Fatal Fury: City of the Wolves", "Granblue Fantasy Versus: Rising", "The Last Faith", "Tekken 8",
        "The First Berserker Khazan", "Tales of Arise", "Devil May Cry 5 Special Edition", "The King of Fighters XV",
        "Virtua Fighter 5 REVO World Stage", "Final Fantasy XVI"};
        List<int> hours = new List<int> {261, 37, 169, 225, 31, 24, 19, 220, 127, 0, 189, 21, 16, 89};

        public MainPage()
        {
            InitializeComponent();
            gameList.ItemsSource = game;
            hoursList.ItemsSource = hours;
        }
    }
}
