﻿using Ambev.DeveloperEvaluation.Domain.Entities;
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
                new Product { Id = Guid.NewGuid(), Name = "Laptop", Description = "High-performance laptop", Color = "Silver", Size = "15-inch", CreatedAt = DateTime.UtcNow },
                new Product { Id = Guid.NewGuid(), Name = "Wireless Mouse", Description = "Ergonomic wireless mouse", Color = "Black", Size = "Medium", CreatedAt = DateTime.UtcNow },
                new Product { Id = Guid.NewGuid(), Name = "Mechanical Keyboard", Description = "RGB backlit keyboard", Color = "White", Size = "Full-size", CreatedAt = DateTime.UtcNow },
                new Product { Id = Guid.NewGuid(), Name = "Gaming Monitor", Description = "144Hz refresh rate monitor", Color = "Black", Size = "27-inch", CreatedAt = DateTime.UtcNow },
                new Product { Id = Guid.NewGuid(), Name = "USB-C Hub", Description = "Multiport adapter", Color = "Grey", Size = "Compact", CreatedAt = DateTime.UtcNow },
                new Product { Id = Guid.NewGuid(), Name = "External Hard Drive", Description = "1TB storage drive", Color = "Black", Size = "Portable", CreatedAt = DateTime.UtcNow },
                new Product { Id = Guid.NewGuid(), Name = "Smartphone", Description = "Latest model smartphone", Color = "Blue", Size = "6-inch", CreatedAt = DateTime.UtcNow },
                new Product { Id = Guid.NewGuid(), Name = "Bluetooth Speaker", Description = "Portable wireless speaker", Color = "Red", Size = "Small", CreatedAt = DateTime.UtcNow },
                new Product { Id = Guid.NewGuid(), Name = "Noise Cancelling Headphones", Description = "Wireless noise-canceling headphones", Color = "Black", Size = "Over-ear", CreatedAt = DateTime.UtcNow },
                new Product { Id = Guid.NewGuid(), Name = "Smartwatch", Description = "Water-resistant smartwatch", Color = "Silver", Size = "40mm", CreatedAt = DateTime.UtcNow },
                new Product { Id = Guid.NewGuid(), Name = "Tablet", Description = "High-resolution tablet", Color = "Gold", Size = "10-inch", CreatedAt = DateTime.UtcNow },
                new Product { Id = Guid.NewGuid(), Name = "Graphic Tablet", Description = "Professional drawing tablet", Color = "Black", Size = "Large", CreatedAt = DateTime.UtcNow },
                new Product { Id = Guid.NewGuid(), Name = "Webcam", Description = "1080p HD webcam", Color = "Black", Size = "Compact", CreatedAt = DateTime.UtcNow },
                new Product { Id = Guid.NewGuid(), Name = "Microphone", Description = "Professional podcast microphone", Color = "Silver", Size = "Medium", CreatedAt = DateTime.UtcNow },
                new Product { Id = Guid.NewGuid(), Name = "VR Headset", Description = "Virtual reality headset", Color = "Black", Size = "Adjustable", CreatedAt = DateTime.UtcNow },
                new Product { Id = Guid.NewGuid(), Name = "Drone", Description = "4K camera drone", Color = "White", Size = "Portable", CreatedAt = DateTime.UtcNow },
                new Product { Id = Guid.NewGuid(), Name = "Portable SSD", Description = "Fast external SSD", Color = "Black", Size = "500GB", CreatedAt = DateTime.UtcNow },
                new Product { Id = Guid.NewGuid(), Name = "HDMI Cable", Description = "High-speed HDMI cable", Color = "Black", Size = "6ft", CreatedAt = DateTime.UtcNow },
                new Product { Id = Guid.NewGuid(), Name = "Wireless Charger", Description = "Fast charging pad", Color = "White", Size = "Small", CreatedAt = DateTime.UtcNow },
                new Product { Id = Guid.NewGuid(), Name = "Gaming Chair", Description = "Ergonomic gaming chair", Color = "Red", Size = "Large", CreatedAt = DateTime.UtcNow },
                new Product { Id = Guid.NewGuid(), Name = "Smart Bulb", Description = "WiFi-enabled LED bulb", Color = "Multi-color", Size = "Standard", CreatedAt = DateTime.UtcNow },
                new Product { Id = Guid.NewGuid(), Name = "Portable Power Bank", Description = "10000mAh fast-charging power bank", Color = "Black", Size = "Compact", CreatedAt = DateTime.UtcNow },
                new Product { Id = Guid.NewGuid(), Name = "Fitness Tracker", Description = "Activity tracking smartwatch", Color = "Blue", Size = "Medium", CreatedAt = DateTime.UtcNow },
                new Product { Id = Guid.NewGuid(), Name = "Coffee Maker", Description = "Automatic drip coffee maker", Color = "Silver", Size = "Medium", CreatedAt = DateTime.UtcNow },
                new Product { Id = Guid.NewGuid(), Name = "Air Purifier", Description = "HEPA filter air purifier", Color = "White", Size = "Large", CreatedAt = DateTime.UtcNow },
                new Product { Id = Guid.NewGuid(), Name = "Electric Toothbrush", Description = "Rechargeable electric toothbrush", Color = "White", Size = "Small", CreatedAt = DateTime.UtcNow },
                new Product { Id = Guid.NewGuid(), Name = "Standing Desk", Description = "Adjustable height standing desk", Color = "Brown", Size = "Large", CreatedAt = DateTime.UtcNow },
                new Product { Id = Guid.NewGuid(), Name = "Robot Vacuum", Description = "Smart robotic vacuum cleaner", Color = "Black", Size = "Compact", CreatedAt = DateTime.UtcNow }
            };
            return productsList;
        }

        public IEnumerable<Branch> GetBranches()
        {
            var branchesList = new List<Branch>
            {
                new Branch { Id = Guid.NewGuid(), Name = "Loja Centro", Location = "Rua das Flores, 123, Centro", CreatedAt = DateTime.UtcNow },
                new Branch { Id = Guid.NewGuid(), Name = "Shopping Outlet", Location = "Avenida Comercial, 456, Shopping Central", CreatedAt = DateTime.UtcNow },
                new Branch { Id = Guid.NewGuid(), Name = "Tech Hub", Location = "Rua Inovação, 789, Distrito Tecnológico", CreatedAt = DateTime.UtcNow },
                new Branch { Id = Guid.NewGuid(), Name = "Loja Suburbana", Location = "Avenida das Palmeiras, 321, Bairro Residencial", CreatedAt = DateTime.UtcNow },
                new Branch { Id = Guid.NewGuid(), Name = "Quiosque Aeroporto", Location = "Terminal 1, Aeroporto Internacional", CreatedAt = DateTime.UtcNow },
                new Branch { Id = Guid.NewGuid(), Name = "Loja Universitária", Location = "Praça Acadêmica, Avenida Universidade", CreatedAt = DateTime.UtcNow },
                new Branch { Id = Guid.NewGuid(), Name = "Loja Empresarial", Location = "Parque Corporativo, 500, Área de Negócios", CreatedAt = DateTime.UtcNow },
                new Branch { Id = Guid.NewGuid(), Name = "Outlet Praia", Location = "Avenida Beira-Mar, 100, Região Costeira", CreatedAt = DateTime.UtcNow },
                new Branch { Id = Guid.NewGuid(), Name = "Loja Serra", Location = "Rua das Montanhas, 200, Região Serrana", CreatedAt = DateTime.UtcNow },
                new Branch { Id = Guid.NewGuid(), Name = "Loja Industrial", Location = "Rua das Fábricas, 600, Polo Industrial", CreatedAt = DateTime.UtcNow }
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
