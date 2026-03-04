using LibraryGUI.Datas;
using LibraryGUI.Models;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;


namespace LibraryGUI.Views
{
    /// <summary>
    /// Interaction logic for DeleteBook.xaml
    /// </summary>
    public partial class DeleteBook : Page
    {
        Read read = new Read();
        Delete delete = new Delete();
        public DeleteBook()
        {
            InitializeComponent();
            dataGrid2.ItemsSource = read.ReadBooks();
        }

        private void dataGrid2_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var record = dataGrid2.CurrentItem as Books;

            var Result = MessageBox.Show($"Biztos törlöd {record.Title} adatait?", "Könyv törlés", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (Result == MessageBoxResult.Yes)
            {
                var book = delete.DeleteBook(record.BookId) as LibraryResults;
                MessageBox.Show(book.Message);
                dataGrid2.ItemsSource = read.ReadBooks();
            }
        }

        private void dataGrid2_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            if (e.PropertyType.IsClass && e.PropertyType != typeof(string))
            {
                e.Cancel = true;
            }
        }
    }
}
