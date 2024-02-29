using AutoMapper;
using HowOldeAreU.Server.Dto;

namespace HowOldeAreU.Server.Mapping
{
    public class FaceMapping: Profile
    {
        public FaceMapping() {

            CreateMap(typeof(GenericResponse<>), typeof(GenericResponse<>));
            CreateMap<FaceResponse, FaceResponse>();

            

        }    
    }
}
