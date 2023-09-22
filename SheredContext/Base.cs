using Balta.NotificationContext;

namespace Balta.SheredContext
{
  public abstract class Base : Notfiable
  {
    public Base()
    {
      Id = Guid.NewGuid();
    }
    public Guid Id { get; set; }
  }
}