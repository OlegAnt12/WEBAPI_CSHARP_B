using DTO;
using Hieratica.MODEL;

namespace Service;

public static class ClienteService
{
    public static Cliente ToClienteServiceDTO ( this NovoCliente novoCliente)
        {
            return new Cliente
            {
                Nome = novoCliente.Nome,
                BilheteIdentidade = novoCliente.BilheteIdentidade,
                NIF = novoCliente.NIF,
                NIS = novoCliente.NIS,
                DenominacaoSocial = novoCliente.DenominacaoSocial

            };
        }
}
