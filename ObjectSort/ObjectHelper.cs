namespace CustomObjectSort
{
    public static class ObjectHelper
    {
        public static T GetPropertyValue<T>(object obj, string propName)
        {
            return (T)obj.GetType().GetProperty(propName).GetValue(obj, null);
        }
    }
}
