namespace RestWithASPNETUdemy.Hypermedia.Constants
{
    // sealed => impede que a classe seja herdada
    public sealed class HttpActionVerb
    {
        public const string GET = "GET";
        public const string POST = "POST";
        public const string PUT = "PUT";
        public const string DELETE = "DELETE";
        public const string PATCH = "PATCH";
    }
}
