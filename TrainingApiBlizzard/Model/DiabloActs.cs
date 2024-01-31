namespace TrainingApiBlizzard.Model
{
    public class DiabloActs
    {
        public List<Act> acts { get; set; }
    }
    public class Quest
    {
        public int id { get; set; }
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
