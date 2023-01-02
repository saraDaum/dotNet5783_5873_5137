namespace DalApi;

public interface ICrud<T>
{
    int Add(T entity);
    T GetById(int id);
    IEnumerable<T?> GetAll();
    void Update(T entity);
    void Delete(int id);
    /// <summary>
    /// This function get a deligate and return the objects that match to the condition.
    /// </summary>
    /// <param name="deligate"></param>
    /// <returns></returns>
    IEnumerable<T>? Get(Func<T, bool>? deligate);

}
