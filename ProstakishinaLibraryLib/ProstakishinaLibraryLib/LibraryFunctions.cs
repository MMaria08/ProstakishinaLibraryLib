using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProstakishinaLibraryLib
{
    public class LibraryFunctions
    {
        // Переменная для хранения название библиотеки
        private string libraryName = "Городская библиотека г. Чита";

        // Переменная для хранения ФИО главного библиотекаря
        private string chiefLibrarian = "Иванова Мария Петровна";

        // Переменная для хранения список сотрудников
        private List<string> staffList = new List<string>
        {
            "Петров П.С.",
            "Сидорова А.В.",
            "Козлов И.Д.",
            "Иванова М.П."
        };

        /// <summary>
        /// метод возвращает ФИО главного библиотекаря
        /// </summary>
        public string GetChiefLibrarian() 
        {
            return chiefLibrarian;
        }

        /// <summary>
        /// метод изменяет ФИО главного библиотекаря, только если данное ФИО есть в списке сотрудников.
        /// </summary>
        /// <param name="fullname"></param>
        public void SetChiefLibrarian(string fullname) 
        {
            if (staffList.Contains(fullname))
            {
                chiefLibrarian = fullname;
            }
        }

        /// <summary>
        /// метод возвращает название библиотеки
        /// </summary>
        public string GetLibraryName() 
        {
            return libraryName;
        }
        /// <summary>
        /// метод формирует код книги вида CAT_number, где CAT- категория книги,number - случайный номер, и возвращает сгенерированный код
        /// </summary>
        /// <param name="category"></param>
        /// <param name="number"></param>
        public string  GenerateBookCode(string category, int number) 
        {
            Random rnd = new Random();
            int randomNumber = rnd.Next(1, 1000);
            return category + "_" + randomNumber;
        }
        /// <summary>
        /// метод возвращает список сотрудников библиотеки
        /// </summary>
        public List<string> GetStaff() 
        {
            return staffList;
        }
        /// <summary>
        /// метод добавляет нового сотрудника в список сотрудников
        /// </summary>
        public void AddStaff(string fullname) 
        {
            staffList.Add(fullname);
        }
    }
}
