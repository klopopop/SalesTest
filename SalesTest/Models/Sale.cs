namespace SalesTest.Models
{
    /// <summary>
    /// Продажа
    /// </summary>
    public class Sale:BaseEntity
    {
        /// <summary>
        /// Дата продажи
        /// </summary>
        public DateOnly Date { get; set; }

        /// <summary>
        /// Время продажи
        /// </summary>
        public TimeOnly Time { get; set; }

        /// <summary>
        /// Точка продажи
        /// </summary>
        public ulong SalesPointId { get; set; }

        /// <summary>
        /// Покупатель, если известен
        /// </summary>
        public ulong? BuyerId { get; set; }

        /// <summary>
        /// Детели продажи
        /// </summary>
        public List<Invoice> SalesData { get; set; }

        /// <summary>
        /// Общая сумма продажи
        /// </summary>
        public decimal TotalAmount => SalesData.Sum(s => s.ProductIdAmount);

    }
}
