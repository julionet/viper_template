//
//  __MODULENAME__Controller.cs
//  __APPNAME__
//
//  Created by __USERNAME__ on __DATETIME__.
//  Copyright © __YEAR__ __ORGANIZATIONNAME__. All rights reserved.
//

using NAMESPACE.Database;
using NAMESPACE.DTO;
using NAMESPACE.Entity;
using NAMESPACE.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace NAMESPACE.Controller.Controllers
{
    [Authorize]
    [Route("api/VIPER")]
    [ApiController]
    public class VIPERController : ControllerBase
    {
        private string _mensagem = "";

        [HttpPost("salvar")]
        public IActionResult Salvar([FromBody] VIPER entity)
        {
            using (var context = new _NAMESPACE_Context())
            {
                using (var transacao = context.Database.BeginTransaction())
                {
                    using (var repository = new VIPERRepository(context))
                    {
                        if (entity.Id == 0)
                            _mensagem = repository.Incluir(entity);
                        else
                            _mensagem = repository.Alterar(entity);

                        if (_mensagem == "")
                            transacao.Commit();
                        else
                            transacao.Rollback();
                    }
                }
            }
            if (_mensagem != "")
            {
                return BadRequest(_mensagem);
            }
            return Ok();
        }

        [HttpDelete("excluir/{id}")]
        public IActionResult Excluir(int id)
        {
            using (var context = new _NAMESPACE_Context())
            {
                using (var transacao = context.Database.BeginTransaction())
                {
                    using (var repository = new VIPERRepository(context))
                    {
                        _mensagem = repository.Excluir(id);
                        if (_mensagem == "")
                            transacao.Commit();
                        else
                            transacao.Rollback();
                    }
                }
            }
            if (_mensagem != "")
            {
                return BadRequest(_mensagem);
            }
            return Ok(); ;
        }

        [HttpGet("selecionar/{id}")]
        public ActionResult<VIPER> Selecionar(int id)
        {
            using var repository = new VIPERRepository();
            return repository.Selecionar(id);
        }

        [HttpGet("selecionartodos")]
        public IEnumerable<VIPER> SelecionarTodos()
        {
            using var repository = new VIPERRepository();
            return repository.SelecionarTodos();
        }

        [HttpPost("filtrar")]
        public IEnumerable<VIPER> Filtrar([FromBody] FiltroDTO filtro)
        {
            using var repository = new VIPERRepository();
            return repository.Filtrar(filtro.Condicao);
        }
    }
}
