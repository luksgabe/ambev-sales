using Ambev.DeveloperEvaluation.Application.Auth.AuthenticateUser;
using Ambev.DeveloperEvaluation.Application.Users.CreateUser;
using Ambev.DeveloperEvaluation.WebApi.Features.Auth.AuthenticateUserFeature;
using Ambev.DeveloperEvaluation.WebApi.Features.Users.CreateUser;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Mappings;

public class UserProfile : Profile
{
    public UserProfile()
    {
        CreateMap<CreateUserRequest, CreateUserCommand>().ReverseMap();
        CreateMap<AuthenticateUserRequest, AuthenticateUserCommand>().ReverseMap();
        CreateMap<AuthenticateUserResult, AuthenticateUserResponse>().ReverseMap();
    }
}