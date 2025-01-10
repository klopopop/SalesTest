namespace SalesTest.Models
{
    /// <summary>
    /// Покупкталь
    /// </summary>
    public class Buyer:BaseEntity
    {
        /// <summary>
        /// Имя покупателя
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Покупки, если были
        /// </summary>
        public IEnumerable<Sale>?Purchases { get; set; }

    }
}
