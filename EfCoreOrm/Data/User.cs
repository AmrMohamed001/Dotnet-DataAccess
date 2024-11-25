using System.ComponentModel.DataAnnotations.Schema;
namespace efcoreOrm.Data;

public class User
{
    public int Id { get; set; }
    public string Username { get; set; }
}