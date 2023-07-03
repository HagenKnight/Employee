using AutoMapper;
using Payroll.Domain;

namespace Payroll.Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<EmployeeDTO, EmployeeViewModel>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.id))
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.employee_name))
            .ForMember(dest => dest.Salary, opt => opt.MapFrom(src => src.employee_salary))
            .ForMember(dest => dest.Age, opt => opt.MapFrom(src => src.employee_age))
            .ForMember(dest => dest.ProfileImage, opt => opt.MapFrom(src => src.profile_image));
        }
    }
}
