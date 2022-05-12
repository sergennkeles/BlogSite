using AutoMapper;
using BlogSite.Core.Dtos;
using BlogSite.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSite.Service.Mapping
{
    public class MapProfile : Profile
    {

        public MapProfile()
        {
            CreateMap<User, UserInfoDto>().ReverseMap();
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<Twitter, TwitterDto>().ReverseMap();
            CreateMap<Post, PostDto>().ReverseMap();
            CreateMap<Comment, CommentDto>().ReverseMap();
            CreateMap<Instagram, InstagramDto>().ReverseMap();
            CreateMap<Facebook, FacebookDto>().ReverseMap();
            CreateMap<Github, GithubDto>().ReverseMap();
      


        }
    }
}
