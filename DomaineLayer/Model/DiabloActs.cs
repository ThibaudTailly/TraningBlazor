using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DomaineLayer.Model
{
    public class DiabloActs
    {
        [Key]
        public int id { get; set; }
        public List<Act> acts { get; set; }
    }
    public class Quest
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string slug { get; set; }
    }

    [Table("Act")]
    public class Act
    {
        [Key]
        public int id { get; set; }
        public string slug { get; set; }
        public int number { get; set; }
        public string name { get; set; }
        public List<Quest> quests { get; set; }
    }
}
