namespace School.Domain.AppMetaData
{
    public static class Router
    {
        public const string Root = "Api";
        public const string Version = "V1";
        public const string Rule = $"{Root}/{Version}";

        public static class Student
        {
            public const string Prefix = $"{Rule}/Students";
            public const string List = $"{Prefix}/List";
            public const string ById = Prefix + "/{id}"; 
        }
    }
}
