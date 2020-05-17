namespace Blog.Test.Fakes
{
    using Blog.Data;
    using Blog.Data.Models;
    using Microsoft.EntityFrameworkCore;
    using System.Linq;
    using System.Threading.Tasks;

    public class FakeBlogDbContext : BlogDbContext
    {
        public FakeBlogDbContext(DbContextOptions<BlogDbContext> options)
        : base(options)
        {
        }

        public async Task Add(params Article[] articles)
        {
            if(articles.Length > 0)
            {
                articles
                .ToList()
                .ForEach(a => this.Articles
                .Add((Article)a));

                await this.SaveChangesAsync();
            }
        }

        public BlogDbContext ReturnData()
        {
            return this;
        }
    }
}
