namespace Lab03.Model
{
    public abstract class NewsManagerBase
    {
        public abstract static void GetNews(string category, ObservableCollection<NewsItem> newsItems);
    }
}