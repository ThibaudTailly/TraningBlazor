using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SqlLiteTool.Models;
[Table ("Act")]
public class Act
{
    [Key]
    public int id { get; set; }
    public string slug { get; set; }
    public int number { get; set; }
    public string name { get; set; }
    public List<Quest> quests { get; set; }
}
