using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace BetterU.Tables
{
    public class RegUserTable
    {
        [PrimaryKey, AutoIncrement]
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

    }

}
