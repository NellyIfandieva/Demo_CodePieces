namespace Blog.Test.Fakes
{
    using Blog.Data;
    using Blog.Data.Models;
    using Blog.Services;
    using Microsoft.EntityFrameworkCore;

    public class FakeDbContextDriver
    {
        private readonly BlogDbContext db;

        public FakeDbContextDriver(string dbName, int articlesNum)
        {
            var options = new DbContextOptionsBuilder<BlogDbContext>()
                .UseInMemoryDatabase(dbName)
                .Options;

            this.db = new FakeBlogDbContext(options);
            RegisterArticlesInDb(articlesNum);
            this.ArticleService = new ArticleService(this.db);
        }

        public FakeBlogDbContext Db { get; }

        public ArticleService ArticleService { get; private set; }

        public void RegisterArticlesInDb(int articlesNum)
        {
            Article[] articles = FakeDbContextFactory
                .CreateArticles(articlesNum);

            this.db.Add(articles);
        }

        public BlogDbContext ReturnDatabase()
        {
            return this.Db.ReturnData();
        }
    }
}
