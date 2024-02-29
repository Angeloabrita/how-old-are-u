using HowOldeAreU.Server.Dto;
using HowOldeAreU.Server.Models;

namespace HowOldeAreU.Server.Interfaces
{
    public interface Ifaces
    {
        Task<GenericResponse<FaceModel>> GetFaces(string image);
    }
}
