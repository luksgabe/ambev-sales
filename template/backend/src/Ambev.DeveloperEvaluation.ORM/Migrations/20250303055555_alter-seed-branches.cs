using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ambev.DeveloperEvaluation.ORM.Migrations
{
    /// <inheritdoc />
    public partial class alterseedbranches : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("058b0752-09b7-49a1-8139-912e55664b9a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("066e16c4-1a24-4565-a0bf-afadef26e904"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0dfaff99-5cbc-4981-bc98-0a07fe0e691f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1b9716c0-e74c-424c-baca-56bc29b01902"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("220b0871-90c2-44e2-83cc-6c26b865f900"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3715e6a5-4949-45bf-b063-6bed9d88e49b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3b7b9a6e-a7ab-4cf4-b0ea-601f311e80fb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3ca6e9d8-e125-429a-91da-2ceed0a64bd7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4172901e-4cd3-4e32-853a-0b9620a45518"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5e8a96ae-c3c0-47c0-9f37-1eb0cd490627"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6f2cee78-b7f5-4e58-8fc0-6129673f702c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("74e5ccde-011a-4175-af2f-2c0c78208a7f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b2d60212-f025-4ef0-9a2d-ddd052dfb04c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b316ca27-d2d5-40c8-9b8c-e37a18104d73"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("babfb123-012c-441e-bc50-d36729ba1ed5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c030303e-6680-43ac-a668-17e8f69074c8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c03d8ba2-13ac-46d5-b61c-e68828f1d9e5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c1f3ea10-fab0-4607-935b-7d3a48d52b05"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c89e88f5-0a86-49b6-921c-834aa8aa24f3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d3c8d06f-20b8-4003-aada-6267e8f4b61b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d8f82ea9-980d-4c3a-b916-a1d5e188ceb7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e9bddda2-58ce-4585-8991-07037a353010"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f3b7e3a4-5f37-4a59-adde-3b7704c74878"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f3e554af-0b38-42f9-bb69-0512dfd23c49"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f4bd2e67-73aa-4a2f-9a4c-32cc7fc608e6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f68d124c-2809-4869-bc5e-9db9b99f74d6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f787acca-7b6a-477f-9ec4-9130afb8c6ea"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f96bcb4c-cbbe-4a7d-8aed-a95e2663f56e"));

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "Branches",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "Id", "CreatedAt", "Location", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("1814b34e-46a6-4391-bdc1-52cda86d7bea"), new DateTime(2025, 3, 3, 5, 55, 55, 486, DateTimeKind.Utc).AddTicks(8436), "Avenida Comercial, 456, Shopping Central", "Shopping Outlet", null },
                    { new Guid("25b5f452-fb82-43ee-9f40-74e977b50ae7"), new DateTime(2025, 3, 3, 5, 55, 55, 486, DateTimeKind.Utc).AddTicks(8465), "Avenida das Palmeiras, 321, Bairro Residencial", "Loja Suburbana", null },
                    { new Guid("2f522b1a-51fe-455e-9d69-222bf92217dc"), new DateTime(2025, 3, 3, 5, 55, 55, 486, DateTimeKind.Utc).AddTicks(8463), "Rua Inovação, 789, Distrito Tecnológico", "Tech Hub", null },
                    { new Guid("397de9e9-385d-4d57-ad0f-fdeecf4367f6"), new DateTime(2025, 3, 3, 5, 55, 55, 486, DateTimeKind.Utc).AddTicks(8473), "Avenida Beira-Mar, 100, Região Costeira", "Outlet Praia", null },
                    { new Guid("46cd5abb-4845-4c5c-88aa-af012da953ed"), new DateTime(2025, 3, 3, 5, 55, 55, 486, DateTimeKind.Utc).AddTicks(8470), "Praça Acadêmica, Avenida Universidade", "Loja Universitária", null },
                    { new Guid("5c7f164f-ade7-4339-ab6c-0d2551056459"), new DateTime(2025, 3, 3, 5, 55, 55, 486, DateTimeKind.Utc).AddTicks(8468), "Terminal 1, Aeroporto Internacional", "Quiosque Aeroporto", null },
                    { new Guid("703d4ab5-f449-43c1-a5af-4c584519a1d0"), new DateTime(2025, 3, 3, 5, 55, 55, 486, DateTimeKind.Utc).AddTicks(8477), "Rua das Fábricas, 600, Polo Industrial", "Loja Industrial", null },
                    { new Guid("719a000b-a7f6-4e32-804d-4ed567839194"), new DateTime(2025, 3, 3, 5, 55, 55, 486, DateTimeKind.Utc).AddTicks(8432), "Rua das Flores, 123, Centro", "Loja Centro", null },
                    { new Guid("7a58335e-3d28-4456-a4e9-eefba8e087b7"), new DateTime(2025, 3, 3, 5, 55, 55, 486, DateTimeKind.Utc).AddTicks(8472), "Parque Corporativo, 500, Área de Negócios", "Loja Empresarial", null },
                    { new Guid("89ef0106-8170-42b9-8717-1b71ef01b742"), new DateTime(2025, 3, 3, 5, 55, 55, 486, DateTimeKind.Utc).AddTicks(8475), "Rua das Montanhas, 200, Região Serrana", "Loja Serra", null }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Color", "CreatedAt", "Description", "Name", "Size", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("065180de-a748-4f05-a9a1-1c3f1a94575f"), "Red", new DateTime(2025, 3, 3, 5, 55, 55, 486, DateTimeKind.Utc).AddTicks(8412), "Ergonomic gaming chair", "Gaming Chair", "Large", null },
                    { new Guid("0a8e6d9c-cbe2-47e5-a2d6-d7c02578eab8"), "Black", new DateTime(2025, 3, 3, 5, 55, 55, 486, DateTimeKind.Utc).AddTicks(8407), "Fast external SSD", "Portable SSD", "500GB", null },
                    { new Guid("151f28cf-4448-4961-9241-7d4922331875"), "Black", new DateTime(2025, 3, 3, 5, 55, 55, 486, DateTimeKind.Utc).AddTicks(8426), "Smart robotic vacuum cleaner", "Robot Vacuum", "Compact", null },
                    { new Guid("1c2317d3-d53f-4393-919e-193592568393"), "White", new DateTime(2025, 3, 3, 5, 55, 55, 486, DateTimeKind.Utc).AddTicks(8421), "HEPA filter air purifier", "Air Purifier", "Large", null },
                    { new Guid("1cb1c33e-b61e-41a3-9bf1-00e9c77f1cac"), "Gold", new DateTime(2025, 3, 3, 5, 55, 55, 486, DateTimeKind.Utc).AddTicks(8396), "High-resolution tablet", "Tablet", "10-inch", null },
                    { new Guid("296472b3-efb3-4717-81ab-7fc0a933fb83"), "Black", new DateTime(2025, 3, 3, 5, 55, 55, 486, DateTimeKind.Utc).AddTicks(8402), "Virtual reality headset", "VR Headset", "Adjustable", null },
                    { new Guid("382bd8dd-694c-4ea6-bbf6-0899d7d6e3b3"), "Black", new DateTime(2025, 3, 3, 5, 55, 55, 486, DateTimeKind.Utc).AddTicks(8377), "Ergonomic wireless mouse", "Wireless Mouse", "Medium", null },
                    { new Guid("3b232215-f9db-4ec8-8ccb-c0eedb255cdf"), "Black", new DateTime(2025, 3, 3, 5, 55, 55, 486, DateTimeKind.Utc).AddTicks(8392), "Wireless noise-canceling headphones", "Noise Cancelling Headphones", "Over-ear", null },
                    { new Guid("3df71f32-41d9-495a-a4d5-6de2e3267a1b"), "Blue", new DateTime(2025, 3, 3, 5, 55, 55, 486, DateTimeKind.Utc).AddTicks(8387), "Latest model smartphone", "Smartphone", "6-inch", null },
                    { new Guid("51500140-a4b7-43e5-819c-c8481e2df466"), "Black", new DateTime(2025, 3, 3, 5, 55, 55, 486, DateTimeKind.Utc).AddTicks(8415), "10000mAh fast-charging power bank", "Portable Power Bank", "Compact", null },
                    { new Guid("55f91750-93a8-4082-87d1-53619cd95ecd"), "Black", new DateTime(2025, 3, 3, 5, 55, 55, 486, DateTimeKind.Utc).AddTicks(8409), "High-speed HDMI cable", "HDMI Cable", "6ft", null },
                    { new Guid("6fd02cec-014d-419a-a139-bdc12b330ad6"), "White", new DateTime(2025, 3, 3, 5, 55, 55, 486, DateTimeKind.Utc).AddTicks(8411), "Fast charging pad", "Wireless Charger", "Small", null },
                    { new Guid("72b6ca90-3899-4e64-8109-cae66471e7d9"), "Silver", new DateTime(2025, 3, 3, 5, 55, 55, 486, DateTimeKind.Utc).AddTicks(8367), "High-performance laptop", "Laptop", "15-inch", null },
                    { new Guid("784b6c86-f861-4491-911b-b32d923f37fb"), "Red", new DateTime(2025, 3, 3, 5, 55, 55, 486, DateTimeKind.Utc).AddTicks(8389), "Portable wireless speaker", "Bluetooth Speaker", "Small", null },
                    { new Guid("8ee900b3-8e1a-468c-abba-8486f970f2f1"), "Silver", new DateTime(2025, 3, 3, 5, 55, 55, 486, DateTimeKind.Utc).AddTicks(8419), "Automatic drip coffee maker", "Coffee Maker", "Medium", null },
                    { new Guid("8f2fe901-4f8e-4dcc-95c2-ec13b92c2eb1"), "White", new DateTime(2025, 3, 3, 5, 55, 55, 486, DateTimeKind.Utc).AddTicks(8404), "4K camera drone", "Drone", "Portable", null },
                    { new Guid("9a67fd7f-699f-4cca-b850-72365e471a39"), "Silver", new DateTime(2025, 3, 3, 5, 55, 55, 486, DateTimeKind.Utc).AddTicks(8401), "Professional podcast microphone", "Microphone", "Medium", null },
                    { new Guid("a34634fd-4f72-457f-9ddb-2d2e4b44d4e0"), "Multi-color", new DateTime(2025, 3, 3, 5, 55, 55, 486, DateTimeKind.Utc).AddTicks(8414), "WiFi-enabled LED bulb", "Smart Bulb", "Standard", null },
                    { new Guid("a7011964-1302-4273-925d-956083f4eb8d"), "Black", new DateTime(2025, 3, 3, 5, 55, 55, 486, DateTimeKind.Utc).AddTicks(8398), "Professional drawing tablet", "Graphic Tablet", "Large", null },
                    { new Guid("ab7c6a9d-a49b-4459-8a45-a8c75690142f"), "Brown", new DateTime(2025, 3, 3, 5, 55, 55, 486, DateTimeKind.Utc).AddTicks(8425), "Adjustable height standing desk", "Standing Desk", "Large", null },
                    { new Guid("b609d7d6-f493-435e-9cb5-ced331bfaef0"), "Black", new DateTime(2025, 3, 3, 5, 55, 55, 486, DateTimeKind.Utc).AddTicks(8399), "1080p HD webcam", "Webcam", "Compact", null },
                    { new Guid("c2da8b07-0bac-4bfe-9ac1-d11e7a1acf10"), "White", new DateTime(2025, 3, 3, 5, 55, 55, 486, DateTimeKind.Utc).AddTicks(8423), "Rechargeable electric toothbrush", "Electric Toothbrush", "Small", null },
                    { new Guid("ed29c524-d21a-4931-8429-6290aae8fd59"), "White", new DateTime(2025, 3, 3, 5, 55, 55, 486, DateTimeKind.Utc).AddTicks(8379), "RGB backlit keyboard", "Mechanical Keyboard", "Full-size", null },
                    { new Guid("f4e2ad9c-3a49-4172-95e6-3baaa00df222"), "Silver", new DateTime(2025, 3, 3, 5, 55, 55, 486, DateTimeKind.Utc).AddTicks(8395), "Water-resistant smartwatch", "Smartwatch", "40mm", null },
                    { new Guid("f68858cb-0012-4d3b-8c1e-528d88d1f825"), "Grey", new DateTime(2025, 3, 3, 5, 55, 55, 486, DateTimeKind.Utc).AddTicks(8382), "Multiport adapter", "USB-C Hub", "Compact", null },
                    { new Guid("f94b7f60-59ef-4d20-aff4-b9d4aa17375d"), "Black", new DateTime(2025, 3, 3, 5, 55, 55, 486, DateTimeKind.Utc).AddTicks(8386), "1TB storage drive", "External Hard Drive", "Portable", null },
                    { new Guid("fd4c745b-f827-4f24-b7e3-9f03e451b216"), "Black", new DateTime(2025, 3, 3, 5, 55, 55, 486, DateTimeKind.Utc).AddTicks(8381), "144Hz refresh rate monitor", "Gaming Monitor", "27-inch", null },
                    { new Guid("fd99adee-3310-4d52-b669-6e2285162918"), "Blue", new DateTime(2025, 3, 3, 5, 55, 55, 486, DateTimeKind.Utc).AddTicks(8417), "Activity tracking smartwatch", "Fitness Tracker", "Medium", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: new Guid("1814b34e-46a6-4391-bdc1-52cda86d7bea"));

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: new Guid("25b5f452-fb82-43ee-9f40-74e977b50ae7"));

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: new Guid("2f522b1a-51fe-455e-9d69-222bf92217dc"));

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: new Guid("397de9e9-385d-4d57-ad0f-fdeecf4367f6"));

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: new Guid("46cd5abb-4845-4c5c-88aa-af012da953ed"));

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: new Guid("5c7f164f-ade7-4339-ab6c-0d2551056459"));

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: new Guid("703d4ab5-f449-43c1-a5af-4c584519a1d0"));

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: new Guid("719a000b-a7f6-4e32-804d-4ed567839194"));

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: new Guid("7a58335e-3d28-4456-a4e9-eefba8e087b7"));

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: new Guid("89ef0106-8170-42b9-8717-1b71ef01b742"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("065180de-a748-4f05-a9a1-1c3f1a94575f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0a8e6d9c-cbe2-47e5-a2d6-d7c02578eab8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("151f28cf-4448-4961-9241-7d4922331875"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1c2317d3-d53f-4393-919e-193592568393"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1cb1c33e-b61e-41a3-9bf1-00e9c77f1cac"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("296472b3-efb3-4717-81ab-7fc0a933fb83"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("382bd8dd-694c-4ea6-bbf6-0899d7d6e3b3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3b232215-f9db-4ec8-8ccb-c0eedb255cdf"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3df71f32-41d9-495a-a4d5-6de2e3267a1b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("51500140-a4b7-43e5-819c-c8481e2df466"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("55f91750-93a8-4082-87d1-53619cd95ecd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6fd02cec-014d-419a-a139-bdc12b330ad6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("72b6ca90-3899-4e64-8109-cae66471e7d9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("784b6c86-f861-4491-911b-b32d923f37fb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8ee900b3-8e1a-468c-abba-8486f970f2f1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8f2fe901-4f8e-4dcc-95c2-ec13b92c2eb1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9a67fd7f-699f-4cca-b850-72365e471a39"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a34634fd-4f72-457f-9ddb-2d2e4b44d4e0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a7011964-1302-4273-925d-956083f4eb8d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ab7c6a9d-a49b-4459-8a45-a8c75690142f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b609d7d6-f493-435e-9cb5-ced331bfaef0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c2da8b07-0bac-4bfe-9ac1-d11e7a1acf10"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ed29c524-d21a-4931-8429-6290aae8fd59"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f4e2ad9c-3a49-4172-95e6-3baaa00df222"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f68858cb-0012-4d3b-8c1e-528d88d1f825"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f94b7f60-59ef-4d20-aff4-b9d4aa17375d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fd4c745b-f827-4f24-b7e3-9f03e451b216"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fd99adee-3310-4d52-b669-6e2285162918"));

            migrationBuilder.DropColumn(
                name: "Location",
                table: "Branches");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Color", "CreatedAt", "Description", "Name", "Size", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("058b0752-09b7-49a1-8139-912e55664b9a"), "Multi-color", new DateTime(2025, 3, 2, 23, 41, 2, 215, DateTimeKind.Utc).AddTicks(3852), "WiFi-enabled LED bulb", "Smart Bulb", "Standard", null },
                    { new Guid("066e16c4-1a24-4565-a0bf-afadef26e904"), "Black", new DateTime(2025, 3, 2, 23, 41, 2, 215, DateTimeKind.Utc).AddTicks(3838), "1080p HD webcam", "Webcam", "Compact", null },
                    { new Guid("0dfaff99-5cbc-4981-bc98-0a07fe0e691f"), "White", new DateTime(2025, 3, 2, 23, 41, 2, 215, DateTimeKind.Utc).AddTicks(3763), "RGB backlit keyboard", "Mechanical Keyboard", "Full-size", null },
                    { new Guid("1b9716c0-e74c-424c-baca-56bc29b01902"), "Blue", new DateTime(2025, 3, 2, 23, 41, 2, 215, DateTimeKind.Utc).AddTicks(3769), "Latest model smartphone", "Smartphone", "6-inch", null },
                    { new Guid("220b0871-90c2-44e2-83cc-6c26b865f900"), "Black", new DateTime(2025, 3, 2, 23, 41, 2, 215, DateTimeKind.Utc).AddTicks(3848), "High-speed HDMI cable", "HDMI Cable", "6ft", null },
                    { new Guid("3715e6a5-4949-45bf-b063-6bed9d88e49b"), "Silver", new DateTime(2025, 3, 2, 23, 41, 2, 215, DateTimeKind.Utc).AddTicks(3758), "High-performance laptop", "Laptop", "15-inch", null },
                    { new Guid("3b7b9a6e-a7ab-4cf4-b0ea-601f311e80fb"), "Black", new DateTime(2025, 3, 2, 23, 41, 2, 215, DateTimeKind.Utc).AddTicks(3768), "1TB storage drive", "External Hard Drive", "Portable", null },
                    { new Guid("3ca6e9d8-e125-429a-91da-2ceed0a64bd7"), "Black", new DateTime(2025, 3, 2, 23, 41, 2, 215, DateTimeKind.Utc).AddTicks(3854), "10000mAh fast-charging power bank", "Portable Power Bank", "Compact", null },
                    { new Guid("4172901e-4cd3-4e32-853a-0b9620a45518"), "White", new DateTime(2025, 3, 2, 23, 41, 2, 215, DateTimeKind.Utc).AddTicks(3849), "Fast charging pad", "Wireless Charger", "Small", null },
                    { new Guid("5e8a96ae-c3c0-47c0-9f37-1eb0cd490627"), "Red", new DateTime(2025, 3, 2, 23, 41, 2, 215, DateTimeKind.Utc).AddTicks(3851), "Ergonomic gaming chair", "Gaming Chair", "Large", null },
                    { new Guid("6f2cee78-b7f5-4e58-8fc0-6129673f702c"), "Black", new DateTime(2025, 3, 2, 23, 41, 2, 215, DateTimeKind.Utc).AddTicks(3842), "Virtual reality headset", "VR Headset", "Adjustable", null },
                    { new Guid("74e5ccde-011a-4175-af2f-2c0c78208a7f"), "Red", new DateTime(2025, 3, 2, 23, 41, 2, 215, DateTimeKind.Utc).AddTicks(3771), "Portable wireless speaker", "Bluetooth Speaker", "Small", null },
                    { new Guid("b2d60212-f025-4ef0-9a2d-ddd052dfb04c"), "Black", new DateTime(2025, 3, 2, 23, 41, 2, 215, DateTimeKind.Utc).AddTicks(3832), "Wireless noise-canceling headphones", "Noise Cancelling Headphones", "Over-ear", null },
                    { new Guid("b316ca27-d2d5-40c8-9b8c-e37a18104d73"), "Black", new DateTime(2025, 3, 2, 23, 41, 2, 215, DateTimeKind.Utc).AddTicks(3846), "Fast external SSD", "Portable SSD", "500GB", null },
                    { new Guid("babfb123-012c-441e-bc50-d36729ba1ed5"), "Silver", new DateTime(2025, 3, 2, 23, 41, 2, 215, DateTimeKind.Utc).AddTicks(3840), "Professional podcast microphone", "Microphone", "Medium", null },
                    { new Guid("c030303e-6680-43ac-a668-17e8f69074c8"), "Black", new DateTime(2025, 3, 2, 23, 41, 2, 215, DateTimeKind.Utc).AddTicks(3765), "144Hz refresh rate monitor", "Gaming Monitor", "27-inch", null },
                    { new Guid("c03d8ba2-13ac-46d5-b61c-e68828f1d9e5"), "Brown", new DateTime(2025, 3, 2, 23, 41, 2, 215, DateTimeKind.Utc).AddTicks(3864), "Adjustable height standing desk", "Standing Desk", "Large", null },
                    { new Guid("c1f3ea10-fab0-4607-935b-7d3a48d52b05"), "Black", new DateTime(2025, 3, 2, 23, 41, 2, 215, DateTimeKind.Utc).AddTicks(3762), "Ergonomic wireless mouse", "Wireless Mouse", "Medium", null },
                    { new Guid("c89e88f5-0a86-49b6-921c-834aa8aa24f3"), "Gold", new DateTime(2025, 3, 2, 23, 41, 2, 215, DateTimeKind.Utc).AddTicks(3835), "High-resolution tablet", "Tablet", "10-inch", null },
                    { new Guid("d3c8d06f-20b8-4003-aada-6267e8f4b61b"), "Silver", new DateTime(2025, 3, 2, 23, 41, 2, 215, DateTimeKind.Utc).AddTicks(3834), "Water-resistant smartwatch", "Smartwatch", "40mm", null },
                    { new Guid("d8f82ea9-980d-4c3a-b916-a1d5e188ceb7"), "Black", new DateTime(2025, 3, 2, 23, 41, 2, 215, DateTimeKind.Utc).AddTicks(3865), "Smart robotic vacuum cleaner", "Robot Vacuum", "Compact", null },
                    { new Guid("e9bddda2-58ce-4585-8991-07037a353010"), "Grey", new DateTime(2025, 3, 2, 23, 41, 2, 215, DateTimeKind.Utc).AddTicks(3766), "Multiport adapter", "USB-C Hub", "Compact", null },
                    { new Guid("f3b7e3a4-5f37-4a59-adde-3b7704c74878"), "Silver", new DateTime(2025, 3, 2, 23, 41, 2, 215, DateTimeKind.Utc).AddTicks(3858), "Automatic drip coffee maker", "Coffee Maker", "Medium", null },
                    { new Guid("f3e554af-0b38-42f9-bb69-0512dfd23c49"), "Blue", new DateTime(2025, 3, 2, 23, 41, 2, 215, DateTimeKind.Utc).AddTicks(3856), "Activity tracking smartwatch", "Fitness Tracker", "Medium", null },
                    { new Guid("f4bd2e67-73aa-4a2f-9a4c-32cc7fc608e6"), "White", new DateTime(2025, 3, 2, 23, 41, 2, 215, DateTimeKind.Utc).AddTicks(3861), "HEPA filter air purifier", "Air Purifier", "Large", null },
                    { new Guid("f68d124c-2809-4869-bc5e-9db9b99f74d6"), "White", new DateTime(2025, 3, 2, 23, 41, 2, 215, DateTimeKind.Utc).AddTicks(3843), "4K camera drone", "Drone", "Portable", null },
                    { new Guid("f787acca-7b6a-477f-9ec4-9130afb8c6ea"), "Black", new DateTime(2025, 3, 2, 23, 41, 2, 215, DateTimeKind.Utc).AddTicks(3837), "Professional drawing tablet", "Graphic Tablet", "Large", null },
                    { new Guid("f96bcb4c-cbbe-4a7d-8aed-a95e2663f56e"), "White", new DateTime(2025, 3, 2, 23, 41, 2, 215, DateTimeKind.Utc).AddTicks(3862), "Rechargeable electric toothbrush", "Electric Toothbrush", "Small", null }
                });
        }
    }
}
