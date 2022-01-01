using AutoMapper;
using BlogEntities.Concrete;
using BlogEntities.Dtos;

namespace BlogServices.AutoMapper.Profiles
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            CreateMap<CategoryAddDto, Category>();
            CreateMap<CategoryUpdateDto, Category>();
            CreateMap<Category, CategoryUpdateDto>();
            //.ReverseMap();
            CreateMap<Category, CategoryAddDto>();
            //.ForMember(dest=>dest.Description,opt=>opt.MapFrom(src=>src.Description2));
        }
    }
}