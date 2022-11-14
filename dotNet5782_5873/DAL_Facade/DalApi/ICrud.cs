namespace DalApi;

public interface ICrud<T>
{
    T add(T entity);
    T Get(int id);
    T update(T entity);
    T delete(int id);
    //T deleteAll();
   //IEnumerable<T>
  
}
