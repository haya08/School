using System.Net;

namespace School.Core.Bases
{
    public class Response<T>
    {
        public T Data { get; set; }
        public object Meta { get; set; }
        public List<string> Errors { get; set; }
        public string Message { get; set; }
        public bool Succeeded { get; set; }
        public HttpStatusCode StatusCode { get; set; }
    }
}
