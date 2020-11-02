using BlogProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogProject.DAL
{
    public class BlogInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<BlogContext>
    {
        protected override void Seed(BlogContext context)
        {
            var blogs = new List<BlogPost>
            {
            new BlogPost{Title="Iron Man",Category="Action, Sci-Fi", Text="After being held captive in an Afghan cave, billionaire engineer Tony Stark creates a unique weaponized suit of armor to fight evil.",Datetime=DateTime.Parse("2008-06-11")},
            new BlogPost{Title="Iron Man 2",Category="Action, Sci-Fi", Text="With the world now aware of his identity as Iron Man, Tony Stark must contend with both his declining health and a vengeful mad man with ties to his father's legacy.",Datetime=DateTime.Parse("2010-05-23")},
            new BlogPost{Title="Captain America: The First Avenger",Category="Action, Sci-Fi", Text="Steve Rogers, a rejected military soldier, transforms into Captain America after taking a dose of a Super-Soldier serum. But being Captain America comes at a price as he attempts to take down a war monger and a terrorist organization.",Datetime=DateTime.Parse("2011-05-25")},
            new BlogPost{Title="Captain Marvel",Category="Action, Adventure, Sci-Fi", Text="Carol Danvers becomes one of the universe's most powerful heroes when Earth is caught in the middle of a galactic war between two alien races.",Datetime=DateTime.Parse("2019-04-24")},
            new BlogPost{Title="The Incredible Hulk",Category="Action, Adventure, Sci-Fi", Text="Bruce Banner, a scientist on the run from the U.S. Government, must find a cure for the monster he turns into whenever he loses his temper.",Datetime=DateTime.Parse("2008-02-21")},
            new BlogPost{Title="Thor",Category="Action, Adventure, Sci-Fi", Text="The powerful but arrogant god Thor is cast out of Asgard to live amongst humans in Midgard (Earth), where he soon becomes one of their finest defenders.",Datetime=DateTime.Parse("2011-02-13")},
            new BlogPost{Title="The Avengers",Category="Action, Adventure, Sci-Fi", Text="Earth's mightiest heroes must come together and learn to fight as a team if they are going to stop the mischievous Loki and his alien army from enslaving humanity.",Datetime=DateTime.Parse("2012-05-23")},
            new BlogPost{Title="Guardians of the Galaxy",Category="Action, Adventure, Sci-Fi", Text="A group of intergalactic criminals must pull together to stop a fanatical warrior with plans to purge the universe.",Datetime=DateTime.Parse("2014-11-23")},
            new BlogPost{Title="The Avengers: Age of Ultron",Category="Action, Adventure, Sci-Fi", Text="When Tony Stark and Bruce Banner try to jump-start a dormant peacekeeping program called Ultron, things go horribly wrong and it's up to Earth's mightiest heroes to stop the villainous Ultron from enacting his terrible plan.",Datetime=DateTime.Parse("2015-12-23")},
            new BlogPost{Title="Captain America: Civil War",Category="Action, Adventure, Sci-Fi", Text="Political involvement in the Avengers' affairs causes a rift between Captain America and Iron Man.",Datetime=DateTime.Parse("2016-08-29")},
            new BlogPost{Title="Get Out",Category=" Horror, Mystery, Thriller", Text="A young African-American visits his white girlfriend's parents for the weekend, where his simmering uneasiness about their reception of him eventually reaches a boiling point.",Datetime=DateTime.Parse("2017-01-25")}
            };

            blogs.ForEach(x => context.BlogPosts.Add(x));
            context.SaveChanges();
            
        }
    }
}
