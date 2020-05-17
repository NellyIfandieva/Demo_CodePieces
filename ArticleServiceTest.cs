namespace Blog.Test
{
    using System.Threading.Tasks;
    using Blog.Test.TestConstants.ArticleServiceTestConstants;
    using Fakes;
    using Xunit;

    public class ArticleServiceTest
    {
        private FakeDbContextDriver driver;
        private int articleId;
        private string userId;

        [Fact]
        public async Task IsByUSerShouldReturnTrueWhenArticleByUserExists()
        {
            // Arrange
            this.driver = new FakeDbContextDriver(ArticleConstants.IsByUserTrueDbName, 
                (int)ArticleConstants.GetArticlesNum);

            // Act
            this.articleId = 1;
            this.userId = (string)ArticleConstants.GetArticlesNum;

            bool exists = await this.driver
               .ArticleService
               .IsByUser(this.articleId, this.userId);

            // Assert
            Assert.True(exists);
        }

        [Fact]
        public async Task IsByUSerShouldReturnFalseWhenArticleByTheSpecificUserDoesNotExist()
        {
            // Arrange
            this.driver = new FakeDbContextDriver(ArticleConstants.IsByUserTrueDbName,
                (int)ArticleConstants.GetArticlesNum);

            // Act
            this.articleId = (int)ArticleConstants.GetArticlesNum;
            this.userId = ArticleConstants.IsByUserFalseUserId;

            bool exists = await this.driver
                .ArticleService
                .IsByUser(this.articleId, this.userId);

            // Assert
            Assert.False(exists);
        }
    }
}
