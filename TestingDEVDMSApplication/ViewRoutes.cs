namespace TestingDEVDMSApplication
{
    public static class ViewRoutes
    {
        public static string Home(string actionName) => string.Format("~/Views/Home/{0}.cshtml", actionName);
        public static string Customer(string actionName) => string.Format("~/Views/Customer/{0}.cshtml", actionName);
    }
}
