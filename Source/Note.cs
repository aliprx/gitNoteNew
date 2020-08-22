using SQLite;
using System;

namespace WindowsFormsApp38
{
    public class Note
    {
       
        [PrimaryKey, AutoIncrement]
        public int Id
        {
            get;
            set;
        }

        public string Title
        {
            get;
            set;
        }
        public string Text
        {
            get;
            set;
        }
        public DateTime Date
        {
            get;
            set;
        }
    }
}