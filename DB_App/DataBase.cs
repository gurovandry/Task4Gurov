using System;
using System.Collections.Generic;
using System.Text;

namespace DB_App
{/// <summary>
/// Абстрактный класс СУБД
/// </summary>
    abstract class DB_System
    {
        /// <summary>
        /// Констурктор класса
        /// </summary>
        public DB_System()
        {

        }
        /// <summary>
        /// Вызовы операций
        /// </summary>
        /// <param name="str"> Строка - название команды </param>
        public void Actions(string str)
        {
            switch (str)
            {
                case "Create_Base":
                    Create_Base();
                    break;
                case "Create_Session":
                    Create_Session();
                    break;
                case "Create_Table":
                    Create_Table();
                    break;
                case "Update_Table":
                    Update_Table();
                    break;
                case "Drop_Table":
                    Drop_Table();
                    break;
                case "Insert_Data":
                    Insert_Data();
                    break;
                case "Delete_Data":
                    Delete_Data();
                    break;
                case "End_Session":
                    End_Session();
                    break;
                case "Drop_Base":
                    Drop_Base();
                    break;
                case "Merge":
                    Merge();
                    break;
            }
        }
        /// <summary>
        /// Методы операция с БД
        /// </summary>
        private void Create_Base() {
            Console.WriteLine("Create_Base");
        }
        private void Create_Session() {
            Console.WriteLine("Create_Session");
        }
        private void Create_Table() {
            Console.WriteLine("Create_Table");
        }
        private void Update_Table() {
            Console.WriteLine("Update_Table");
        }
        private void Drop_Table() {
            Console.WriteLine("Drop_Table");
        }
        private void Insert_Data() {
            Console.WriteLine("Insert_Data");
        }
        private void Delete_Data() {
            Console.WriteLine("Delete_Data");
        }
        private void End_Session() {
            Console.WriteLine("End_Session");
        }
        private void Drop_Base() {
            Console.WriteLine("Drop_Base");
        }
        private void Merge() {
            Console.WriteLine("Merge");
        } 


    }
}
