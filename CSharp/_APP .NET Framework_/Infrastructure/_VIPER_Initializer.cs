using VIPER.Entity;
using System;
using System.Data.Entity;
using System.Drawing;
using System.Linq;

namespace VIPER.Infrastructure
{
    public class _VIPER_Initializer : CreateDatabaseIfNotExists<_VIPER_Context>
    {
        protected override void Seed(_VIPER_Context context)
        {
            base.Seed(context);
            InsertAutenticacao(context);
            InsertSistemaModuloFuncao(context);
            InsertParametro(context);
            InsertDominios(context);
            InsertDominioItens(context);
            InsertUsuario(context);
        }

        private void InsertAutenticacao(_VIPER_Context context)
        {
            if (context.Autenticacaos.Count() == 0)
            {
                context.Autenticacaos.Add(new Autenticacao { Usuario = "c8b76359-e3e7-4c08-af66-07428a9204a6", Senha = "1cb474993d9cd2161264579335325ba0" });
                context.SaveChanges();
            }
        }
		
        private void InsertSistemaModuloFuncao(_VIPER_Context context)
        {
            if (context.Sistemas.Count() == 0)
            {
                context.Sistemas.Add(new Sistema() { Codigo = "GERENCIADOR", Descricao = "Gerenciador de Sistemas", Tipo = "D", Interface = "H", Linha = 2, Tamanho = 120, Gerenciador = true, Ativo = true });
                context.SaveChanges();
            }

            if (context.Modulos.Count() == 0)
            {
                context.Modulos.Add(new Modulo() { Codigo = "MODULO", Descricao = "Gerenciador", Cor = 0, Navegacao = true, Administracao = false, SistemaId = 1, Imagem = ImageToByteArray(Properties.Resource.icon_manager_24) });
                context.SaveChanges();
            }

            if (context.Funcaos.Count() == 0)
            {
                context.Funcaos.Add(new Funcao() { Codigo = "SISTEMA", Descricao = "Definição de Sistemas", Tipo = "F", NomeAssembly = "VIPER.Gerenciador", NomeFormulario = "SistemaView", Manutencao = true, ModuloId = 1 });
                context.Funcaos.Add(new Funcao() { Codigo = "PARAMETRO", Descricao = "Definição de Parâmetros", Tipo = "F", NomeAssembly = "VIPER.Gerenciador", NomeFormulario = "ParametroView", Manutencao = true, ModuloId = 1 });
                context.Funcaos.Add(new Funcao() { Codigo = "GERADOR_RELATORIO", Descricao = "Gerador de Relatórios", Tipo = "F", NomeAssembly = "VIPER.Gerenciador", NomeFormulario = "GeradorRelatorioView", Manutencao = true, ModuloId = 1 });
                context.SaveChanges();
            }
        }

        private void InsertDominios(_VIPER_Context context)
        {
            if (context.Dominios.Count() == 0)
            {
                context.Dominios.Add(new Dominio() { Descricao = "Categoria de Parâmetros" }); 
                context.SaveChanges();
            }
        }

        private void InsertDominioItens(_VIPER_Context context)
        {
            if (context.DominioItems.Count() == 0)
            {
                context.DominioItems.Add(new DominioItem() { Descricao = "Administração do Sistema", Valor = "01", DominioId = 1 });
                context.SaveChanges();
            }
        }


        private void InsertParametro(_VIPER_Context context)
        {
            if (context.Parametros.Count() == 0)
            {
                context.Parametros.Add(new Parametro() { Descricao = "Tempo máximo de duração de bloqueios (segundos)", Codigo = "001", Tipo = "N", ValorPadrao = "30", PermiteUsuario = false, Categoria = "01" });
                context.Parametros.Add(new Parametro() { Descricao = "Versão do banco de dados", Codigo = "998", Tipo = "N", ValorPadrao = "1", PermiteUsuario = false, Categoria = "01" });
                context.Parametros.Add(new Parametro() { Descricao = "Versão do executável", Codigo = "999", Tipo = "T", ValorPadrao = "1.0.0.0", PermiteUsuario = false, Categoria = "01" });
                context.SaveChanges();
            }
        }

        private void InsertUsuario(_VIPER_Context context)
        {
            if (context.Usuarios.Count() == 0)
            {
                context.Usuarios.Add(new Usuario() { Login = "ADMIN", Nome = "Administrador do sistema", Senha = "9F7D83B27EE55477942C407B3EEB3AA4", Master = true, Bloqueado = false, Administrador = true, NuncaExpira = false, AlterarSenha = true, DiasExpirar = 90, DataAlteracao = DateTime.Today });
                context.SaveChanges();
            }
        }

        private byte[] ImageToByteArray(object img)
        {
            return (byte[])new ImageConverter().ConvertTo(img, typeof(byte[]));
        }
    }
}
