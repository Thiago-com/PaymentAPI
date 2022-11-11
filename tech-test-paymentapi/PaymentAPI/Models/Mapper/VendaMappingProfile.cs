using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PaymentAPI.Models.DTO;
using PaymentAPI.Models.Entity;
using AutoMapper;

namespace PaymentAPI.Models.Mapper
{
    public class VendaMappingProfile:Profile
    {
        public VendaMappingProfile()
        {
            CreateMap< CadastrarVendaDTO, Venda>().ReverseMap();
            CreateMap<CadastrarProdutoDTO, Produto>().ReverseMap();
            CreateMap<CadastrarVendedorDTO, Vendedor>().ReverseMap();
            CreateMap<Venda, VendaDTO>().ReverseMap();
            CreateMap<Produto, ProdutoDTO>().ReverseMap();
            CreateMap<Vendedor, VendedorDTO>().ReverseMap();
        }
    }
}
