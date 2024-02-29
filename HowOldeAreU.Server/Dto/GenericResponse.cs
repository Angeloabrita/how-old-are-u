using System.Dynamic;
using System.Net;

namespace HowOldeAreU.Server.Dto
{
    public class GenericResponse<T> where T : class
    {
        public HttpStatusCode StatusCode { get; set; }

        public T? DataReturn {  get; set; }

        public ExpandoObject? ErrorObject { get; set; }
    }

}
