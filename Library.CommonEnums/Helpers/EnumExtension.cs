using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;

namespace Library.CommonEnums.Helpers
{
    public static class EnumExtension
    {

        public static string GetSqlFunctionForEnum(Type item, string funcName = null, bool useDisplayNameIfAvailable = true)
        {
            funcName = funcName ?? $"Get{item.Name}String";
            var sqlFunction = "";
            if (item.IsEnum)
            {
                sqlFunction += GetSqlDropFunctionForEnum(item, funcName);
                sqlFunction += $@"

Create Function {funcName}(@enumVal int)
    RETURNS varchar(50)  
    AS  
    --
Begin
    return (case @enumVal ";
                var nameList = GetDictionary(item, useDisplayNameIfAvailable);
                foreach (var enumitem in nameList)
                {
                    sqlFunction += $@"when {enumitem.Key} then '{enumitem.Value}'
";
                }
                sqlFunction += @"else '?????'
end)
end; 

Go";
            }
            return sqlFunction;
        }
        public static string GetSqlDropFunctionForEnum(Type item, string funcName = null)
        {
            funcName = funcName ?? $"Get{item.Name}String";
            var sqlFunction = "";
            if (item.IsEnum)
            {
                sqlFunction += $@"IF OBJECT_ID (N'{funcName}', N'FN') IS NOT NULL  
DROP FUNCTION {funcName}; 

Go";
            }
            return sqlFunction;
        }
        public static string GetDisplayName(this Enum seg)
        {
            var display = seg.GetType()
                .GetField(seg.ToString())
                 //.GetMember(seg.ToString())
                 //.Attr
                 .GetCustomAttributes(false)
                 .OfType<DisplayAttribute>()
                 .SingleOrDefault();
            return display == null ? seg.ToString() : display.Name;
        }
        public static BuyerType GetBuyerTypeEnumValue<BuyerType>(this string enumString) where BuyerType : struct, Enum
        {
            BuyerType enumValue;
            Enum.TryParse(enumString, out enumValue);
            return (BuyerType)enumValue;
        }

        public static List<string> GetValidList<T>(List<int> ignoredItems = null) where T : struct, IConvertible
        {
            ignoredItems = ignoredItems ?? new List<int>();
            return GetDictionary(typeof(T)).Where(s => !ignoredItems.Contains(s.Key)).Select(x => x.Value).ToList();
        }

        public static List<string> GetValidList(Type type, List<int> ignoredItems)
        {
            if (!type.IsEnum)
            {
                return new List<string>();
            }
            else
            {

                return Enum.GetValues(type)
                                  .Cast<Enum>()
                                  .Select(v => v.GetDisplayName())
                                  .ToList();
            }
        }
        public static Dictionary<int, string> GetDictionary(Type t, bool useDisplayNameIfAvailable = true)
        {
            if (!t.IsEnum)
            {
                return new Dictionary<int, string>();
            }
            else
            {
                return Enum.GetValues(t)
                                  .Cast<Enum>()
                                  .ToDictionary(v => Convert.ToInt32(v), v => useDisplayNameIfAvailable ? v.GetDisplayName() : v.ToString());

            }
        }

        public static string GetDescription(Enum value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());

            DescriptionAttribute[] attributes = fi.GetCustomAttributes(typeof(DescriptionAttribute), false) as DescriptionAttribute[];

            if (attributes != null && attributes.Any())
            {
                return attributes.First().Description;
            }

            return value.ToString();
        }
    }
}
