using DomaineLayer.Model;

namespace SqlLiteTools
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new DiabloContext())
            {
                var acts = new List<Act>
            {
                new Act {id = 1 ,slug = "act1", number = 1, name = "Act 1", quests = new List<Quest>(){ new Quest(){name = "quest diablo", slug = "slug quest"}}},
                new Act {id = 2 , slug = "act2", number = 2, name = "Act 2", quests = new List<Quest>(){ new Quest(){name = "quest diablo2", slug = "slug quest2"}}},
                new Act {id = 3 , slug = "act3", number = 3, name = "Act 3", quests = new List<Quest>(){ new Quest(){name = "quest diablo3", slug = "slug quest3"}}},
                new Act {id = 4 , slug = "act4", number = 4, name = "Act 4", quests = new List<Quest>(){ new Quest(){name = "quest diablo4", slug = "slug quest4"}}}
            };
                foreach (var act in acts)
                {
                    context.Act.Add(act);

                }
                context.SaveChanges();

            }

            Console.WriteLine("Act ajouté à la base de données.");
        }
    }
}
