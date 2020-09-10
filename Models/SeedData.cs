using E_shop_Movie.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace E_shop_Movie.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using var context = new E_shop_MovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<E_shop_MovieContext>>());
            // Look for any movies.
            if (context.Movie.Any())
            {
                return;   // DB has been seeded
            }

            
            context.Movie.AddRange(
                new Movie
                {
                    Title = "When Harry Met Sally",
                    ReleaseDate = DateTime.Parse("1989-2-12"),
                    Genre = "Romantic Comedy",
                    Price = 7,
                    Rating = "G",
                    FileContent = "21.0MB /MP4 File (.mp4)",
                    Description= "When posed the film’s central question, can men and women just be friends, Meg Ryan replied, “Yes, men and women can just be friends. I have a lot of platonic (male) friends, and sex doesn’t get in the way.” Billy Crystal said, “I’m a little more optimistic than Harry. But I think it is difficult. Men basically act like stray dogs in front of a supermarket. I do have platonic (women) friends, but not best, best, best friends.”",
                    Image="When Harry met Saly.png"
                },

                new Movie
                {
                    Title = "Ghostbusters",
                    ReleaseDate = DateTime.Parse("1984-3-13"),
                    Genre = "Comedy",
                    Price = 8,
                    Rating = "G",
                    FileContent = "11.7 MB/MP4 File (.mp4)",
                    Description= "Peter Venkman, Ray Stantz and Egon Spengler work at Columbia University. where they delve into the paranormal and fiddle with many unethical experiments on their students. As they are kicked out of the University, they really understand the paranormal and go into business for themselves. Under the new snazzy business name of 'Ghostbusters', and living in the old firehouse building they work out of, they are called to rid New York City of paranormal phenomenon at everyone's whim. - for a price. ",
                    Image="Ghostbusters.jpg"
                },

                new Movie
                {
                    Title = "Ghostbusters 2",
                    ReleaseDate = DateTime.Parse("1986-2-23"),
                    Genre = "Comedy",
                    Price = 9,
                    Rating = "G",
                    FileContent = "24.4 MB/MP4 File (.mp4)",
                    Description= "Five years after ridding New York of spooks and ghouls, ghostbusting scientists Venkman (Bill Murray), Stantz (Dan Aykroyd) and Spengler (Harold Ramis) find themselves plagued by lawsuits and court orders... and their once-lucrative business is bankrupt. However, when Dana (Sigourney Weaver) begins to have ghost problems again, the boys brave arrest to come out of retirement and battle the beasts of the night. Good gags and zappy special effects capture the spirit of the original.",
                    Image="Ghostbusters2.jpg"
                },

                new Movie
                {
                    Title = "Rio Bravo",
                    ReleaseDate = DateTime.Parse("1959-4-15"),
                    Genre = "Western",
                    Price = 3,
                    Rating = "NC",
                    FileContent = "5.86 MB/MP4 File (.mp4)",
                    Description= "In the town of Rio Bravo, Texas, former sheriff's deputy Dude (Dean Martin), who has acquired the contemptuous nickname Borrachón , enters a saloon but cannot afford a drink. Joe Burdette (Claude Akins), brother of the rich and powerful rancher Nathan Burdette, tosses a silver dollar into a spittoon. Presidio County, Texas, Sheriff John T. Chance (John Wayne) appears and kicks the spittoon away, looking at Dude with disgust. Dude is now mad at him and takes out his anger on Chance, knocking him out with an stick of firewood. After Dude tries to attack Joe, he begins punching Dude. Joe then shoots and kills an unarmed bystander (Bing Russell) who tries to intervene.",
                    Image="Rio Bravo.jpg"
                }
            );
            context.SaveChanges();
        }
    }
}
