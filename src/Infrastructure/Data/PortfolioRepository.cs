namespace Infrastructure.Data
{
  public class PortfolioRepository : IPortfolioRepository
  {
    private readonly DbContext _context;

    public PortfolioRepository(DbContext context)
    {
      _context = context;
    }

    public ICollection<Portfolio> GetPortfolios()
    {
      return _context.Portfolios.ToList();
    }

    public Portfolio GetPortfolioById(string id)
    {
      return _context.Portfolios.FirstOrDefault(p => p.Id == id);
    }

    public void CreatePortfolio(Portfolio portfolio)
    {
      _context.Portfolios.Add(portfolio);
      _context.SaveChanges();
    }

    public void UpdatePortfolio(Portfolio portfolio)
    {
      _context.Portfolios.Update(portfolio);
      _context.SaveChanges();
    }

    public void DeletePortfolio(string id)
    {
      var portfolio = GetPortfolioById(id);
      _context.Portfolios.Remove(portfolio);
      _context.SaveChanges();
    }
  }
}