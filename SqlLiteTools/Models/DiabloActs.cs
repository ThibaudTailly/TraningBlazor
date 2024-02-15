using System.ComponentModel.DataAnnotations;

namespace SqlLiteTools.Models;

public class DiabloActs
{
    [Key]
    public int id { get; set; }
    public List<Act> acts { get; set; }
}
