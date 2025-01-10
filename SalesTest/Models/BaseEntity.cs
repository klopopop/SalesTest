namespace SalesTest.Models
{
    /// <summary>
    /// Базовая сущность
    /// </summary>
    public abstract class BaseEntity
    {
        /// <summary>
        /// Уникальный идентификатор
        /// </summary>
        public ulong Id { get; set; }

        /// <summary>
        /// Сущность помечена удаленной
        /// </summary>
        public bool IsDeleted { get; set; }
    }
}
