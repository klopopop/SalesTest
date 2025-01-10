namespace SalesTest.Models
{
    /// <summary>
    /// Точка продаж
    /// </summary>
    public class SalesPoint:BaseEntity
    {
        /// <summary>
        /// Наименование точки продаж
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Код точки продаж
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Доступные товары
        /// </summary>
        public ProvidedProducts? ProvidedProducts { get; set; }
    }
}
