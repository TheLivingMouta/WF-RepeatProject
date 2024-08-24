using Microsoft.EntityFrameworkCore;
using WF_RepeatProject.Data;

namespace WF_RepeatProject.Models;

    public static class SeedData
    {

        public static void Initialize(IServiceProvider serviceProvider)
        {

        using (var context = new WF_RepeatProjectContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<WF_RepeatProjectContext>>()))
        {

            if (context.Book.Any())
            {
                return;
            }

            context.Book.AddRange(
                
                new Book
                {
                    Title = "Hitch hikers guide to the galaxy",
                    Author = "Douglas Adams",
                    Category = "Science Fiction",
                },
                new Book
                {
                    Title = "The Adventure Zone: Here Be Gerblins",
                    Author = "Griffin McElroy",
                    Category = "Fantasy",
                },
                new Book
                {
                    Title = "The Adventure Zone: Murder Rockport Limited",
                    Author = "Griffin McElroy",
                    Category = "Fantasy",
                },
                new Book
                {
                    Title = "One Piece: Volume 1",
                    Author = "Eiichiro Oda",
                    Category = "Adventure, Fantasy, Science Fiction",
                }

                );
            context.SaveChanges();
        }

        }

    }

