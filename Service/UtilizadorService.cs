using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DTO;
using Hieratica.MODEL;

namespace Hieratica.Service
{
    public static class UtilizadorService
    {
        public static Utilizador ToUtilizadorServiceDTO ( this NovoUtilizadorDTO novoUtilizador)
        {
            return new Utilizador
            {
                NomeCompleto = novoUtilizador.NomeCompleto,
                Username = novoUtilizador.Username,
                senha = novoUtilizador.senha,
                Email = novoUtilizador.Email,
                Telelefone = novoUtilizador.Telelefone,
                BilheteIdentidade = novoUtilizador.BilheteIdentidade,
                empresa = novoUtilizador.empresa,
                perfil = novoUtilizador.perfil,
                estadoConta= novoUtilizador.estadoConta

            };
        }

        public static Utilizador ToUtilizadorAdminServiceDTO ( this NovoUtilizadorDTO novoUtilizador)
        {
            return new Utilizador
            {
                NomeCompleto = novoUtilizador.NomeCompleto,
                Username = novoUtilizador.Username,
                senha = novoUtilizador.senha,
                Email = novoUtilizador.Email,
                Telelefone = novoUtilizador.Telelefone,
                BilheteIdentidade = novoUtilizador.BilheteIdentidade,
                empresa = novoUtilizador.empresa,
                perfil = Perfil.Administrador,
                estadoConta= novoUtilizador.estadoConta

            };
        }
    }
}