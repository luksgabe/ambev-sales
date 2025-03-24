using Ambev.DeveloperEvaluation.Domain.Entities;
using AutoMapper;


namespace Ambev.DeveloperEvaluation.Application.Products.Events
{
    public class RegisterProductEventProfile : Profile
    {
        public RegisterProductEventProfile()
        {
            CreateMap<Product, ProductRegisterEvent>();
        }
    }
}
