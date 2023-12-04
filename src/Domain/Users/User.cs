using System.Data;
using AssetIO.Domain;
using Domain.Portfolios;

namespace Domain.Users
{
  public class User: EntityBase
  {
    private string m_email = "";
    private string m_password = "";
    private string m_username = "";

    public required string Email
    {
      get { return m_email; }
      set
      {
        if (value == null) throw new NoNullAllowedException("Email cannot be null.");
        m_email = value;
      }
    }
    public required string Password
    {
      get { return m_password; }
      set
      {
        if (value == null) throw new NoNullAllowedException("Password cannot be null.");
        m_password = value;
      }
    }
    public required string Username
    {
      get { return m_username; }
      set
      {
        if (value == null) throw new NoNullAllowedException("Username cannot be null.");
        m_username = value;
      }
    }
    public Portfolio? Portfolio { get; set; }
  }
}

// TODO: Add value object for Name and change Username to FirstName and LastName