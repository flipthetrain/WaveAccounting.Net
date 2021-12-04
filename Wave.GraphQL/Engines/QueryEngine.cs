using System.Reflection;
using System.Text;
using Wave.Schema.Attributes;

namespace Wave.GraphQL.Engines
{
    public static class QueryEngine
    {
        private static string mapTypeName(string typeName)
        {
            switch (typeName.ToLower())
            {
                case "int":
                case "int32":
                    return "Int";
                default:
                    return typeName;
            }
        }

        private static string buildQueryParametersSection(string queryName, Type[] parameterTypes, StringBuilder sb)
        {
            sb.AppendLine($"query({string.Join(",", parameterTypes.Select(p => $"${p.Name}:{mapTypeName(p.Name)}"))}) {{");
            sb.AppendLine($"{queryName}({string.Join(",", parameterTypes.Select(p => $"{p.Name}:${p.Name}"))}) {{");
            return sb.ToString();
        }

        private static string buildOutputSection(Type outputType, StringBuilder sb)
        {
            return sb.ToString();
        }

        public static string generateQuery<T>()
        {
            SchemaQueryAttribute queryAttr = typeof(T).GetCustomAttribute<SchemaQueryAttribute>();
            if (queryAttr == null)
                throw new ArgumentException($"{typeof(T)} does not contain Query attribute.");
            
            string queryName = queryAttr.queryName;
            ParameterInfo[] queryParameters = typeof(T).GetConstructors().Select(qd => qd.GetParameters()).First();

            if (queryParameters.Where(p => p.ParameterType.GetCustomAttribute<SchemaObjectAttribute>() == null
                                            && !p.ParameterType.IsPrimitive
                                            && p.ParameterType != typeof(string)).Count() > 0)
                throw new ArgumentException($"Parameters of {typeof(T)} must be {typeof(SchemaObjectAttribute)}, string, or primitive");

            StringBuilder sb = new StringBuilder();
            //build input parameter definition
            sb.AppendLine(buildQueryParametersSection(queryName, queryParameters.Take(queryParameters.Length - 1).Select(p => p.ParameterType)),sb);

            //build output selection
            sb.AppendLine(buildOutputSection(queryParameters.Last().ParameterType, sb);

            //sb.AppendLine("\t" + queryDefinition.Item2.Last().Name);
            //if (queryDefinition.Item2.Length > 1)
            //{
            //    sb.AppendLine("\t\t(");
            //    for (int i = 0; i < queryDefinition.Item2.Length - 1; i++)
            //    {
            //        sb.AppendLine("\t\t" + queryDefinition.Item2[i].Name + ":@" + queryDefinition.Item2.Last().Name + "_" + queryDefinition.Item2[i].Name);
            //    }
            //    sb.AppendLine("\t\t)");
            //}
            //sb.AppendLine("\t\t{");

            //(ConstructorInfo, ParameterInfo[]) resultDefinition = queryDefinition.Item2.Last().ParameterType.GetConstructors().Select(c => (c, c.GetParameters())).First();
            //foreach (var item in resultDefinition.Item2)
            //{
            //    sb.AppendLine("\t\t" + item.Name);
            //}

            sb.AppendLine("\t\t}");
            sb.AppendLine("\t}");

            return sb.ToString();
        }

    }
}