using System;
using System.Collections.Generic;
using System.Text;

namespace DB_App
{
    /// <summary>
    /// Класс MySQL - дочерный класс от родительского DB_System
    /// </summary>
    class MySQL_DB : DB_System
    {
        /// <summary>
        /// Строка для хранения имени СУБД
        /// </summary>
        public readonly string Sys_name = "MySQL";
    }
}
