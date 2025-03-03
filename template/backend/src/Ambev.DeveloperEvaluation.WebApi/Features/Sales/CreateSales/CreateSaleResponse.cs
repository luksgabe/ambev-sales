namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.CreateSales
{
    /// <summary>
    /// Represents the response returned after successfully creating a new sale.
    /// </summary>
    /// <remarks>
    /// This response contains the unique identifier of the newly created sale,
    /// which can be used for subsequent operations or reference.
    /// </remarks>
    public class CreateSaleResponse
    {
        /// <summary>
        /// Gets or sets the unique identifier of the newly created sale.
        /// </summary>
        /// <value>A GUID that uniquely identifies the created sale in the system.</value>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier of the customer id.
        /// </summary>
        /// <value>A GUID that uniquely identifies the customer who buyed.</value>
        public Guid CustomerId { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier of the branch id.
        /// </summary>
        /// <value>A GUID that uniquely identifies the branch who buyed.</value>
        public Guid BranchId { get; set; }

        /// <summary>
        /// Gets or sets Sale Date
        /// </summary>
        /// <value>A DateTime that represents the date of the sale.</value>
        public DateTime SaleDate { get; set; }

        /// <summary>
        /// Gets or sets the total value of the sale.
        /// </summary>
        /// <value>
        public decimal Total { get; set; }
    }
}
