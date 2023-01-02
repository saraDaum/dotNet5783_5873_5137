using DO;

namespace DalApi;

public interface ICrud<T>
{
    /// <summary>
    /// This function gets an oject and enters it to the list. Than, it returns the object ID. 
    /// </summary>
    /// <param name="entity"></param>
    /// <returns></returns>
    int Add(T entity);

    /// <summary>
    /// This funtion gets
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    T GetById(Predicate<T> myDelegate);

    /// <summary>
    /// This function gets a updated object and update the old one.   
    /// </summary>
    /// <param name="entity"></param>
    void Update(T entity);

    /// <summary>
    /// This function gets an ID and delete the match item from list.
    /// </summary>
    /// <param name="id"></param>
   void Delete(int id);

    /// <summary>
    /// This function get a deligate and return the objects that match to the condition.
    /// </summary>
    /// <param name="deligate"></param>
    /// <returns></returns>
    IEnumerable<T>? Get(Func<T, bool>? deligate);

}
