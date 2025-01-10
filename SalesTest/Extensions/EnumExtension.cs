using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace SalesTest.Extensions
{
    public static class EnumExtension
    {
        /// <summary>
        ///     ����� ���������� ��� enum, ��������� �� ���������, 
        ///     ���������� ��� �������� enum �������� � �������� Display
        ///     ��� ��� ������ ��������
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
