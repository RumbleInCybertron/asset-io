using System.Data;

namespace Domain.Models
{
  public class Portfolio
  {
    private string m_name = "";
    private float m_ttlValue;
    private string m_userId = "";

    public required string Name
    {
      get { return m_name; }
      set
      {
        if (value == null) throw new NoNullAllowedException("Name cannot be null.");
        m_name = value;
      }

    }
    public required float Ttl_Value
    {
      get { return m_ttlValue; }
      set
      {
        if (value < 0.0f)
          throw new ArgumentOutOfRangeException(nameof(value),
            "Ttl_Value cannot be negative.");

        m_ttlValue = value;
      }
    }
    public required DateTime Created_At { get; set; }
    public required string UserId
    {
      get { return m_userId; }
      set
      {
        if (value == null) throw new NoNullAllowedException("UserId cannot be null.");
        m_userId = value;
      }
    }
  }

}