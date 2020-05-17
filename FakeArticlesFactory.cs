namespace Blog.Test.Fakes
{
    using Blog.Data.Models;

    public static class FakeArticlesFactory
    {
        public static Article[] CreateArticles(int articlesNum)
        {
            Article[] articles = new Article[articlesNum];

            for (int i = 0; i < articles.Length; i++)
            {
                articles[i] = new Article
                {
                    Id = i,
                    UserId = $"{i}"
                };
            }

            return articles;
        }
    }
}
