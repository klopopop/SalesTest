using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace SalesTest.Extensions
{
    public static class EnumExtension
    {
        /// <summary>
        ///     Метод расширения для enum, основаный на рефлексии, 
        ///     возвращает имя элемента enum заданное в атрибуте Display
        ///     или имя самого элемента
        /// </summary>
        public static string DisplayName(this Enum enumValue)
        {
            return enumValue.GetType()
                            .GetMember(enumValue.ToString())
                            .First()
                            .GetCustomAttribute<DisplayAttribute>()?.Name ?? enumValue.ToString();
        }
    }
}
