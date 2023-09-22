namespace Balta.NotificationContext
{

  public abstract class Notfiable
  {
    public List<Notification>? Notifications { get; set; }

    public Notfiable()
    {
      Notifications = new List<Notification>();
    }

    public void AddNotification(Notification notification)
    {
      Notifications?.Add(notification);
    }

    public void AddNotifications(IEnumerable<Notification> notification)
    {
      Notifications?.AddRange(notification);
    }

    public bool IsInvalid => Notifications.Any();
  }
}