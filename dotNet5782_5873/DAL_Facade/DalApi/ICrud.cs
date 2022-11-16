namespace DalApi;

public interface ICrud<T>
{
    T Add(T entity);  
    T Get(int id);
    T Update(T entity);
   
    T Delete(int id);
    //T deleteAll();
   //IEnumerable<T>
  
}
