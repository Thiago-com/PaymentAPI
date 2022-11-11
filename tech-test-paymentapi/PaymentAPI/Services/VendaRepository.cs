using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PaymentAPI.Repository;
using PaymentAPI.Repository.Interfaces;
using PaymentAPI.Models.Entity;

namespace PaymentAPI.Services
{
    public class VendaRepository:IVendaRepository
    {
        private readonly Context _dbContext;

        public VendaRepository(Context context)
        {
            _dbContext = context;
        }
        public Venda GetByID(int id)
        {
            return _dbContext.Vendas.Include((v) => v.Vendedor)
              .Include((v) => v.Produtos).Where(s => s.ID == id).FirstOrDefault();
        }

        public Venda CreateVenda(Venda venda)
        {
            var vendaCriada = _dbContext.Add(venda);
            _dbContext.SaveChanges();
            return vendaCriada.Entity;
        }
        public Venda UpdateVenda(Venda venda)
        {
            var vendaAtualiazada = _dbContext.Update(venda);
            _dbContext.SaveChangesAsync();
            return vendaAtualiazada.Entity;
        }
    }
}
