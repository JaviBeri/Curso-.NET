using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ClasesEmpleados.ClasesEmpresa
{
    public class Empresa
    {

        public Empresa(string nombre, int id)
        {
            Nombre = nombre;
            Id = id;
        }
        public string Nombre
        {
            get; set;
        }

        public int Id
        {
            get; set;
        }

        public override string ToString()
        {
            return $"Empresa: {Id}-{Nombre} ";
        }
    }
}