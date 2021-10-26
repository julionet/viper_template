using VIPER.Controller.Helpers;
using VIPER.Entity;
using VIPER.Repository;
using Microsoft.AspNetCore.Mvc;

namespace VIPER.Controller.Controllers
{
    [ApiController]
    [Route("api/auth")]
    public class AutenticacaoController : ControllerBase
    {
        [HttpPost]
        public ActionResult<dynamic> Authenticate([FromBody] Autenticacao model)
        {
            var achou = new AutenticacaoRepository().Check(model.Usuario, model.Senha);
            if (!achou)
                return BadRequest(new { Message = "Credenciais inválidas" });

            var token = TokenService.GenerateToken(model);

            return new
            {
                Token = token
            };
        }
    }
}