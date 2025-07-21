using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padarosa.Model
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nome { get; set; }


        public int Cadastrar()
        {
            return 0;
        }

        public DataTable Listar()
        {
            return new DataTable();
        }

        public int Excluir()
        {
            return 0;
        }

        public int Modificar()
        {
            return 0;
        }



     }
}

