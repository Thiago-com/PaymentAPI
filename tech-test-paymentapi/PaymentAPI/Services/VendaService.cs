using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PaymentAPI.Models.DTO;
using PaymentAPI.Models.Entity;
using PaymentAPI.Exceptions;
using PaymentAPI.Services.Interfaces;
using PaymentAPI.Repository.Interfaces;
using AutoMapper;

namespace PaymentAPI.Services
{
    public class VendaService : IVendaService, IValidaQuantidadeProduto
    {
        private readonly  IVendaRepository _vendaRepository;
        private readonly  IMapper _autoMapper;

        public VendaService(IMapper mapper, IVendaRepository repository)
        {
            _autoMapper = mapper;
           _vendaRepository= repository; 
        }

        public  VendaDTO GetByID(int id)
        {
          var venda =  _autoMapper.Map<VendaDTO>(_vendaRepository.GetByID(id));
          return venda;
        }

        public VendaDTO CreateVenda(CadastrarVendaDTO vendaDTO)
        {
            ValidaQuantidadeProduto(vendaDTO);
           var createdVenda =  _vendaRepository.CreateVenda(_autoMapper.Map<Venda>(vendaDTO));
           return _autoMapper.Map<VendaDTO>(createdVenda);
        }

        public VendaDTO UpdateVenda(int id, AtualizaVendaDTO vendaDTO)
        {
            var vendaDB = _vendaRepository.GetByID(id);
            if (vendaDB == null) throw new VendaNotFoundException();
            vendaDB.AtualizarStatusVenda(vendaDTO.StatusVenda);
            return _autoMapper.Map<VendaDTO>(vendaDB);
        }

        public void ValidaQuantidadeProduto(CadastrarVendaDTO vendaDTO)
        {
            if (vendaDTO.Produtos.Count == 0)
            {
                throw new EmptyProductListException();
            }

            foreach(var produtos in vendaDTO.Produtos)
            {
                if (produtos.Quantidade < 1)
                {
                    throw new ArgumentException("A quantidade de produtos não pode ser menor ou igual a zero");
                }
            }
        }
    }
}
