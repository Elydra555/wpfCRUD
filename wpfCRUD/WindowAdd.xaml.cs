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
using System.Windows.Shapes;

namespace wpfCRUD
{
    /// <summary>
    /// Interaction logic for WindowAdd.xaml
    /// </summary>
    public partial class WindowAdd : Window
    {
        Person Person;
        PersonContext db;

        public WindowAdd()
        {
            InitializeComponent();
            Person = new Person("Béla", 32);
            spInput.DataContext = Person;

            db = new PersonContext();
        }

        private void TextBlock_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            //Person.Name = "Dezső";
            //MessageBox.Show(Person.ToString());
            Person.Id = 0;
            db.Persons.Add(Person);
            await db.SaveChangesAsync();
            Person.Name = "";
            Person.Age = 18;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
