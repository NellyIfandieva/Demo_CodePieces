namespace Blog.Test.TestConstants.ArticleServiceTestConstants
{
    public static class ArticleConstants
    {
        public static object GetArticlesNum 
            => 3;
        public static string IsByUserTrueDbName 
            => "ArticleIsByUserExists";
        public static string IsByUserFalseDbName 
            => "ArticleIsByUserDoesNotExist";
        public static string IsByUserFalseUserId 
            => "User";
    }
}
