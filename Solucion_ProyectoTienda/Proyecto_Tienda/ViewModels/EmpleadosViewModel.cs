namespace Proyecto_Tienda.ViewModels;
public class EmpleadosViewModel
{
    public IEnumerable<Empleado> EmpleadosOriginal { get; set; }
    public IEnumerable<Empleado> EmpleadosInvertidos { get; set; }
    public IEnumerable<Empleado> EmpleadosSkip { get; set; }
    public IEnumerable<Empleado> EmpleadosTakeWhile { get; set; }
    public IEnumerable<IGrouping<Departamento, Empleado>> EmpleadosFiltrarOrdenarAgrupar { get; set; }
}
