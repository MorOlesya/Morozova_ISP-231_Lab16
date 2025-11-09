using System;
using System.Windows;
namespace SimpleRegistrationApp
{
    public class Person
    {
        private string _name;
        private int _age;
        private string _password;
        public Person(string name, int age, string password)
        {
            _name = name;
            _age = age;
            _password = password;
        }

        public bool CheckNameCorrect()
        {
            if (_name == null || _name == " " || _name.Length == 0)
            {
                MessageBox.Show("Введите имя");
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool CheckAgeCorrect()
        {
            if (_age < 1 || _age > 120)
            {
                MessageBox.Show("Возраст должен быть от 1 года до 120 лет");
                return false;
            }
            else if (_age == null)
            {
                MessageBox.Show("Введите возраст");
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool CheckPasswordCorrect()
        {
            if (_password == null)
            {
                MessageBox.Show("Введите пароль");
                return false;
            }
            else if (_password.Length < 6)
            {
                MessageBox.Show("Пароль должен быть от 6 символов");
                return false;
            }
            else
            {
                return true;
            }
        }

        public void CheckCorrect()
        {
            if (CheckNameCorrect() == true &&
                CheckAgeCorrect() == true &&
                CheckPasswordCorrect() == true)
            {
                MessageBox.Show("Регистрация успешна");
            }
        }
    }
}
