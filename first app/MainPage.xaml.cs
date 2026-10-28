using System.Collections.ObjectModel;

namespace first_app
{
    public partial class MainPage : ContentPage
    {
        // ObservableCollection tells the UI to refresh when items are added or removed
        ObservableCollection<string> tasks = new ObservableCollection<string>();

        public MainPage()
        {
            InitializeComponent();
            tasksView.ItemsSource = tasks;
        }

        // Runs when the Add button is clicked or Enter is pressed in the Entry
        void OnAddClicked(object sender, EventArgs e)
        {
            string text = taskEntry.Text?.Trim() ?? "";

            if (text == "")
                return; // ignore empty input

            tasks.Add(text);
            taskEntry.Text = "";
        }

        // Runs when the user swipes a task and taps Delete
        void OnDeleteInvoked(object sender, EventArgs e)
        {
            var swipeItem = (SwipeItem)sender;
            string task = (string)swipeItem.CommandParameter;
            tasks.Remove(task);
        }
    }
}
