namespace DalApi;

internal interface IDal<T>
{
    public IOrder order { get; }
    public IOrderItem orderItem { get; }
    public IProduct Product { get; }


}
