namespace DalApi;

public class EntityNotFoundException : Exception
{
    public int Id { get; init; }
    public Type EntityType { get; init; }
}
public class DuplicateIdException : Exception
{
    public int DuplicateId { get; init; }
    public Type EntityType { get; init; }

}