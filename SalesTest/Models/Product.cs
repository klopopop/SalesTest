namespace SalesTest.Models
{
    public class Product:BaseEntity
    {
        /// <summary>
        /// Наименование товара
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Цена
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Штрих-код
        /// </summary>
        public string BarQode { get; set; }


        public IEnumerable<ProvidedProducts>? ProvidedProducts { get; set; }
    }
}
