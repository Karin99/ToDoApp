using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Data
    {
        public Data(bool completed, string name, String date, string task)
        {
            this.isCompleted = completed;
            this.name = name;
            this.date = date;
            this.task = task;
        }

        public Boolean isCompleted { get; set; }

        public String name { get; set; }

        public String date { get; set; }

        public String task { get; set; }
    }
}
