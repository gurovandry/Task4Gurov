using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace DB_App
{
    /// <summary>
    /// Класс контроллера, управляющего интерфесом
    /// </summary>
    class Interface_Controller
    {
        /// <summary>
        /// Входная строка, введенная пользователем
        /// </summary>
        static  string input_string;
        /// <summary>
        /// Массив строк, состоящий из элементов входной строки
        /// </summary>
        static private  string[] mass;

        /// <summary>
        /// Конструктор кдасса Interface_Controller
        /// </summary>
        /// <param name="str">Входная строка</param>
        public Interface_Controller(string str)
        {
            input_string = str;
        }


        /// <summary>
        /// Метод разделения строки на массив составляющих
        /// </summary>
        static private void Split_String()
        {
            string[] massive_out = { "," };
            string[] error = { "Error" };
            try
            {
                mass = input_string.Split(massive_out, StringSplitOptions.RemoveEmptyEntries);
            }
            catch (Exception e)
            {
                Console.WriteLine("Data Error");
                mass = error;
            }
        }
        /// <summary>
        /// Метод выводящий информацию на экран
        /// </summary>
        public void Display_Info()
        {
            Split_String();
            string[] firs_string = mass;
            switch (firs_string[0])
            {
                case "Error":
                    Console.WriteLine("Incorrect Data");
                    break;
                case "Oracle":
                    Oracle_DB oracle = new Oracle_DB();
                    for (int i = 1; i < firs_string.Length; i++)
                    {
                        Console.Write(oracle.Sys_name + ".");
                        oracle.Actions(firs_string[i]);
                    }
                    break;
                case "MySQL":
                    MySQL_DB mysql = new MySQL_DB();
                    for (int i = 1; i < firs_string.Length; i++)
                    {
                        Console.Write(mysql.Sys_name + ".");
                        mysql.Actions(firs_string[i]);
                    }
                    break;
                case "PostgreSQL":
                    PostgreSQL_DB postger = new PostgreSQL_DB();
                    for (int i = 1; i < firs_string.Length; i++)
                    {
                        Console.Write(postger.Sys_name + ".");
                        postger.Actions(firs_string[i]);
                    }
                    break;
            }
                
        }

    }
}
