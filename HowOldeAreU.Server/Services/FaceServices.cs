using AutoMapper;
using HowOldeAreU.Server.Dto;
using HowOldeAreU.Server.Models;
using HowOldeAreU.Server.Interfaces;

namespace HowOldeAreU.Server.Services
{
    public class FaceService : IfaceServices
    {
        private readonly IMapper _mapper;
        private readonly Ifaces _faces;

        public FaceService(IMapper mapper, Ifaces faces)
        {
            _mapper = mapper;
            _faces = faces;
        }

        public async Task<GenericResponse<FaceResponse>> FaceGet(string image)
        {
            var face = await _faces.GetFaces(image);
            return _mapper.Map<GenericResponse<FaceResponse>>(face);
        }
    }
}
