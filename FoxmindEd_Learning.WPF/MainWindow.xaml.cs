using FoxmindEd_Learning.WPF.Clients;
using FoxmindEd_Learning.WPF.Entities;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Navigation;

namespace FoxmindEd_Learning.WPF;

public partial class MainWindow : Window
{
    private readonly APIClient _client = new();
    public ObservableCollection<ExampleEntity> ItemsList { get; set; } = [];

    public MainWindow()
    {
        DataContext = this;
        InitializeComponent();
        Loaded += async (s, e) => { await RefreshListAsync(); };
    }

    private async void SubmitNewEntityObject_Click(object sender, RoutedEventArgs e)
    {
        var newEntity = new ExampleEntity
        {
            Name = Name_TextBox.Text,
            Category = Category_TextBox.Text,
            Place = Place_TextBox.Text,
            Date = Date_Picker.SelectedDate ?? DateTime.UtcNow,
            Time = Time_Picker.SelectedTime ?? DateTime.UtcNow,
            Description = Description_TextBox.Text,
            AdditionalInfo = AdditionalInfo_TextBox.Text,
            ImageURL = ImageURL_TextBox.Text
        };
        await _client.PostAsync(newEntity);
        await RefreshListAsync();
    }

    private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
    {
        // TO DO: Implement hyperlink navigation logic
    }

    public async Task RefreshListAsync()
    {
        var items = await _client.GetAllAsync();
        ItemsList.Clear();
        foreach (var item in items)
        {
            ItemsList.Add(item);
        }
    }
}