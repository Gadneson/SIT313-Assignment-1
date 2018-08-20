using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Assignment111
{
    public class Task
    {

        [PrimaryKey, AutoIncrement]

        public int ID { get; set; }
        public string taskName { get; set; }
        public string taskNote { get; set; }
        public string taskTime { get; set; }


    }
}
