using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ambev.DeveloperEvaluation.ORM.Migrations
{
    /// <inheritdoc />
    public partial class createproductseed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
