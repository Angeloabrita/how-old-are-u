
namespace HowOldeAreU.Server.Dto
{
    public class FaceResponse
    {
       
        public double? Idade { get; set; }  
        public double? Probabilidade { get; set; }
        public List<double>? Bbox { get; set; }     
        public string? Class { get; set; }     
        public List<double>? Faces { get; set; }      
        public string? Status { get; set; }
    }
}
