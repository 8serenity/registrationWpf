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

//Создать 3 полноценные страницы с переходами для регистрации и авторизации пользователя.
//Первая страница - вход и возможность перейти на регистрацию.
//Вторая страница - регистрация с выбором фото (только png), логин, пароль, повторение пароля(подтверждение пароля), почта, о себе.
//Третья страница - сообщение "Приветствую, %имя пользователя%".

namespace Registration
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SignUp windowRegistration;
        Greetings windowGreetings;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void registrationPressed(object sender, RoutedEventArgs e)
        {
            windowRegistration = new SignUp();
            this.Content = windowRegistration;
            Height = windowRegistration.Height;
            Width = windowRegistration.Width;
        }

        private void loginPressed(object sender, RoutedEventArgs e)
        {
            windowGreetings = new Greetings();
            windowGreetings.textBlockGreetings.Text = "Hello!" + " " + loginBox.Text;
            Content = windowGreetings;
        }
        
    }
}
