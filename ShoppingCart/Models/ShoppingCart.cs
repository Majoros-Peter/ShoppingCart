namespace ShoppingCartProject.Models
{
    public class ShoppingCart
    {
        private readonly List<Product> _products;

        public ShoppingCart()
        {
            _products = new List<Product>();
        }

        public int ProductCount => _products.Count;

        //TODO Készítse el a ShoppingCart osztályban azokat a metódusokat, amelyekkel sikeresen lefutnak a tesztesetek!

        public void AddProduct(string name, double price)
            => _products.Add(new(name, price));

        public void RemoveProduct(string name)
        {
            int index = _products.FindIndex(G => G.Name == name);
            if (index == -1)
                throw new InvalidOperationException("Ez így nem lesz jó öcsisajt.");
            _products.RemoveAt(index);
        }

        public double GetTotalPrice()
            => _products.Sum(p => p.Price);

        public ICollection<Product> GetProducts()
            => _products;
    }
}
