using System.Data;

namespace Domain
{
  public class EntityBase
  {
    private string m_id = "";

    public string Id
    {
      get { return m_id; }
      set
      {
        if (value == null) throw new NoNullAllowedException("Id cannot be null.");
        m_id = value;
      }
    }
  }
}