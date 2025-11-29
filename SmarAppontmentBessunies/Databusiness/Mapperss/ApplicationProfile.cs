using System;
using System.Data;
using AutoMapper;

namespace Databusiness.Mappers
{
    public class ApplicationProfile :  Profile
    {

        public ApplicationProfile()
        {
            CreateMap<DataUser, UserViewModel>().ReverseMap();
            CreateMap<DataPaitent, PatientViewModel>().ReverseMap();
            CreateMap<DataRow, DataDocter>().ForMember(dest => dest.DocterID, opt => opt.MapFrom(src => src["DoctorID"]))
    .ForMember(dest => dest.Fullname, opt => opt.MapFrom(src => src["FullName"])).
    ForMember(dest => dest.Specialty, opt => opt.MapFrom(src => src["Specialty"]))
   .ForMember(dest => dest.phone, opt => opt.MapFrom(src => src["Phone"])).
    ForMember(dest => dest.Email, opt => opt.MapFrom(src => src["Email"])).ReverseMap();

        }
    }
}
