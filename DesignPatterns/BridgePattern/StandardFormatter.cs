namespace DesignPatterns.BridgePattern
{
    class StandardFormatter : ICustomFormatter
    {
        public string Format(string key, string value)
        {
            return $"{key} : {value}";
        }
    }
}
