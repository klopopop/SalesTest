﻿namespace SalesTest.Models
{
    /// <summary>
    /// Доступные товары на точках продаж
    /// </summary>
    public class ProvidedProducts
    {
        /// <summary>
        /// Идентификатор точки продаж
        /// </summary>
        public ulong SalesPointId { get; set; }

        /// <summary>
        /// Точка продаж
        /// </summary>
        public SalesPoint SalesPoint { get; set; }

        /// <summary>
        /// Идентификатор продукта
        /// </summary>
        public ulong ProductId { get; set; }

        /// <summary>
        /// Продукт
        /// </summary>
        public Product Product { get; set; }

        /// <summary>
        /// Количество продукта
        /// </summary>
        public uint ProductQuantity  { get; set; }
    }
}