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

namespace LibraryGUI.Views
{
    /// <summary>
    /// Interaction logic for UpdateAuthor.xaml
    /// </summary>
    public partial class UpdateAuthor : Page
    {
        Read read = new Read();
        Update update = new Update();
        static int authorId = 0;
        public UpdateAuthor()
        {
            InitializeComponent();
            var authors = read.ReadAuthors();
            authorComboBox.SelectedValue = authors[0].AuthorName;
            foreach (var auth in authors) 
            {
                authorComboBox.Items.Add(auth.AuthorName);
            }
         
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            var auth = new Authors 
            { 
                AuthorId = authorId,
                AuthorName = authorComboBox.Text
            };
            var result = update.UpdateAuthor(auth.AuthorId,auth) as LibraryResults;
            MessageBox.Show(result.Message);
           
        }

        private void authorComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void authorComboBox_Selected(object sender, RoutedEventArgs e)
        {
           
        }

        private void authorComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                var authors = read.ReadAuthors();
                var author = authors.FirstOrDefault(x => x.AuthorName == authorComboBox.SelectedItem.ToString());
                if (author != null)
                {
                    authorId = author.AuthorId;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Nincs ilyen szerző.");
            }
           
           
        }
    }
 }

