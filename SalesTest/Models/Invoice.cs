namespace SalesTest.Models
{
    /// <summary>
    /// Чек продажи одного вида товара
    /// </summary>
    public class Invoice:BaseEntity
    {
        /// <summary>
        /// Идентификатор продукта
        /// </summary>
        public ulong ProductId { get; set; }

        /// <summary>
        /// Количество купленного продукта
        /// </summary>
        public uint  ProductQuantity  { get; set; }

        /// <summary>
        /// ЦЕна продукта на момент продажи
        /// </summary>
        public decimal ProductPrice { get; set; }

        /// <summary>
        /// Сума продажу
        /// </summary>
        public decimal ProductIdAmount  => ProductIdAmount*ProductPrice;
    
    }
}
