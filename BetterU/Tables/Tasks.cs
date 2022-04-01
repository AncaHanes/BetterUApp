using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace BetterU.Tables
{
    public class Tasks
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }

        public bool Complete { get; set; }

    }
}
