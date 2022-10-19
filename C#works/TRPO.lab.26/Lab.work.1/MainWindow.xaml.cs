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

namespace Lab.work._1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Model model;
        private Presenter presenter;

        public MainWindow()
        {
            InitializeComponent();
            model = new Model();
            presenter = new Presenter(model);

        }
        private void LoginButton_Click(object sender, RoutedEventArgs e) //Обработчик события нажатия на кнопку входа
        {
            this.model = this.presenter.Login(LoginTextBox.Text, PassBox.Password); //Отправка данных представителю и получение обновлённой модели
            Update(); //Вызов метода обновления интерфейса
        }
        private void Update()
        {
            MessageBlock.Text = this.model.Message; //Вывод сообщения из модели
        }
        public class Presenter
        {
            private Model model; //Связь с моделью

            public Presenter(Model model)
            {
                this.model = model;
            }

            public Model Login(string login, string password) //Получение данных от вида
            {
                login = login.Trim(); //Обработка полученной информации
                password = password.Trim();

                this.model.Login(login, password); //Обновление модели

                return this.model; //Передача обновлённой модели
            }
        }
        public class Model
        {
            private List<User> users;
            private User loggedUser;

            public Model()
            {
                users = new List<User>(); //Создание списка тестовых пользователей

                users.Add(new User("Name1", "Login1", "password1"));
                users.Add(new User("Name2", "Login2", "password2"));
                users.Add(new User("Name3", "Login3", "password3"));
                users.Add(new User("Name4", "Login4", "password4"));
                users.Add(new User("Никита", "Dubrovski", "mypass1"));
                users.Add(new User("староста", "Kostenko", "mypass2"));

                loggedUser = null;
            }

            public void Login(string login, string password) //Метод авторизации
            {
                bool hasLogged = false;

                foreach (User user in this.users)
                {
                    if (user.Login == login && user.Password == password) //Поиск совпадений полученных данных с пользовательскими
                    {
                        this.loggedUser = user; //Обновление модели
                        hasLogged = true;
                        break;
                    }
                }

                if (!hasLogged)
                {
                    this.loggedUser = null;
                }
            }

            public string Message
            {
                get
                {
                    return this.loggedUser != null ? $"Рады видеть тебя {this.loggedUser.Name}!" : "Неправильный логин или пароль!"; //Вывод сообщения в зависимости от того, успешно ли был авторизован пользователь
                }
            }
        }
        public class User
        {
            private string name;
            private string login;
            private string password;

            public User(string name, string login, string password)
            {
                this.name = name;
                this.login = login;
                this.password = password;
            }

            public string Name
            {
                get
                {
                    return this.name;
                }
            }

            public string Login
            {
                get
                {
                    return this.login;
                }
            }

            public string Password
            {
                get
                {
                    return this.password;
                }
            }
        }


    }
}
