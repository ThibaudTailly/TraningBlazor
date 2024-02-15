using System.ComponentModel.DataAnnotations;

namespace SqlLiteTool.Models;

public class DiabloActs
{
    [Key]
    public int id { get; set; }
    public List<Act> acts { get; set; }
}
