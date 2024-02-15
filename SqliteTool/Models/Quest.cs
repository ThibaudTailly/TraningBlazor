using System.ComponentModel.DataAnnotations;

namespace SqlLiteTool.Models;

public class Quest
{
    [Key]
    public int id { get; set; }
    public string name { get; set; }
    public string slug { get; set; }
}
