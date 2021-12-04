namespace Wave.Schema.Attributes
{
    public class SchemaQueryAttribute : Attribute
    {
        public string queryName = "";
        public SchemaQueryAttribute(string queryName)
        {
            this.queryName = queryName;
        }
    }
}
