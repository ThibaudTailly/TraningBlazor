using System.ComponentModel.DataAnnotations;

namespace SqlLiteTools.Models;

public class Act
{
    [Key]
    public int id { get; set; }
    public string slug { get; set; }
    public int number { get; set; }
    public string name { get; set; }
    public List<Quest> quests { get; set; }
}
