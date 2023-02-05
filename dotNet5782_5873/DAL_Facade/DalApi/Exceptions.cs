using System.Runtime.CompilerServices;

namespace DalApi;
/// <summary>
/// This exception will be thrown if an entity not find
/// </summary>
public class EntityNotFoundException : Exception
{
    
    /// <summary>
    /// Error details. What occurred and in which function
    /// </summary>
    public string ErrorMessage { get; init; }

    /// <summary>
    /// EntityNotFoundException constructor
    /// </summary>
    /// <param name="message"></param>
    public EntityNotFoundException(string message)
    {
        ErrorMessage = message;
        Console.WriteLine("Exception: An error occurred in "+message);
       
    }
    
}

/// <summary>
/// This exception will be thrown if a convert failed
/// </summary>
public class FailedToConvertException : Exception
{
    
    /// <summary>
    /// Error details. What occurred and in which function
    /// </summary>
    public string ErrorMessage { get; init; }

    /// <summary>
    /// FailedToConvertException constructor
    /// </summary>
    /// <param name="message"></param>
    public FailedToConvertException(string message)
    {
        ErrorMessage = message;
        Console.WriteLine("Exception: An error occurred in " + message);

    }

}


/// <summary>
/// This exception will be thrown if a duplicate entity is found
/// </summary>
public class DuplicateIdException : Exception
{
    /// <summary>
    /// The duplicate id
    /// </summary>
    public int DuplicateId { get; init; }
   
    /// <summary>
    /// Error details. What occurred and in which function
    /// </summary>
    public string ErrorMessage { get; init; }

    /// <summary>
    /// DuplicateIdException constructor
    /// </summary>
    /// <param name="Id"></param>
    /// <param name="message"></param>
    public DuplicateIdException(int Id, string message) {
        DuplicateId = Id;
        ErrorMessage= message;
        Console.WriteLine("Exception: An error occurred in " + message+"\nDouble ID id: "+DuplicateId);

    }

}

/// <summary>
/// This exception will be thrown if an invalid entity is found
/// </summary>
public class InvalidEntityException : Exception {

    /// <summary>
    /// Error details. What occurred and in which function
    /// </summary>
    public string ErrorMessage { get; init; }

    /// <summary>
    /// InvalidEntityException constructor
    /// </summary>
    /// <param name="message"></param>
    public InvalidEntityException(string message)
    {
        ErrorMessage = message;
        Console.WriteLine("Exception: An error occurred in " + message);
    }
}
