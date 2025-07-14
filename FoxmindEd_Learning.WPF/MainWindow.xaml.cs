using System.Collections.ObjectModel;
using System.Windows;

namespace FoxmindEd_Learning.WPF;

public partial class MainWindow : Window
{
    public ObservableCollection<object> ItemsList { get; set; } = [];

    public MainWindow()
    {
        DataContext = this;
        InitializeComponent();
    }

    private void SubmitNewEntityObject_Click(object sender, RoutedEventArgs e)
    {

    }
}