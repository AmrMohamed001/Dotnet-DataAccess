using System.ComponentModel.DataAnnotations.Schema;

namespace efcoreOrm.Data;

public class Tweet
{
    public int  Id { get; set; }
    public int UserId { get; set; }
    public string TweetText { get; set; }
    public DateTime CreatedAt { get; set; }
}