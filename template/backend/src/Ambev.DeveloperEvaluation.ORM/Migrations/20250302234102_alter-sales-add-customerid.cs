using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ambev.DeveloperEvaluation.ORM.Migrations
{
    /// <inheritdoc />
    public partial class altersalesaddcustomerid : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("055a4672-d187-41a2-a196-d294a5d9dbac"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0d8eb020-752e-4bc1-b267-25554c268d20"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0f730c46-d76f-482f-a67f-3aeb11b3a97c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("12b9f44b-fc84-4f71-afd3-14be5da09baa"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("13c46283-10da-44e0-b44f-84d6dfca5897"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("16ba5629-d687-4f58-9bcf-e9b006cc32eb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("23b0fee6-a4e6-4fe6-984e-9d3c7de22614"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("26729ca0-ddfc-476a-946c-f50687cc3c6c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4a6395cd-74b9-4cbf-a9a2-c7e639946a3e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4f594b9b-5ac7-4086-a50f-dbedcfda1242"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4fb77096-3413-48fb-8629-eaf704f3961c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("616535e1-60ed-44dc-8608-1d475fc1d879"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("691a595c-979b-4117-a656-4c498c946f7c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6f7a0857-3983-476f-96d7-940e3addcdbf"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7ea0aee7-0f0a-4853-ac19-d309631f660e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8acfe6a0-bd8f-4cfa-9ab3-876c0e254399"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9b8345d2-59ef-4b44-8949-7393f027511d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9d68bdc5-da53-4042-ac4d-0f65c6a6decd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a44a96c5-20c0-4cc4-9c09-e10e37cb97b2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a86e183d-03a4-4caf-84d8-818b25f9e67d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ab6d67f1-d3dd-4e2a-b6ce-c2d53d6d3d60"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d7901d4f-c681-4a89-9d71-a28a7bac3665"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e5369c49-47b3-43ba-b363-b129ce66ab23"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e5d1ada6-9ebc-4abc-9388-38057ce978b1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e760e129-1ae2-4c47-a6e8-703da7cb66b3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f0edb3cf-ee6f-42e7-a002-c643eef710ac"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fd24d499-2871-485d-9dd7-e339f7fcc7bc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fff3db0b-3d6e-49c6-91c7-7da234ea2512"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Color", "CreatedAt", "Description", "Name", "Size", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("055a4672-d187-41a2-a196-d294a5d9dbac"), "Black", new DateTime(2025, 3, 2, 4, 56, 11, 774, DateTimeKind.Utc).AddTicks(8603), "10000mAh fast-charging power bank", "Portable Power Bank", "Compact", null },
                    { new Guid("0d8eb020-752e-4bc1-b267-25554c268d20"), "White", new DateTime(2025, 3, 2, 4, 56, 11, 774, DateTimeKind.Utc).AddTicks(8609), "Rechargeable electric toothbrush", "Electric Toothbrush", "Small", null },
                    { new Guid("0f730c46-d76f-482f-a67f-3aeb11b3a97c"), "Black", new DateTime(2025, 3, 2, 4, 56, 11, 774, DateTimeKind.Utc).AddTicks(8580), "Wireless noise-canceling headphones", "Noise Cancelling Headphones", "Over-ear", null },
                    { new Guid("12b9f44b-fc84-4f71-afd3-14be5da09baa"), "Black", new DateTime(2025, 3, 2, 4, 56, 11, 774, DateTimeKind.Utc).AddTicks(8591), "Virtual reality headset", "VR Headset", "Adjustable", null },
                    { new Guid("13c46283-10da-44e0-b44f-84d6dfca5897"), "Black", new DateTime(2025, 3, 2, 4, 56, 11, 774, DateTimeKind.Utc).AddTicks(8557), "Ergonomic wireless mouse", "Wireless Mouse", "Medium", null },
                    { new Guid("16ba5629-d687-4f58-9bcf-e9b006cc32eb"), "White", new DateTime(2025, 3, 2, 4, 56, 11, 774, DateTimeKind.Utc).AddTicks(8607), "HEPA filter air purifier", "Air Purifier", "Large", null },
                    { new Guid("23b0fee6-a4e6-4fe6-984e-9d3c7de22614"), "Grey", new DateTime(2025, 3, 2, 4, 56, 11, 774, DateTimeKind.Utc).AddTicks(8575), "Multiport adapter", "USB-C Hub", "Compact", null },
                    { new Guid("26729ca0-ddfc-476a-946c-f50687cc3c6c"), "Blue", new DateTime(2025, 3, 2, 4, 56, 11, 774, DateTimeKind.Utc).AddTicks(8578), "Latest model smartphone", "Smartphone", "6-inch", null },
                    { new Guid("4a6395cd-74b9-4cbf-a9a2-c7e639946a3e"), "Silver", new DateTime(2025, 3, 2, 4, 56, 11, 774, DateTimeKind.Utc).AddTicks(8582), "Water-resistant smartwatch", "Smartwatch", "40mm", null },
                    { new Guid("4f594b9b-5ac7-4086-a50f-dbedcfda1242"), "Brown", new DateTime(2025, 3, 2, 4, 56, 11, 774, DateTimeKind.Utc).AddTicks(8612), "Adjustable height standing desk", "Standing Desk", "Large", null },
                    { new Guid("4fb77096-3413-48fb-8629-eaf704f3961c"), "Black", new DateTime(2025, 3, 2, 4, 56, 11, 774, DateTimeKind.Utc).AddTicks(8596), "High-speed HDMI cable", "HDMI Cable", "6ft", null },
                    { new Guid("616535e1-60ed-44dc-8608-1d475fc1d879"), "Blue", new DateTime(2025, 3, 2, 4, 56, 11, 774, DateTimeKind.Utc).AddTicks(8605), "Activity tracking smartwatch", "Fitness Tracker", "Medium", null },
                    { new Guid("691a595c-979b-4117-a656-4c498c946f7c"), "Silver", new DateTime(2025, 3, 2, 4, 56, 11, 774, DateTimeKind.Utc).AddTicks(8554), "High-performance laptop", "Laptop", "15-inch", null },
                    { new Guid("6f7a0857-3983-476f-96d7-940e3addcdbf"), "Multi-color", new DateTime(2025, 3, 2, 4, 56, 11, 774, DateTimeKind.Utc).AddTicks(8602), "WiFi-enabled LED bulb", "Smart Bulb", "Standard", null },
                    { new Guid("7ea0aee7-0f0a-4853-ac19-d309631f660e"), "Black", new DateTime(2025, 3, 2, 4, 56, 11, 774, DateTimeKind.Utc).AddTicks(8594), "Fast external SSD", "Portable SSD", "500GB", null },
                    { new Guid("8acfe6a0-bd8f-4cfa-9ab3-876c0e254399"), "White", new DateTime(2025, 3, 2, 4, 56, 11, 774, DateTimeKind.Utc).AddTicks(8593), "4K camera drone", "Drone", "Portable", null },
                    { new Guid("9b8345d2-59ef-4b44-8949-7393f027511d"), "Red", new DateTime(2025, 3, 2, 4, 56, 11, 774, DateTimeKind.Utc).AddTicks(8600), "Ergonomic gaming chair", "Gaming Chair", "Large", null },
                    { new Guid("9d68bdc5-da53-4042-ac4d-0f65c6a6decd"), "Black", new DateTime(2025, 3, 2, 4, 56, 11, 774, DateTimeKind.Utc).AddTicks(8573), "144Hz refresh rate monitor", "Gaming Monitor", "27-inch", null },
                    { new Guid("a44a96c5-20c0-4cc4-9c09-e10e37cb97b2"), "Black", new DateTime(2025, 3, 2, 4, 56, 11, 774, DateTimeKind.Utc).AddTicks(8587), "Professional drawing tablet", "Graphic Tablet", "Large", null },
                    { new Guid("a86e183d-03a4-4caf-84d8-818b25f9e67d"), "Silver", new DateTime(2025, 3, 2, 4, 56, 11, 774, DateTimeKind.Utc).AddTicks(8590), "Professional podcast microphone", "Microphone", "Medium", null },
                    { new Guid("ab6d67f1-d3dd-4e2a-b6ce-c2d53d6d3d60"), "Black", new DateTime(2025, 3, 2, 4, 56, 11, 774, DateTimeKind.Utc).AddTicks(8589), "1080p HD webcam", "Webcam", "Compact", null },
                    { new Guid("d7901d4f-c681-4a89-9d71-a28a7bac3665"), "Black", new DateTime(2025, 3, 2, 4, 56, 11, 774, DateTimeKind.Utc).AddTicks(8613), "Smart robotic vacuum cleaner", "Robot Vacuum", "Compact", null },
                    { new Guid("e5369c49-47b3-43ba-b363-b129ce66ab23"), "Silver", new DateTime(2025, 3, 2, 4, 56, 11, 774, DateTimeKind.Utc).AddTicks(8606), "Automatic drip coffee maker", "Coffee Maker", "Medium", null },
                    { new Guid("e5d1ada6-9ebc-4abc-9388-38057ce978b1"), "Red", new DateTime(2025, 3, 2, 4, 56, 11, 774, DateTimeKind.Utc).AddTicks(8579), "Portable wireless speaker", "Bluetooth Speaker", "Small", null },
                    { new Guid("e760e129-1ae2-4c47-a6e8-703da7cb66b3"), "Black", new DateTime(2025, 3, 2, 4, 56, 11, 774, DateTimeKind.Utc).AddTicks(8576), "1TB storage drive", "External Hard Drive", "Portable", null },
                    { new Guid("f0edb3cf-ee6f-42e7-a002-c643eef710ac"), "White", new DateTime(2025, 3, 2, 4, 56, 11, 774, DateTimeKind.Utc).AddTicks(8571), "RGB backlit keyboard", "Mechanical Keyboard", "Full-size", null },
                    { new Guid("fd24d499-2871-485d-9dd7-e339f7fcc7bc"), "Gold", new DateTime(2025, 3, 2, 4, 56, 11, 774, DateTimeKind.Utc).AddTicks(8586), "High-resolution tablet", "Tablet", "10-inch", null },
                    { new Guid("fff3db0b-3d6e-49c6-91c7-7da234ea2512"), "White", new DateTime(2025, 3, 2, 4, 56, 11, 774, DateTimeKind.Utc).AddTicks(8599), "Fast charging pad", "Wireless Charger", "Small", null }
                });
        }
    }
}
