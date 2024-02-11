using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.DbModel
{
    public class DiabloActs
    {
        public List<Act> acts { get; set; }
    }
    public class Quest
    {
        public string name { get; set; }
        public string slug { get; set; }
    }

    public class Act
    {
        public string slug { get; set; }
        public int number { get; set; }
        public string name { get; set; }
        public List<Quest> quests { get; set; }
    }
}
