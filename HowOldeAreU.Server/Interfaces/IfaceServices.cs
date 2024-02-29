using HowOldeAreU.Server.Dto;

namespace HowOldeAreU.Server.Interfaces
{
    public interface IfaceServices
    {
        Task<GenericResponse<FaceResponse>> FaceGet(string faceId);

    }
}
