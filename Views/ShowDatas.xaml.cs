using LibraryGUI.Datas;
using System.Windows;
using System.Windows.Controls;


namespace LibraryGUI.Views
{
    /// <summary>
    /// Interaction logic for ShowDatas.xaml
    /// </summary>
    public partial class ShowDatas : Page
    {
        Read read = new Read();
        private readonly MainWindow _mainWindow;
        public ShowDatas(MainWindow mainWindow)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
            
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            var list = read.ReadAuthors();
            MessageBox.Show(list?.Count.ToString() ?? "null");
            dataGrid1.ItemsSource = list;
        }
    }
}
