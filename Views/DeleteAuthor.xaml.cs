using LibraryGUI.Datas;
using LibraryGUI.Models;
using System.Windows;
using System.Windows.Controls;


namespace LibraryGUI.Views
{
    /// <summary>
    /// Interaction logic for DeleteAuthor.xaml
    /// </summary>
    public partial class DeleteAuthor : Page
    {
        Read read = new Read();
        Delete delete = new Delete();
        public DeleteAuthor()
        {
            InitializeComponent();
            dataGrid2.ItemsSource = read.ReadAuthors();
        }
        private void dataGrid2_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            if (e.PropertyType.IsClass && e.PropertyType != typeof(string))
            {
                e.Cancel = true;
            }
        }

        private void dataGrid2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           

           
        }

        private void dataGrid2_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            var record = dataGrid2.CurrentItem as Authors;

            var Result = MessageBox.Show($"Biztos törlöd {record.AuthorName} adatait?", "Szerző törlés", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (Result == MessageBoxResult.Yes)
            {
                var author = delete.DeleteAuthor(record.AuthorId) as LibraryResults;
                MessageBox.Show(author.Message);
                dataGrid2.ItemsSource = read.ReadAuthors();
            }
        }
    }
}
