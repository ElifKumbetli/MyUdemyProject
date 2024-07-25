using AutoMapper;
using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.Controllers;
using HotelProject.WebUI.Dtos.AboutDto;
using HotelProject.WebUI.Dtos.BookingDto;
using HotelProject.WebUI.Dtos.RegisterDto;
using HotelProject.WebUI.Dtos.ServiceDto;
using HotelProject.WebUI.Dtos.StaffDto;
using HotelProject.WebUI.Dtos.SubscribeDto;
using HotelProject.WebUI.Dtos.TestimonialDto;

namespace HotelProject.WebUI.Mapping
{
    public class AutoMapperConfig:Profile

    {
        public AutoMapperConfig()
        {
            CreateMap<ResultServiceDto, Service>().ReverseMap();    
            CreateMap<UpdateServiceDto, Service>().ReverseMap();    
            CreateMap<CreateServiceDto, Service>().ReverseMap();
            
            CreateMap<CreatNewUserDto, AppUser>().ReverseMap();
            CreateMap<LoginuserDto, AppUser>().ReverseMap(); //Eşleştir
          
            CreateMap<ResultAboutDto, About>().ReverseMap(); 
            CreateMap<UpdateAboutDto, About>().ReverseMap(); 
           
            CreateMap<ResultTestimonialDto, Testimonial>().ReverseMap(); 

            CreateMap<ResultStaffDto, Staff>().ReverseMap(); 

            CreateMap<CreateBookingDto, Booking>().ReverseMap(); 
            CreateMap<ApprovedReservationDto, Booking>().ReverseMap(); 
          


        }
    }
}
