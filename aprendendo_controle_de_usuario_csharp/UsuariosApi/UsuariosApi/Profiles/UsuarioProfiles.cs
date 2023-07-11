using AutoMapper;
using UsuariosApi.Data.Dtos;
using UsuariosApi.Models;

namespace UsuariosApi.Profiles
{
    public class UsuarioProfiles : Profile
    {
        public UsuarioProfiles() 
        {
            CreateMap<CreateUsuarioDto, Usuario>();
        }
        
    }
}
