using Domain.Portfolios;

namespace Domain.Repositories
{
    public interface IPortfolioRepository
    {
        ICollection<Portfolio> GetPortfolios();
        Portfolio GetPortfolioById(string id);
        void CreatePortfolio(Portfolio portfolio);
        void UpdatePortfolio(Portfolio portfolio);
        void DeletePortfolio(string id);
    }
}