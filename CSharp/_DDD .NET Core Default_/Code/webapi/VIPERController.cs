//
//  __MODULENAME__Controller.cs
//  __APPNAME__
//
//  Created by __USERNAME__ on __DATETIME__.
//  Copyright © __YEAR__ __ORGANIZATIONNAME__. All rights reserved.
//

using NAMESPACE.Database;
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

        [HttpPost]
        public IActionResult Post([FromBody] VIPER entity)
        {
            using (var context = new _NAMESPACE_Context())
            {
                using (var transacao = context.Database.BeginTransaction())
                {
                    using (var repository = new VIPERRepository(context))
                    {
						_mensagem = repository.Incluir(entity);
                        
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
		
		[HttpPut]
        public IActionResult Put([FromBody] VIPER entity)
        {
            using (var context = new _NAMESPACE_Context())
            {
                using (var transacao = context.Database.BeginTransaction())
                {
                    using (var repository = new VIPERRepository(context))
                    {
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

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
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

        [HttpGet("{id}")]
        public ActionResult<VIPER> Get(int id)
        {
            using var repository = new VIPERRepository();
            return repository.Selecionar(id);
        }

        [HttpGet]
        public IEnumerable<VIPER> GetAll()
        {
            using var repository = new VIPERRepository();
            return repository.SelecionarTodos();
        }

        [HttpGet("filter")]
        public IEnumerable<VIPER> Filter(string condicao)
        {
            using var repository = new VIPERRepository();
            return repository.Filtrar(condicao);
        }
    }
}
