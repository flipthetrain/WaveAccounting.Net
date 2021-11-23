using System.Reflection;
using System.Text;
using Wave.GraphQL.Attributes;

namespace Wave.GraphQL
{
    public record QueryEngine
    {
        public string generateQuery<T>()
        {
            if (typeof(T).GetCustomAttribute<SchemaQueryAttribute>() == null)
                throw new ArgumentException($"{typeof(T)} does not contain Query attribute.");

            (ConstructorInfo, ParameterInfo[]) queryDefinition = typeof(T).GetConstructors().Select(qd => (qd, qd.GetParameters())).First();

            if (queryDefinition.Item2
                                .Where(p => p.ParameterType.GetCustomAttribute<SchemaObjectAttribute>() == null
                                            && !p.ParameterType.IsPrimitive
                                            && p.ParameterType != typeof(string)).Count() > 0)
                throw new ArgumentException($"Parameters of {typeof(T)} must be {typeof(SchemaObjectAttribute)}, string, or primitive");

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("query\t{");

            sb.AppendLine("\t" + queryDefinition.Item2.Last().Name);
            if (queryDefinition.Item2.Length > 1)
            {
                sb.AppendLine("\t\t(");
                for (int i = 0; i < queryDefinition.Item2.Length - 1; i++)
                {
                    sb.AppendLine("\t\t" + queryDefinition.Item2[i].Name + ":@" + queryDefinition.Item2.Last().Name + "_" + queryDefinition.Item2[i].Name);
                }
                sb.AppendLine("\t\t)");
            }
            sb.AppendLine("\t\t{");

            (ConstructorInfo, ParameterInfo[]) resultDefinition = queryDefinition.Item2.Last().ParameterType.GetConstructors().Select(c => (c, c.GetParameters())).First();
            foreach (var item in resultDefinition.Item2)
            {
                sb.AppendLine("\t\t" + item.Name);
            }

            sb.AppendLine("\t\t}");
            sb.AppendLine("\t}");

            return sb.ToString();
        }

    }
}