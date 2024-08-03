using AutoMapper;
using Domain.Models;
using Infrastructure.DTO;
using System.Text.RegularExpressions;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Role, RoleDTO>().ReverseMap();
        CreateMap<Appointment, AppointmentDto>().ReverseMap();
        CreateMap<Permission, PermissionDTO>().ReverseMap();
    }
}