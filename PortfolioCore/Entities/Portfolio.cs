namespace PortfolioCore.Entities
{
    public class Portfolio
    {
       // internal object category;

        public int PortfolioId { get; set; }
        public string Title { get; set; }
        public string Description  { get; set; }
        public string ImageUrl  { get; set; }
        public int CategoryId  { get; set; }
        public Category Category  { get; set; }
    }
}
