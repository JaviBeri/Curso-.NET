namespace Proyecto_Tienda.Services
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        IEnumerable<T> GetAllBogus();
        //T GetById(int id);
        //void Add(T entity);
        //void Update(T entity);
        //void Delete(T entity);
    }
}

