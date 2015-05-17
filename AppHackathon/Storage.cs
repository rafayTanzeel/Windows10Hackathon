using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppHackathon
{

    public class Storage
    {

        public string name { set; get; }
        public string type { set; get; }
        public int duration { set; get; }
        public string notes { set; get; }
        public string due { set; get; }
        public int maxDuration { set; get; }

        public Storage(string name, string type, int duration, string notes, string due, int maxDuration){
            this.name = name;
            this.type = type;
            this.duration = duration; //break time
            this.notes = notes;
            this.due = due;
            this.maxDuration = maxDuration; //max activity
     }

    }
}
