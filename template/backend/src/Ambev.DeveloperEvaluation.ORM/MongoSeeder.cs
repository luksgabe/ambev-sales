using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using Ambev.DeveloperEvaluation.ORM.Options;
using MongoDB.Driver;

namespace Ambev.DeveloperEvaluation.ORM
{
    public class MongoSeeder
    {
        protected IMongoCollection<Product> _productCollection;
        protected IMongoCollection<Branch> _branchCollection;

        public MongoSeeder(IMongoDatabaseSettings mongoSettings)
        {
            var client = new MongoClient(mongoSettings.ConnectionString);
            var database = client.GetDatabase(mongoSettings.DatabaseName);

            _productCollection = database.GetCollection<Product>(nameof(Product));
            _branchCollection = database.GetCollection<Branch>(nameof(Branch));
        }

        public IEnumerable<Product> GetProducts()
        {
            var productsList = new List<Product>
            {
                new Product { Id = new Guid("11111111-1111-1111-1111-111111111101"), Name = "Laptop", Description = "High-performance laptop", Color = "Silver", Size = "15-inch", CreatedAt = DateTime.UtcNow },
                new Product { Id = new Guid("11111111-1111-1111-1111-111111111102"), Name = "Wireless Mouse", Description = "Ergonomic wireless mouse", Color = "Black", Size = "Medium", CreatedAt = DateTime.UtcNow },
                new Product { Id = new Guid("11111111-1111-1111-1111-111111111103"), Name = "Mechanical Keyboard", Description = "RGB backlit keyboard", Color = "White", Size = "Full-size", CreatedAt = DateTime.UtcNow },
                new Product { Id = new Guid("11111111-1111-1111-1111-111111111104"), Name = "Gaming Monitor", Description = "144Hz refresh rate monitor", Color = "Black", Size = "27-inch", CreatedAt = DateTime.UtcNow },
                new Product { Id = new Guid("11111111-1111-1111-1111-111111111105"), Name = "USB-C Hub", Description = "Multiport adapter", Color = "Grey", Size = "Compact", CreatedAt = DateTime.UtcNow },
                new Product { Id = new Guid("11111111-1111-1111-1111-111111111106"), Name = "External Hard Drive", Description = "1TB storage drive", Color = "Black", Size = "Portable", CreatedAt = DateTime.UtcNow },
                new Product { Id = new Guid("11111111-1111-1111-1111-111111111107"), Name = "Smartphone", Description = "Latest model smartphone", Color = "Blue", Size = "6-inch", CreatedAt = DateTime.UtcNow },
                new Product { Id = new Guid("11111111-1111-1111-1111-111111111108"), Name = "Bluetooth Speaker", Description = "Portable wireless speaker", Color = "Red", Size = "Small", CreatedAt = DateTime.UtcNow },
                new Product { Id = new Guid("11111111-1111-1111-1111-111111111109"), Name = "Noise Cancelling Headphones", Description = "Wireless noise-canceling headphones", Color = "Black", Size = "Over-ear", CreatedAt = DateTime.UtcNow },
                new Product { Id = new Guid("11111111-1111-1111-1111-11111111110A"), Name = "Smartwatch", Description = "Water-resistant smartwatch", Color = "Silver", Size = "40mm", CreatedAt = DateTime.UtcNow },
                new Product { Id = new Guid("11111111-1111-1111-1111-11111111110B"), Name = "Tablet", Description = "High-resolution tablet", Color = "Gold", Size = "10-inch", CreatedAt = DateTime.UtcNow },
                new Product { Id = new Guid("11111111-1111-1111-1111-11111111110C"), Name = "Graphic Tablet", Description = "Professional drawing tablet", Color = "Black", Size = "Large", CreatedAt = DateTime.UtcNow },
                new Product { Id = new Guid("11111111-1111-1111-1111-11111111110D"), Name = "Webcam", Description = "1080p HD webcam", Color = "Black", Size = "Compact", CreatedAt = DateTime.UtcNow },
                new Product { Id = new Guid("11111111-1111-1111-1111-11111111110E"), Name = "Microphone", Description = "Professional podcast microphone", Color = "Silver", Size = "Medium", CreatedAt = DateTime.UtcNow },
                new Product { Id = new Guid("11111111-1111-1111-1111-11111111110F"), Name = "VR Headset", Description = "Virtual reality headset", Color = "Black", Size = "Adjustable", CreatedAt = DateTime.UtcNow },
                new Product { Id = new Guid("11111111-1111-1111-1111-111111111110"), Name = "Drone", Description = "4K camera drone", Color = "White", Size = "Portable", CreatedAt = DateTime.UtcNow },
                new Product { Id = new Guid("11111111-1111-1111-1111-111111111111"), Name = "Portable SSD", Description = "Fast external SSD", Color = "Black", Size = "500GB", CreatedAt = DateTime.UtcNow },
                new Product { Id = new Guid("11111111-1111-1111-1111-111111111112"), Name = "HDMI Cable", Description = "High-speed HDMI cable", Color = "Black", Size = "6ft", CreatedAt = DateTime.UtcNow },
                new Product { Id = new Guid("11111111-1111-1111-1111-111111111113"), Name = "Wireless Charger", Description = "Fast charging pad", Color = "White", Size = "Small", CreatedAt = DateTime.UtcNow },
                new Product { Id = new Guid("11111111-1111-1111-1111-111111111114"), Name = "Gaming Chair", Description = "Ergonomic gaming chair", Color = "Red", Size = "Large", CreatedAt = DateTime.UtcNow },
                new Product { Id = new Guid("11111111-1111-1111-1111-111111111115"), Name = "Smart Bulb", Description = "WiFi-enabled LED bulb", Color = "Multi-color", Size = "Standard", CreatedAt = DateTime.UtcNow },
                new Product { Id = new Guid("11111111-1111-1111-1111-111111111116"), Name = "Portable Power Bank", Description = "10000mAh fast-charging power bank", Color = "Black", Size = "Compact", CreatedAt = DateTime.UtcNow },
                new Product { Id = new Guid("11111111-1111-1111-1111-111111111117"), Name = "Fitness Tracker", Description = "Activity tracking smartwatch", Color = "Blue", Size = "Medium", CreatedAt = DateTime.UtcNow },
                new Product { Id = new Guid("11111111-1111-1111-1111-111111111118"), Name = "Coffee Maker", Description = "Automatic drip coffee maker", Color = "Silver", Size = "Medium", CreatedAt = DateTime.UtcNow },
                new Product { Id = new Guid("11111111-1111-1111-1111-111111111119"), Name = "Air Purifier", Description = "HEPA filter air purifier", Color = "White", Size = "Large", CreatedAt = DateTime.UtcNow },
                new Product { Id = new Guid("11111111-1111-1111-1111-11111111111A"), Name = "Electric Toothbrush", Description = "Rechargeable electric toothbrush", Color = "White", Size = "Small", CreatedAt = DateTime.UtcNow },
                new Product { Id = new Guid("11111111-1111-1111-1111-11111111111B"), Name = "Standing Desk", Description = "Adjustable height standing desk", Color = "Brown", Size = "Large", CreatedAt = DateTime.UtcNow },
                new Product { Id = new Guid("11111111-1111-1111-1111-11111111111C"), Name = "Robot Vacuum", Description = "Smart robotic vacuum cleaner", Color = "Black", Size = "Compact", CreatedAt = DateTime.UtcNow },
                new Product { Id = new Guid("11111111-1111-1111-1111-11111111111D"), Name = "Smart Thermostat", Description = "Programmable smart thermostat", Color = "White", Size = "Standard", CreatedAt = DateTime.UtcNow },
                new Product { Id = new Guid("11111111-1111-1111-1111-11111111111E"), Name = "Home Theater System", Description = "Surround sound home theater system", Color = "Black", Size = "Large", CreatedAt = DateTime.UtcNow },
                new Product { Id = new Guid("11111111-1111-1111-1111-11111111111F"), Name = "Action Camera", Description = "4K action camera", Color = "Black", Size = "Compact", CreatedAt = DateTime.UtcNow },
                new Product { Id = new Guid("11111111-1111-1111-1111-111111111120"), Name = "Smart Lock", Description = "Bluetooth enabled smart lock", Color = "Silver", Size = "Standard", CreatedAt = DateTime.UtcNow },
                new Product { Id = new Guid("11111111-1111-1111-1111-111111111121"), Name = "Portable Projector", Description = "Mini portable projector", Color = "White", Size = "Small", CreatedAt = DateTime.UtcNow },
                new Product { Id = new Guid("11111111-1111-1111-1111-111111111122"), Name = "E-Reader", Description = "E-ink display e-reader", Color = "Black", Size = "Pocket", CreatedAt = DateTime.UtcNow },
                new Product { Id = new Guid("11111111-1111-1111-1111-111111111123"), Name = "Smart Glasses", Description = "Augmented reality smart glasses", Color = "Black", Size = "Standard", CreatedAt = DateTime.UtcNow },
                new Product { Id = new Guid("11111111-1111-1111-1111-111111111124"), Name = "Wireless Earbuds", Description = "True wireless earbuds", Color = "White", Size = "Small", CreatedAt = DateTime.UtcNow },
                new Product { Id = new Guid("11111111-1111-1111-1111-111111111125"), Name = "Portable Charger", Description = "Compact portable charger", Color = "Black", Size = "Small", CreatedAt = DateTime.UtcNow },
                new Product { Id = new Guid("11111111-1111-1111-1111-111111111126"), Name = "Gaming Console", Description = "Next-gen gaming console", Color = "Black", Size = "Standard", CreatedAt = DateTime.UtcNow },
                new Product { Id = new Guid("11111111-1111-1111-1111-111111111127"), Name = "Smart Refrigerator", Description = "WiFi-connected smart refrigerator", Color = "Stainless Steel", Size = "Large", CreatedAt = DateTime.UtcNow },
                new Product { Id = new Guid("11111111-1111-1111-1111-111111111128"), Name = "Digital Camera", Description = "High-resolution digital camera", Color = "Black", Size = "Compact", CreatedAt = DateTime.UtcNow },
                new Product { Id = new Guid("11111111-1111-1111-1111-111111111129"), Name = "Smart Speaker", Description = "Voice-controlled smart speaker", Color = "Black", Size = "Standard", CreatedAt = DateTime.UtcNow },
                new Product { Id = new Guid("11111111-1111-1111-1111-11111111112A"), Name = "Electric Scooter", Description = "Eco-friendly electric scooter", Color = "Green", Size = "Medium", CreatedAt = DateTime.UtcNow },
                new Product { Id = new Guid("11111111-1111-1111-1111-11111111112B"), Name = "VR Controller", Description = "Wireless VR controller", Color = "Black", Size = "Standard", CreatedAt = DateTime.UtcNow },
                new Product { Id = new Guid("11111111-1111-1111-1111-11111111112C"), Name = "Smart Oven", Description = "Convection smart oven", Color = "Stainless Steel", Size = "Large", CreatedAt = DateTime.UtcNow },
                new Product { Id = new Guid("11111111-1111-1111-1111-11111111112D"), Name = "Electric Bike", Description = "Eco-friendly electric bike", Color = "Black", Size = "Standard", CreatedAt = DateTime.UtcNow },
                new Product { Id = new Guid("11111111-1111-1111-1111-11111111112E"), Name = "Noise Machine", Description = "White noise machine", Color = "White", Size = "Small", CreatedAt = DateTime.UtcNow },
                new Product { Id = new Guid("11111111-1111-1111-1111-11111111112F"), Name = "Smart Scale", Description = "Digital smart scale", Color = "Black", Size = "Standard", CreatedAt = DateTime.UtcNow },
                new Product { Id = new Guid("11111111-1111-1111-1111-111111111130"), Name = "Bluetooth Tracker", Description = "Tile-like Bluetooth tracker", Color = "Yellow", Size = "Small", CreatedAt = DateTime.UtcNow },
                new Product { Id = new Guid("11111111-1111-1111-1111-111111111131"), Name = "Wireless Router", Description = "High-speed wireless router", Color = "Black", Size = "Standard", CreatedAt = DateTime.UtcNow },
                new Product { Id = new Guid("11111111-1111-1111-1111-111111111132"), Name = "Smartwatch Pro", Description = "Advanced smartwatch", Color = "Space Gray", Size = "42mm", CreatedAt = DateTime.UtcNow }
            };
            return productsList;
        }

        public IEnumerable<Branch> GetBranches()
        {
            var branchesList = new List<Branch>
            {
                new Branch { Id = new Guid("22222222-2222-2222-2222-222222222201"), Name = "Loja Centro", Location = "Rua das Flores, 123, Centro", CreatedAt = DateTime.UtcNow },
                new Branch { Id = new Guid("22222222-2222-2222-2222-222222222202"), Name = "Shopping Outlet", Location = "Avenida Comercial, 456, Shopping Central", CreatedAt = DateTime.UtcNow },
                new Branch { Id = new Guid("22222222-2222-2222-2222-222222222203"), Name = "Tech Hub", Location = "Rua Inovação, 789, Distrito Tecnológico", CreatedAt = DateTime.UtcNow },
                new Branch { Id = new Guid("22222222-2222-2222-2222-222222222204"), Name = "Loja Suburbana", Location = "Avenida das Palmeiras, 321, Bairro Residencial", CreatedAt = DateTime.UtcNow },
                new Branch { Id = new Guid("22222222-2222-2222-2222-222222222205"), Name = "Quiosque Aeroporto", Location = "Terminal 1, Aeroporto Internacional", CreatedAt = DateTime.UtcNow },
                new Branch { Id = new Guid("22222222-2222-2222-2222-222222222206"), Name = "Loja Universitária", Location = "Praça Acadêmica, Avenida Universidade", CreatedAt = DateTime.UtcNow },
                new Branch { Id = new Guid("22222222-2222-2222-2222-222222222207"), Name = "Loja Empresarial", Location = "Parque Corporativo, 500, Área de Negócios", CreatedAt = DateTime.UtcNow },
                new Branch { Id = new Guid("22222222-2222-2222-2222-222222222208"), Name = "Outlet Praia", Location = "Avenida Beira-Mar, 100, Região Costeira", CreatedAt = DateTime.UtcNow },
                new Branch { Id = new Guid("22222222-2222-2222-2222-222222222209"), Name = "Loja Serra", Location = "Rua das Montanhas, 200, Região Serrana", CreatedAt = DateTime.UtcNow },
                new Branch { Id = new Guid("22222222-2222-2222-2222-222222222210"), Name = "Loja Industrial", Location = "Rua das Fábricas, 600, Polo Industrial", CreatedAt = DateTime.UtcNow }
            };
            return branchesList;
        }

        public async Task SeedAllAsync()
        {
            await SeedProductsAsync();
            await SeedBranchesAsync();
        }

        private async Task SeedProductsAsync()
        {
            try
            {
                var products = this.GetProducts();
                if (await _productCollection.CountDocumentsAsync(FilterDefinition<Product>.Empty) == 0)
                {
                    await _productCollection.InsertManyAsync(products);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private async Task SeedBranchesAsync()
        {
            var branches = this.GetBranches();
            if (await _branchCollection.CountDocumentsAsync(FilterDefinition<Branch>.Empty) == 0)
            {
                await _branchCollection.InsertManyAsync(branches);
            }
        }

        
    }
}
