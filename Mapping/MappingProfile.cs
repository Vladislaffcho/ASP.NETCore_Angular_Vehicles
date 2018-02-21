using ASP.NET_Core_Angular_4.Controllers.Resources;
using ASP.NET_Core_Angular_4.Models;
using AutoMapper;

namespace ASP.NET_Core_Angular_4.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Make, MakeResource>();
            CreateMap<Model, ModelResource>();
        }
    }
}