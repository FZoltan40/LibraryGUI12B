using LibraryGUI.Datas;
using LibraryGUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LibraryGUI
{
    /// <summary>
    /// Interaction logic for CreateBook.xaml
    /// </summary>
    public partial class CreateBook : Page
    {
        Create create = new Create();
        public CreateBook()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
            var bookResult = create.CreateBooks(bookTitle.Text,DateTime.Parse(bookDate.Text), int.Parse(authorId.Text), int.Parse(categoryId.Text)) as LibraryResults;
            MessageBox.Show(bookResult.Message);
        }
    }
}
