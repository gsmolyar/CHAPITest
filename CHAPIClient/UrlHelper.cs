namespace CHAPIClient
{
    internal class UrlHelper
    {
        private object requestContext;

        public UrlHelper(object requestContext)
        {
            this.requestContext = requestContext;
        }
    }
}