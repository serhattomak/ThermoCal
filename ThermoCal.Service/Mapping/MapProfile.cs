using AutoMapper;
using ThermoCal.Core.DTOs;

namespace ThermoCal.Service.Mapping;

public class MapProfile : Profile
{
    public MapProfile()
    {
        CreateMap<AccelerationWorkRequestDto, AccelerationWorkRequestDto>();
        CreateMap<AccelerationWorkResponseDto, AccelerationWorkResponseDto>();
    }
}