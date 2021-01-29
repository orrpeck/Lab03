﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03.Model
{
    class NewsItem
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string Headline { get; set; }
        public string Subhead { get; set; }
        public string DateLine { get; set; }
        public string Image { get; set; }

    }
    private static List<NewsItem> getNewsItems()
    {
        var items = new List<NewsItem>();

        items.Add(new NewsItem()
        {
            Id = 1,
            Category = "Financial",
            Headline = "Lorem Ipsum",
            Subhead = "doro sit amet",
            DateLine = "Nunc tristique nec",
            Image = "Assets/Financial1.png"
        });
        items.Add(new NewsItem()
        {
            Id = 2,
            Category = "Financial",
            Headline = "Etiam ac felis viverra",
            Subhead = "vulputate nisl ac, aliquet nisi",
            DateLine = "tortor porttitor, eu fermentum ante congue",
            Image = "Assets/Financial2.png"
        });
        items.Add(new NewsItem()
        {
            Id = 3,
            Category = "Financial",
            Headline = "Integer sed turpis erat",
            Subhead = "Sed quis hendrerit lorem, quis interdum dolor",
            DateLine = "in viverra metus facilisis sed",
            Image = "Assets/Financial3.png"
        });
        items.Add(new NewsItem()
        {
            Id = 4,
            Category = "Financial",
            Headline = "Proin sem nuque",
            Subhead = "aliquet quis ipsum tincidunt",
            DateLine = "Integer eleifend",
            Image = "Assets/Financial4.png"
        });
        items.Add(new NewsItem()
        {
            Id = 5,
            Category = "Financial",
            Headline = "Mauris bibendum non leo vitae tempor",
            Subhead = "In nisl tortor, eleifend sed ipsum eget",
            DateLine = "Curabitur dictum augue vitae elementum ultrices",
            Image = "Assets/Financial5.png"
        });
    }

    public class NewsManager
    {
        public static void GetNews(string category, ObservableCollection<NewsItem> newsItems)
        {
            var allItems = getNewsItems();
            var filteredNewsItems = allItems.Where(p => p.Category == category).ToList();
            newsItems.Clear();
            filteredNewsItems.ForEach(p => newsItems.Add(p));
        }

    }
}

