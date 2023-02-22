using System.Runtime.CompilerServices;

namespace DalApi;
/// <summary>
/// This exception will be thrown if an entity not find
/// </summary>
public class EntityNotFoundException : Exception
{

    /// <summary>
    /// EntityNotFoundException constructor
    /// </summary>
    /// <param name="message"></param>
    public EntityNotFoundException(string message, Exception ex) : base(message, ex) { }

}

/// <summary>
/// This exception will be thrown if an error would occur in DalConfig
/// </summary>
public class DalConfigException : Exception
{
    public DalConfigException(string msg) : base(msg) { }
    public DalConfigException(string msg, Exception ex) : base(msg, ex) { }
}

/// <summary>
/// This exception will be thrown if a convert failed
/// </summary>
public class FailedToConvertException : Exception
{
    /// <summary>
    /// FailedToConvertException constructor
    /// </summary>
    /// <param name="message"></param>
    public FailedToConvertException(string message, Exception ex) : base(message, ex) { }
}


/// <summary>
/// This exception will be thrown if a duplicate entity is found
/// </summary>
public class DuplicateIdException : Exception
{
    public DuplicateIdException(string message, Exception ex) : base(message, ex) { }

}

/// <summary>
/// This exception will be thrown if an invalid entity is found
/// </summary>
public class InvalidEntityException : Exception
{
    /// <summary>
    /// InvalidEntityException constructor
    /// </summary>
    /// <param name="message"></param>
    public InvalidEntityException(string message, Exception ex) : base(message, ex) { }
}
