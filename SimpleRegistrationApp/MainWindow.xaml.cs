
using System.Windows;

namespace SimpleRegistrationApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void registration_Click(object sender, RoutedEventArgs e)
        {
            string name = regName.Text;
            string age = regAge.Text;
            string password = regPassword.Password;
            Person person = new Person(name, age, password);
            person.CheckCorrect();
        }
    }
}