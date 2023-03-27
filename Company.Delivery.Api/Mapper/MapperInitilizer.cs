using AutoMapper;
using Company.Delivery.Api.Controllers.Waybills.Request;
using Company.Delivery.Api.Controllers.Waybills.Response;
using Company.Delivery.Core;
using Company.Delivery.Domain.Dto;

namespace Company.Delivery.Api.Mapper
{
    /// <summary>
    /// Mappper
    /// </summary>
    public class MapperInitilizer : Profile
    {
        /// <summary>
        /// Mapper
        /// </summary>
        public MapperInitilizer()
        {
            CreateMap<Waybill, WaybillCreateDto>().ForMember(dest => dest.Items, opt => opt.MapFrom(src => src.Items)).ReverseMap();
            CreateMap<Waybill, WaybillDto>().ForMember(dest => dest.Items, opt => opt.MapFrom(src => src.Items)).ReverseMap();
            CreateMap<Waybill, WaybillUpdateDto>().ForMember(dest => dest.Items, opt => opt.MapFrom(src => src.Items)).ReverseMap();

            CreateMap<CargoItem, CargoItemDto>().ReverseMap();
            CreateMap<CargoItem, CargoItemCreateDto>().ReverseMap();
            CreateMap<CargoItem, CargoItemUpdateDto>().ReverseMap();

            CreateMap<CargoItem, CargoItemDto>().ReverseMap();
            CreateMap<CargoItem, CargoItemCreateDto>().ReverseMap();
            CreateMap<CargoItem, CargoItemUpdateDto>().ReverseMap();

            CreateMap<WaybillCreateRequest, WaybillCreateDto>().ReverseMap();
            CreateMap<WaybillUpdateRequest, WaybillUpdateDto>().ReverseMap();
            CreateMap<WaybillResponse, WaybillDto>().ReverseMap();

            CreateMap<CargoItemCreateRequest, CargoItemCreateDto>().ReverseMap();
            CreateMap<CargoItemUpdateRequest, CargoItemUpdateDto>().ReverseMap();
            CreateMap<CargoItemResponse, CargoItemDto>().ReverseMap();
        }

    }
}
