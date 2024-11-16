using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserSession session = UserSession.GetInstance();
            session.Login("admin", "12345");

            Console.WriteLine($"Активная сессия: {session.IsLoggedIn()}"); // True
            // Попытка логина при занятой сессии
            UserSession anotherSession = UserSession.GetInstance();
            anotherSession.Login("user", "password"); // Сообщение, что сессия занята
            session.Logout();

            // Проверяем, активна ли сессия
            Console.WriteLine($"Активная сессия: {session.IsLoggedIn()}"); // False
            Console.ReadKey();
        }
    }
}

