namespace DalApi;

public interface ICrud<T>
{
    int Add(T entity);
    T GetById(int id);
    void Update(T entity);
    void Delete(int id);
    //T deleteAll();
    //IEnumerable<T>

}
