using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace BetterU.Tables
{
    public class Moods
    {
        public int ID { get; set; }
        public int Value { get; set; }
        public DateTime Date { get; set; }
    }
}
