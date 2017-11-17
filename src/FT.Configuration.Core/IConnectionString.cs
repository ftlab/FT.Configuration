namespace FT.Configuration
{
    /// <summary>
    /// Строка соединения
    /// </summary>
    public interface IConnectionString
    {
        /// <summary>
        /// Имя строки
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Провайдер
        /// </summary>
        string Provider { get; set; }

        /// <summary>
        /// Значение строки соединения
        /// </summary>
        string Value { get; set; }
    }
}
