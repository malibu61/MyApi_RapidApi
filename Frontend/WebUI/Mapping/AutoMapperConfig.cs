using AutoMapper;
using EntityLayer.Concrete;
using System.Runtime;
using WebUI.Dtos.ServiceDto;
using WebUI.Dtos.RegisterDto;
using WebUI.Dtos.LoginDto;
using WebUI.Dtos.SubscribeDto;
using WebUI.Dtos.AboutDto;
using WebUI.Dtos.TestimonialDto;
using WebUI.Dtos.StaffDto;
using WebUI.Dtos.BookingDto;
using WebUI.Dtos.GuestDto;
using WebUI.Dtos.AppUserDto;

namespace WebUI.Mapping
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<ResultServiceDto, Service>().ReverseMap();
            CreateMap<UpdateServiceDto, Service>().ReverseMap();
            CreateMap<CreateServiceDto, Service>().ReverseMap();

            CreateMap<CreateNewUserDto, AppUser>().ReverseMap();
            CreateMap<LoginUserDto, AppUser>().ReverseMap();

            CreateMap<ResultAboutDto, About>().ReverseMap();
            CreateMap<UpdateAboutDto, About>().ReverseMap();

            CreateMap<ResultTestimonialDto, Testimonial>().ReverseMap();

            CreateMap<ResultStaffDto, Staff>().ReverseMap();

            CreateMap<CreateSubscribeDto, AppUser>().ReverseMap();


            CreateMap<CreateBookingDto, Booking>().ReverseMap();

            CreateMap<UpdateGuestDto, Guests>().ReverseMap();
            CreateMap<CreateGuestDto, Guests>().ReverseMap();


            CreateMap<ResultAppUserDto, AppUser>().ReverseMap();
        }
    }
}
