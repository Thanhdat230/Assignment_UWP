using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.Model
{
    public class NewsItems
    {
        public int Id { get; set; }
        public string Category { get; set; }//Today,favourite
        public string Headline { get; set; }
        public string Subhead { get; set; }
        public string DateLine { get; set; }
        public string Image { get; set; }
    }

    public class NewManager
    {
        public static void GetNews(string category, ObservableCollection<NewsItems> newsItems) //pass by references
        {
            var allItems = GetNewsItems();
            var filteredNewsItems = allItems.Where(p => p.Category == category).ToList();

            newsItems.Clear();
            filteredNewsItems.ForEach(p => newsItems.Add(p));

            //new Items has items with Category = Financial/Today/Food
        }

        public static List<NewsItems> GetNewsItems()
        {
            var items = new List<NewsItems>();
            items.Add(new NewsItems()
            {
                Id = 1,
                Category = "Financial",
                Headline = "Lorem Ipsum",
                Subhead = "doro sit amet",
                DateLine = "Nunc tristique nec",
                Image = "Assets/Financial1.png"
            });

            items.Add(new NewsItems() 
            { 
                Id = 2, 
                Category = "Financial", 
                Headline = "Etiam ac felis viverra", 
                Subhead = "vulputate nisl ac, aliquet nisi", 
                DateLine = "tortor porttitor, eu fermentum ante congue", 
                Image = "Assets/Financial2.png"
            });

            items.Add(new NewsItems() 
            { 
                Id = 3, 
                Category = "Financial", 
                Headline = "Integer sed turpis erat", 
                Subhead = "Sed quis hendrerit lorem, quis interdum dolor",
                DateLine = "in viverra metus facilisis sed", 
                Image = "Assets/Financial3.png"
            });

            items.Add(new NewsItems()
            {
                Id = 4,
                Category = "Financial",
                Headline = "Proin sem neque",
                Subhead = "aliquet quis ipsum tincidunt",
                DateLine = "Integer eleifend",
                Image = "Assets/Financial4.png" 
            });

            items.Add(new NewsItems()
            { 
                Id = 5, 
                Category = "Financial",
                Headline = "Mauris bibendum non leo vitae tempor", 
                Subhead = "In nisl tortor, eleifend sed ipsum eget",
                DateLine = "Curabitur dictum augue vitae elementum ultrices",
                Image = "Assets/Financial5.png" 
            });

            items.Add(new NewsItems()
            { 
                Id = 6,
                Category = "Today",
                Headline = "Lorem ipsum", 
                Subhead = "dolor sit amet",
                DateLine = "Nunc tristique nec",
                Image = "Assets/Food1.png" 
            });

            items.Add(new NewsItems() 
            {
                Id = 7,
                Category = "Today",
                Headline = "Etiam ac felis viverra", 
                Subhead = "vulputate nisl ac, aliquet nisi", 
                DateLine = "tortor porttitor, eu fermentum ante congue", 
                Image = "Assets/Food2.png"
            });

            items.Add(new NewsItems()
            { 
                Id = 8,
                Category = "Today",
                Headline = "Integer sed turpis erat",
                Subhead = "Sed quis hendrerit lorem, quis interdum dolor",
                DateLine = "in viverra metus facilisis sed", 
                Image = "Assets/Food3.png" 
            });

            items.Add(new NewsItems()
            { 
                Id = 9, 
                Category = "Today", 
                Headline = "Proin sem neque", 
                Subhead = "aliquet quis ipsum tincidunt", 
                DateLine = "Integer eleifend", 
                Image = "Assets/Food4.png"
            });

            items.Add(new NewsItems() 
            { 
                Id = 10,
                Category = "Today", 
                Headline = "Mauris bibendum non leo vitae tempor", 
                Subhead = "In nisl tortor, eleifend sed ipsum eget",
                DateLine = "Curabitur dictum augue vitae elementum ultrices",
                Image = "Assets/Food5.png"
            });

            items.Add(new NewsItems()
            { 
                Id = 11, 
                Category = "Food", 
                Headline = "Lorem ipsum", 
                Subhead = "dolor sit amet",
                DateLine = "Nunc tristique nec",
                Image = "Assets/Food1.png"
            });

            items.Add(new NewsItems()
            {
                Id = 12,
                Category = "Food",
                Headline = "Etiam ac felis viverra", 
                Subhead = "vulputate nisl ac, aliquet nisi",
                DateLine = "tortor porttitor, eu fermentum ante congue", 
                Image = "Assets/Food2.png"
            });

            items.Add(new NewsItems() 
            { 
                Id = 13, 
                Category = "Food",
                Headline = "Integer sed turpis erat",
                Subhead = "Sed quis hendrerit lorem, quis interdum dolor", 
                DateLine = "in viverra metus facilisis sed",
                Image = "Assets/Food3.png" 
            });

            items.Add(new NewsItems()
            { 
                Id = 14, 
                Category = "Food", 
                Headline = "Proin sem neque",
                Subhead = "aliquet quis ipsum tincidunt", 
                DateLine = "Integer eleifend",
                Image = "Assets/Food4.png"
            });

            items.Add(new NewsItems() 
            { 
                Id = 15,
                Category = "Food",
                Headline = "Mauris bibendum non leo vitae tempor", 
                Subhead = "In nisl tortor, eleifend sed ipsum eget", 
                DateLine = "Curabitur dictum augue vitae elementum ultrices", 
                Image = "Assets/Food5.png"
            });

            return items;
        }
    }
}
