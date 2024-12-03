using System;

namespace WindowsFormsApp1
{
    public class Data
    {
        public Data(bool completed, string name, DateTime date, string task)
        {
            this.isCompleted = completed;
            this.name = name;
            this.date = date;
            this.task = task;
        }

        public Boolean isCompleted { get; set; }

        public String name { get; set; }

        public DateTime date { get; set; }

        public String task { get; set; }
    }
}
