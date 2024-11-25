using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace efcoreOrm.Data;

[Table("tblUsers")] // if there is no table name "Users" that in dbset map to the table attribute will configure that
public class User
{
    [Column("UserId")]
    public int Id { get; set; }
    public string Username { get; set; }
}