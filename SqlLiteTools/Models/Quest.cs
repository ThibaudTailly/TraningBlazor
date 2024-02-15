using System.ComponentModel.DataAnnotations;

namespace SqlLiteTools.Models;

public class Quest
{
    [Key]
    public int id { get; set; }
    public string name { get; set; }
    public string slug { get; set; }
}
