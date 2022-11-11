using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PaymentAPI.Models;
using PaymentAPI.Models.DTO;
using PaymentAPI.Services.Interfaces;
using Swashbuckle.AspNetCore.Annotations;
using PaymentAPI.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly IVendaService _vendaService;
        
        public PaymentController(IVendaService vendaService)
        {
            _vendaService = vendaService;
        }

        [Route("ObterVendaPorID/{id}")]
        [HttpGet]
        [SwaggerResponse(statusCode:200,description:"Sucesso ao obter dados da venda")]
        [SwaggerResponse(statusCode: 404, description: "Venda não encontrada")]
        public IActionResult Get(int id)
        {
            var venda = _vendaService.GetByID(id);
            if (venda == null)
            {
                return NotFound(new VendaNotFoundException().Message);
            }
            return Ok(venda);
        }

        [Route("AtualizarVenda/{id}")]
        [HttpPut]
        [SwaggerResponse(statusCode: 200, description: "Sucesso ao atualizar dados da venda")]
        [SwaggerResponse(statusCode: 400, description: "Falha ao atualizar dados  da venda")]
        [SwaggerResponse(statusCode: 404, description: "Venda não encontrada")]
        public IActionResult Update(int id, AtualizaVendaDTO vendaDTO)
        {
            try
            {
                var venda = _vendaService.UpdateVenda(id, vendaDTO);
                return Ok(venda);
            }
            catch(VendaNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
           
        }

        [Route("CadastrarVenda")]
        [HttpPost]
        [SwaggerResponse(statusCode: 200, description: "Sucesso ao cadastrar venda")]
        [SwaggerResponse(statusCode: 400, description: "Falha ao venda")]
        public IActionResult Post(CadastrarVendaDTO vendaDTO)
        {
            try
            {
                var venda = _vendaService.CreateVenda(vendaDTO);
                return Ok(venda);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
    }
}
