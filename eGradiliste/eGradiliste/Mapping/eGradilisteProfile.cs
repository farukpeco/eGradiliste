using AutoMapper;

namespace eGradiliste.Mapping;

public class eGradilisteProfile : Profile
{
    public eGradilisteProfile()
    {
        CreateMap<Database.Korisnici, Model.Korisnici>();
    }
}
