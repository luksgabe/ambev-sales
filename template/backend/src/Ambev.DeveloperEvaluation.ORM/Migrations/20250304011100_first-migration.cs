using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ambev.DeveloperEvaluation.ORM.Migrations
{
    /// <inheritdoc />
    public partial class firstmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Branches",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Location = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branches", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    Name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    Color = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: true),
                    Size = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StoredEvent",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Data = table.Column<string>(type: "text", nullable: false),
                    Action = table.Column<string>(type: "varchar(100)", nullable: false),
                    AggregateId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoredEvent", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    Username = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Phone = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    Password = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Role = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    Status = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sales",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    SaleDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    BranchId = table.Column<Guid>(type: "uuid", nullable: false),
                    CustomerId = table.Column<Guid>(type: "uuid", nullable: false),
                    IsCancelled = table.Column<bool>(type: "boolean", nullable: false),
                    TotalSaleAmount = table.Column<decimal>(type: "numeric(10,2)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sales", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sales_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sales_Users_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SaleItems",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    UnitPrice = table.Column<decimal>(type: "numeric", nullable: false),
                    Discount = table.Column<decimal>(type: "numeric", nullable: false),
                    IsCancelled = table.Column<bool>(type: "boolean", nullable: false),
                    Quantity = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    SaleId = table.Column<Guid>(type: "uuid", nullable: false),
                    ProductId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaleItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SaleItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SaleItems_Sales_SaleId",
                        column: x => x.SaleId,
                        principalTable: "Sales",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "Id", "CreatedAt", "Location", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("22222222-2222-2222-2222-222222222201"), new DateTime(2025, 3, 4, 1, 10, 59, 927, DateTimeKind.Utc).AddTicks(7631), "Rua das Flores, 123, Centro", "Loja Centro", null },
                    { new Guid("22222222-2222-2222-2222-222222222202"), new DateTime(2025, 3, 4, 1, 10, 59, 927, DateTimeKind.Utc).AddTicks(7635), "Avenida Comercial, 456, Shopping Central", "Shopping Outlet", null },
                    { new Guid("22222222-2222-2222-2222-222222222203"), new DateTime(2025, 3, 4, 1, 10, 59, 927, DateTimeKind.Utc).AddTicks(7636), "Rua Inovação, 789, Distrito Tecnológico", "Tech Hub", null },
                    { new Guid("22222222-2222-2222-2222-222222222204"), new DateTime(2025, 3, 4, 1, 10, 59, 927, DateTimeKind.Utc).AddTicks(7638), "Avenida das Palmeiras, 321, Bairro Residencial", "Loja Suburbana", null },
                    { new Guid("22222222-2222-2222-2222-222222222205"), new DateTime(2025, 3, 4, 1, 10, 59, 927, DateTimeKind.Utc).AddTicks(7639), "Terminal 1, Aeroporto Internacional", "Quiosque Aeroporto", null },
                    { new Guid("22222222-2222-2222-2222-222222222206"), new DateTime(2025, 3, 4, 1, 10, 59, 927, DateTimeKind.Utc).AddTicks(7641), "Praça Acadêmica, Avenida Universidade", "Loja Universitária", null },
                    { new Guid("22222222-2222-2222-2222-222222222207"), new DateTime(2025, 3, 4, 1, 10, 59, 927, DateTimeKind.Utc).AddTicks(7644), "Parque Corporativo, 500, Área de Negócios", "Loja Empresarial", null },
                    { new Guid("22222222-2222-2222-2222-222222222208"), new DateTime(2025, 3, 4, 1, 10, 59, 927, DateTimeKind.Utc).AddTicks(7646), "Avenida Beira-Mar, 100, Região Costeira", "Outlet Praia", null },
                    { new Guid("22222222-2222-2222-2222-222222222209"), new DateTime(2025, 3, 4, 1, 10, 59, 927, DateTimeKind.Utc).AddTicks(7648), "Rua das Montanhas, 200, Região Serrana", "Loja Serra", null },
                    { new Guid("22222222-2222-2222-2222-222222222210"), new DateTime(2025, 3, 4, 1, 10, 59, 927, DateTimeKind.Utc).AddTicks(7650), "Rua das Fábricas, 600, Polo Industrial", "Loja Industrial", null }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Color", "CreatedAt", "Description", "Name", "Size", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("11111111-1111-1111-1111-111111111101"), "Silver", new DateTime(2025, 3, 4, 1, 10, 59, 927, DateTimeKind.Utc).AddTicks(7442), "High-performance laptop", "Laptop", "15-inch", null },
                    { new Guid("11111111-1111-1111-1111-111111111102"), "Black", new DateTime(2025, 3, 4, 1, 10, 59, 927, DateTimeKind.Utc).AddTicks(7446), "Ergonomic wireless mouse", "Wireless Mouse", "Medium", null },
                    { new Guid("11111111-1111-1111-1111-111111111103"), "White", new DateTime(2025, 3, 4, 1, 10, 59, 927, DateTimeKind.Utc).AddTicks(7448), "RGB backlit keyboard", "Mechanical Keyboard", "Full-size", null },
                    { new Guid("11111111-1111-1111-1111-111111111104"), "Black", new DateTime(2025, 3, 4, 1, 10, 59, 927, DateTimeKind.Utc).AddTicks(7450), "144Hz refresh rate monitor", "Gaming Monitor", "27-inch", null },
                    { new Guid("11111111-1111-1111-1111-111111111105"), "Grey", new DateTime(2025, 3, 4, 1, 10, 59, 927, DateTimeKind.Utc).AddTicks(7452), "Multiport adapter", "USB-C Hub", "Compact", null },
                    { new Guid("11111111-1111-1111-1111-111111111106"), "Black", new DateTime(2025, 3, 4, 1, 10, 59, 927, DateTimeKind.Utc).AddTicks(7455), "1TB storage drive", "External Hard Drive", "Portable", null },
                    { new Guid("11111111-1111-1111-1111-111111111107"), "Blue", new DateTime(2025, 3, 4, 1, 10, 59, 927, DateTimeKind.Utc).AddTicks(7457), "Latest model smartphone", "Smartphone", "6-inch", null },
                    { new Guid("11111111-1111-1111-1111-111111111108"), "Red", new DateTime(2025, 3, 4, 1, 10, 59, 927, DateTimeKind.Utc).AddTicks(7458), "Portable wireless speaker", "Bluetooth Speaker", "Small", null },
                    { new Guid("11111111-1111-1111-1111-111111111109"), "Black", new DateTime(2025, 3, 4, 1, 10, 59, 927, DateTimeKind.Utc).AddTicks(7460), "Wireless noise-canceling headphones", "Noise Cancelling Headphones", "Over-ear", null },
                    { new Guid("11111111-1111-1111-1111-11111111110a"), "Silver", new DateTime(2025, 3, 4, 1, 10, 59, 927, DateTimeKind.Utc).AddTicks(7462), "Water-resistant smartwatch", "Smartwatch", "40mm", null },
                    { new Guid("11111111-1111-1111-1111-11111111110b"), "Gold", new DateTime(2025, 3, 4, 1, 10, 59, 927, DateTimeKind.Utc).AddTicks(7464), "High-resolution tablet", "Tablet", "10-inch", null },
                    { new Guid("11111111-1111-1111-1111-11111111110c"), "Black", new DateTime(2025, 3, 4, 1, 10, 59, 927, DateTimeKind.Utc).AddTicks(7465), "Professional drawing tablet", "Graphic Tablet", "Large", null },
                    { new Guid("11111111-1111-1111-1111-11111111110d"), "Black", new DateTime(2025, 3, 4, 1, 10, 59, 927, DateTimeKind.Utc).AddTicks(7466), "1080p HD webcam", "Webcam", "Compact", null },
                    { new Guid("11111111-1111-1111-1111-11111111110e"), "Silver", new DateTime(2025, 3, 4, 1, 10, 59, 927, DateTimeKind.Utc).AddTicks(7468), "Professional podcast microphone", "Microphone", "Medium", null },
                    { new Guid("11111111-1111-1111-1111-11111111110f"), "Black", new DateTime(2025, 3, 4, 1, 10, 59, 927, DateTimeKind.Utc).AddTicks(7472), "Virtual reality headset", "VR Headset", "Adjustable", null },
                    { new Guid("11111111-1111-1111-1111-111111111110"), "White", new DateTime(2025, 3, 4, 1, 10, 59, 927, DateTimeKind.Utc).AddTicks(7474), "4K camera drone", "Drone", "Portable", null },
                    { new Guid("11111111-1111-1111-1111-111111111111"), "Black", new DateTime(2025, 3, 4, 1, 10, 59, 927, DateTimeKind.Utc).AddTicks(7475), "Fast external SSD", "Portable SSD", "500GB", null },
                    { new Guid("11111111-1111-1111-1111-111111111112"), "Black", new DateTime(2025, 3, 4, 1, 10, 59, 927, DateTimeKind.Utc).AddTicks(7477), "High-speed HDMI cable", "HDMI Cable", "6ft", null },
                    { new Guid("11111111-1111-1111-1111-111111111113"), "White", new DateTime(2025, 3, 4, 1, 10, 59, 927, DateTimeKind.Utc).AddTicks(7479), "Fast charging pad", "Wireless Charger", "Small", null },
                    { new Guid("11111111-1111-1111-1111-111111111114"), "Red", new DateTime(2025, 3, 4, 1, 10, 59, 927, DateTimeKind.Utc).AddTicks(7480), "Ergonomic gaming chair", "Gaming Chair", "Large", null },
                    { new Guid("11111111-1111-1111-1111-111111111115"), "Multi-color", new DateTime(2025, 3, 4, 1, 10, 59, 927, DateTimeKind.Utc).AddTicks(7482), "WiFi-enabled LED bulb", "Smart Bulb", "Standard", null },
                    { new Guid("11111111-1111-1111-1111-111111111116"), "Black", new DateTime(2025, 3, 4, 1, 10, 59, 927, DateTimeKind.Utc).AddTicks(7483), "10000mAh fast-charging power bank", "Portable Power Bank", "Compact", null },
                    { new Guid("11111111-1111-1111-1111-111111111117"), "Blue", new DateTime(2025, 3, 4, 1, 10, 59, 927, DateTimeKind.Utc).AddTicks(7485), "Activity tracking smartwatch", "Fitness Tracker", "Medium", null },
                    { new Guid("11111111-1111-1111-1111-111111111118"), "Silver", new DateTime(2025, 3, 4, 1, 10, 59, 927, DateTimeKind.Utc).AddTicks(7486), "Automatic drip coffee maker", "Coffee Maker", "Medium", null },
                    { new Guid("11111111-1111-1111-1111-111111111119"), "White", new DateTime(2025, 3, 4, 1, 10, 59, 927, DateTimeKind.Utc).AddTicks(7487), "HEPA filter air purifier", "Air Purifier", "Large", null },
                    { new Guid("11111111-1111-1111-1111-11111111111a"), "White", new DateTime(2025, 3, 4, 1, 10, 59, 927, DateTimeKind.Utc).AddTicks(7489), "Rechargeable electric toothbrush", "Electric Toothbrush", "Small", null },
                    { new Guid("11111111-1111-1111-1111-11111111111b"), "Brown", new DateTime(2025, 3, 4, 1, 10, 59, 927, DateTimeKind.Utc).AddTicks(7490), "Adjustable height standing desk", "Standing Desk", "Large", null },
                    { new Guid("11111111-1111-1111-1111-11111111111c"), "Black", new DateTime(2025, 3, 4, 1, 10, 59, 927, DateTimeKind.Utc).AddTicks(7492), "Smart robotic vacuum cleaner", "Robot Vacuum", "Compact", null },
                    { new Guid("11111111-1111-1111-1111-11111111111d"), "White", new DateTime(2025, 3, 4, 1, 10, 59, 927, DateTimeKind.Utc).AddTicks(7493), "Programmable smart thermostat", "Smart Thermostat", "Standard", null },
                    { new Guid("11111111-1111-1111-1111-11111111111e"), "Black", new DateTime(2025, 3, 4, 1, 10, 59, 927, DateTimeKind.Utc).AddTicks(7495), "Surround sound home theater system", "Home Theater System", "Large", null },
                    { new Guid("11111111-1111-1111-1111-11111111111f"), "Black", new DateTime(2025, 3, 4, 1, 10, 59, 927, DateTimeKind.Utc).AddTicks(7496), "4K action camera", "Action Camera", "Compact", null },
                    { new Guid("11111111-1111-1111-1111-111111111120"), "Silver", new DateTime(2025, 3, 4, 1, 10, 59, 927, DateTimeKind.Utc).AddTicks(7498), "Bluetooth enabled smart lock", "Smart Lock", "Standard", null },
                    { new Guid("11111111-1111-1111-1111-111111111121"), "White", new DateTime(2025, 3, 4, 1, 10, 59, 927, DateTimeKind.Utc).AddTicks(7499), "Mini portable projector", "Portable Projector", "Small", null },
                    { new Guid("11111111-1111-1111-1111-111111111122"), "Black", new DateTime(2025, 3, 4, 1, 10, 59, 927, DateTimeKind.Utc).AddTicks(7501), "E-ink display e-reader", "E-Reader", "Pocket", null },
                    { new Guid("11111111-1111-1111-1111-111111111123"), "Black", new DateTime(2025, 3, 4, 1, 10, 59, 927, DateTimeKind.Utc).AddTicks(7503), "Augmented reality smart glasses", "Smart Glasses", "Standard", null },
                    { new Guid("11111111-1111-1111-1111-111111111124"), "White", new DateTime(2025, 3, 4, 1, 10, 59, 927, DateTimeKind.Utc).AddTicks(7504), "True wireless earbuds", "Wireless Earbuds", "Small", null },
                    { new Guid("11111111-1111-1111-1111-111111111125"), "Black", new DateTime(2025, 3, 4, 1, 10, 59, 927, DateTimeKind.Utc).AddTicks(7506), "Compact portable charger", "Portable Charger", "Small", null },
                    { new Guid("11111111-1111-1111-1111-111111111126"), "Black", new DateTime(2025, 3, 4, 1, 10, 59, 927, DateTimeKind.Utc).AddTicks(7507), "Next-gen gaming console", "Gaming Console", "Standard", null },
                    { new Guid("11111111-1111-1111-1111-111111111127"), "Stainless Steel", new DateTime(2025, 3, 4, 1, 10, 59, 927, DateTimeKind.Utc).AddTicks(7509), "WiFi-connected smart refrigerator", "Smart Refrigerator", "Large", null },
                    { new Guid("11111111-1111-1111-1111-111111111128"), "Black", new DateTime(2025, 3, 4, 1, 10, 59, 927, DateTimeKind.Utc).AddTicks(7510), "High-resolution digital camera", "Digital Camera", "Compact", null },
                    { new Guid("11111111-1111-1111-1111-111111111129"), "Black", new DateTime(2025, 3, 4, 1, 10, 59, 927, DateTimeKind.Utc).AddTicks(7511), "Voice-controlled smart speaker", "Smart Speaker", "Standard", null },
                    { new Guid("11111111-1111-1111-1111-11111111112a"), "Green", new DateTime(2025, 3, 4, 1, 10, 59, 927, DateTimeKind.Utc).AddTicks(7513), "Eco-friendly electric scooter", "Electric Scooter", "Medium", null },
                    { new Guid("11111111-1111-1111-1111-11111111112b"), "Black", new DateTime(2025, 3, 4, 1, 10, 59, 927, DateTimeKind.Utc).AddTicks(7514), "Wireless VR controller", "VR Controller", "Standard", null },
                    { new Guid("11111111-1111-1111-1111-11111111112c"), "Stainless Steel", new DateTime(2025, 3, 4, 1, 10, 59, 927, DateTimeKind.Utc).AddTicks(7516), "Convection smart oven", "Smart Oven", "Large", null },
                    { new Guid("11111111-1111-1111-1111-11111111112d"), "Black", new DateTime(2025, 3, 4, 1, 10, 59, 927, DateTimeKind.Utc).AddTicks(7517), "Eco-friendly electric bike", "Electric Bike", "Standard", null },
                    { new Guid("11111111-1111-1111-1111-11111111112e"), "White", new DateTime(2025, 3, 4, 1, 10, 59, 927, DateTimeKind.Utc).AddTicks(7519), "White noise machine", "Noise Machine", "Small", null },
                    { new Guid("11111111-1111-1111-1111-11111111112f"), "Black", new DateTime(2025, 3, 4, 1, 10, 59, 927, DateTimeKind.Utc).AddTicks(7520), "Digital smart scale", "Smart Scale", "Standard", null },
                    { new Guid("11111111-1111-1111-1111-111111111130"), "Yellow", new DateTime(2025, 3, 4, 1, 10, 59, 927, DateTimeKind.Utc).AddTicks(7522), "Tile-like Bluetooth tracker", "Bluetooth Tracker", "Small", null },
                    { new Guid("11111111-1111-1111-1111-111111111131"), "Black", new DateTime(2025, 3, 4, 1, 10, 59, 927, DateTimeKind.Utc).AddTicks(7523), "High-speed wireless router", "Wireless Router", "Standard", null },
                    { new Guid("11111111-1111-1111-1111-111111111132"), "Space Gray", new DateTime(2025, 3, 4, 1, 10, 59, 927, DateTimeKind.Utc).AddTicks(7524), "Advanced smartwatch", "Smartwatch Pro", "42mm", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_SaleItems_ProductId",
                table: "SaleItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_SaleItems_SaleId",
                table: "SaleItems",
                column: "SaleId");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_BranchId",
                table: "Sales",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_CustomerId",
                table: "Sales",
                column: "CustomerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SaleItems");

            migrationBuilder.DropTable(
                name: "StoredEvent");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Sales");

            migrationBuilder.DropTable(
                name: "Branches");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
