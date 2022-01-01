using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BlogEntities.Concrete;

namespace BlogServices.AutoMapper.Profiles
{
    public class PostProfile : Profile
    {
        public PostProfile()
        {
            //CreateMap<PostAddDto, Post>();
        }
    }
}