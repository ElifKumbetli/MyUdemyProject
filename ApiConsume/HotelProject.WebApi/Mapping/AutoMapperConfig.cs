using AutoMapper;
using HotelProject.DtoLayer.Dtos.RoomDto;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.WebApi.Mapping
{
    public class AutoMapperConfig:Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<RoomAddDto, RoomAddDto>();
            CreateMap<RoomAddDto,RoomAddDto>();

            CreateMap<UpdateRoomDto,Room>().ReverseMap();

        }
    }
}
