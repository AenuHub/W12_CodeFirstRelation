using Microsoft.EntityFrameworkCore;
using W12_CodeFirstRelation.Data;

namespace W12_CodeFirstRelation;

public class Program
{
    public static void Main(string[] args)
    {
        using var context = new PatikaSecondDbContext();
        Console.WriteLine("Users:");
        foreach (var user in context.Users.Include(user => user.Posts))
        {
            Console.WriteLine($"{user.Id}: {user.Username} - {user.Email}");
            foreach (var post in user.Posts)
            {
                Console.WriteLine($"\t{post.Id}: {post.Title} - {post.Content}");
            }
        }
        
        Console.ReadKey();
    }
}