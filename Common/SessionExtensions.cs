using Newtonsoft.Json;

namespace PropEquityME.Common
{
    public static class SessionExtensions
    {
        public static void SetSession<T>(this ISession session, string key, T value)
        {
            session.SetString(key, JsonConvert.SerializeObject(value));
        }

        public static T GetSession<T>(this ISession session, string key)
        {
            var value = session.GetString(key);
            return value == null ? default(T) : JsonConvert.DeserializeObject<T>(value);
        }
        public static bool HasSession(this ISession session, string key)
        {
            var value = session.GetString(key);
            return value != null;
        }

    }
}
