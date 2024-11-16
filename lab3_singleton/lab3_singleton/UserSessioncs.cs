using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_singleton
{
    internal class UserSession
    {
        // Приватное статическое поле для хранения единственного экземпляра
        private static UserSession _instance;

        // Приватный конструктор, чтобы предотвратить создание экземпляров извне
        private UserSession()
        {
            // Инициализация при необходимости
        }

        // Статический метод для получения единственного экземпляра
        public static UserSession GetInstance()
        {
            if (_instance == null)
            {
                _instance = new UserSession();
            }
            return _instance;
        }

        // Свойства для хранения данных о пользователе
        public string Username { get; private set; }
        public string Password { get; private set; }

        // Метод для установки данных пользователя
        public void Login(string username, string password)
        {
            if (Username == null && Password == null) // Проверяем, что сессия не занята
            {
                Username = username;
                Password = password;
                Console.WriteLine($"Пользователь {username} вошел в систему.");
            }
            else
            {
                Console.WriteLine($"Сессия уже занята пользователем {Username}.");
            }
        }

        // Метод для завершения сессии
        public void Logout()
        {
            Console.WriteLine($"Пользователь {Username} вышел из системы.");
            Username = null;
            Password = null;
        }

        // Метод для проверки, активна ли сессия
        public bool IsLoggedIn()
        {
            return Username != null && Password != null;
        }
    }

}
