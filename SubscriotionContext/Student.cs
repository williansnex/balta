using Balta.SheredContext;

namespace Balta.ContentContext
{
  public class Student : Base
  {
    public string? Name { get; set; }
    public string? Email { get; set; }
    public User? User { get; set; }

    public required IList<Subscription> Subscriptions { get; set; }

    public bool IsPrimium => Subscriptions.Any(x => !x.IsInactive);
  }
}