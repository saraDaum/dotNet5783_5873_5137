using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class somethingWrong : Exception
    {
        public somethingWrong(string message, Exception inner) : base(message, inner) { }

    }

    /// <summary>
    /// This exception will be thrown if an entity not find
    /// </summary>
    internal class EntityNotFoundException : Exception
    {

        /// <summary>
        /// EntityNotFoundException constructor
        /// </summary>
        /// <param name="message"></param>
        public EntityNotFoundException(string message, Exception ex) : base(message, ex) { }

    }


    /// <summary>
    /// This exception will be thrown if a convert failed
    /// </summary>
    internal class FailedToConvertException : Exception
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
    internal class DuplicateEntityException : Exception
    {
        public DuplicateEntityException(string message, Exception ex) : base(message, ex) { }

    }

    /// <summary>
    /// This exception will be thrown if an invalid entity is found
    /// </summary>
    internal class InvalidEntityException : Exception
    {
        /// <summary>
        /// InvalidEntityException constructor
        /// </summary>
        /// <param name="message"></param>
        public InvalidEntityException(string message, Exception ex) : base(message, ex) { 
           
        }
    }

}
