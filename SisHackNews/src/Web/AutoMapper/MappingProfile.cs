using Application.Model;
using Application.ViewModel;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Noticia, NoticiaViewModel>();
            CreateMap<NoticiaViewModel, Noticia>();


            CreateMap<Comentario, ComentarioViewModel>()
                .ForMember(dest => dest.NoticiaViewModel, act => act.MapFrom(src => src.Noticia));

            CreateMap<ComentarioViewModel, Comentario>()
                .ForMember(dest => dest.Noticia, act => act.MapFrom(src => src.NoticiaViewModel));

           

            
        }
    }
}
