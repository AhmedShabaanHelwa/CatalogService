using System;

namespace Catalog.Domain.Entities
{
    /// <summary>
    /// Item's price
    /// </summary>
    public class Price
    {
        /// <summary>
        /// Price amount
        /// </summary>
        public decimal Amount { get; set; }
        /// <summary>
        /// Price currency
        /// </summary>
        public string Currency { get; set; }
    }
}