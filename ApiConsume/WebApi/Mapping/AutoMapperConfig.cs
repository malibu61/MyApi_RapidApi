using AutoMapper;
using DtoLayer.Dtos.RoomDto;
using EntityLayer.Concrete;

namespace WebApi.Mapping
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<RoomAddDto, Room>();
            CreateMap<Room, RoomAddDto>();

            CreateMap<Room, UpdateRoomDto>().ReverseMap();
        }
    }
}
