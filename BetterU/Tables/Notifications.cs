using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace BetterU.Tables
{
    public class Notifications
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public TimeSpan Hour { get; set; }

        public bool isRepeatChecked { get; set; }
    }
}
