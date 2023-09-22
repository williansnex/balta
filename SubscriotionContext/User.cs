using Balta.SheredContext;

namespace Balta.ContentContext
{
  public class User : Base
  {
    public string? Username { get; set; }
    public string? Password { get; set; }
  }
}