using ClasesEmpleados.ClasesEmpresa;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploHerenciaProyecto
{
    public class CompanyMap : ClassMap<Empresa>
    {
        public CompanyMap()
        {
            // Define el mapeo para que los campos se escriban en minúsculas
            Map(m => m.Nombre).Name("name");
            Map(m => m.Id).Name("id");
        }
    }
}
