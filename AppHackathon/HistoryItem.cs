using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppHackathon
{
    class HistoryItem
    {
        public string Name { get; set; }
        public string DueDate { get; set; }

        public HistoryItem(string name, string duedate){
            this.Name = name;
            this.DueDate = duedate;
            }
    }
}
