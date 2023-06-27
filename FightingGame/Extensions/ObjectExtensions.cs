using System.Reflection;

namespace FightingGame.Extensions
{
    public static class ObjectExtensions
    {
        public static string GetProperties<T>(this T obj)
        {
            PropertyInfo[] propertyInfo = typeof(T).GetProperties();
            return string.Join(Environment.NewLine, propertyInfo.Select(property => property.Name + ": " + property.GetValue(obj)));
        }
    }
}

