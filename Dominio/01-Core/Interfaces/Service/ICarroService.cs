using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio._01_Core.Interfaces.Service
{
    public interface ICarroService
    {
        void Adicionar(Carro carro);
        Carro BuscarPorId(int id);
        void Editar(Carro carro);
        List<Carro> Listar();
        void Remover(int id);
    }
}
