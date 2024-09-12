using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace TianXiaTech.SystemInfoCollector.Util
{
    public class ReflectionUtil
    {
        public static T DictionaryMapToObject<T>(Dictionary<string,object> keyValuePairs) where T : class,new ()
        {
            T t = new T();

            foreach (var property in t.GetType().GetProperties())
            {
                if (keyValuePairs.ContainsKey(property.Name) == false)
                    continue;

                if (keyValuePairs[property.Name] == null)
                    continue;

                property.SetValue(t, DynamicConvertValueType(property, keyValuePairs[property.Name]));
            }

            return t;
        }

        public static object GetPropertyValue(string propertyName, object obj)
        {
            if (typeof(IEnumerable).IsAssignableFrom(obj.GetType()))
            {
                var enumerator = ((IEnumerable)obj).GetEnumerator();
                if (enumerator.MoveNext())
                {
                    obj = enumerator.Current;
                }
                else
                {
                    return null;
                }
            }

            foreach (var property in obj.GetType().GetProperties())
            {
                if (property.Name == propertyName)
                    return property.GetValue(obj);

                if (!property.PropertyType.IsValueType && property.PropertyType != typeof(string))
                {
                    var subObj = GetPropertyValue(propertyName, property.GetValue(obj));
                    if (subObj != null)
                        return subObj;
                }
            }

            return null;
        }

        public static object DynamicConvertValueType(System.Reflection.PropertyInfo propertyInfo, object getValue)
        {
            var valueType = getValue.GetType();
            var propertyType = GetNullableDeclaringType(propertyInfo.PropertyType);
            if (propertyType == valueType)
                return getValue;

            if (propertyType == typeof(string))
                return getValue.ToString();

            Type[] argTypes = { typeof(string), propertyType.MakeByRefType() };
            var tryParseFunc = propertyType.GetMethod("TryParse", argTypes);

            if (tryParseFunc != null)
            {
                var getValueStr = getValue.ToString();

                if (propertyType != typeof(DateTime))
                    getValueStr = getValueStr.ExtractDigit();

                object[] parameters = new object[] { getValueStr, null };
                object result = tryParseFunc.Invoke(null, parameters);
                bool blResult = (bool)result;
                if (blResult)
                {
                    return parameters[1];
                }
            }

            return getValue;
        }

        public static Type GetNullableDeclaringType(Type type)
        {
            if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>))
            {
                return Nullable.GetUnderlyingType(type);
            }

            return type;
        }
    }
}
