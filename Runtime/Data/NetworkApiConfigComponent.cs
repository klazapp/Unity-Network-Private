using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace com.Klazapp.Utility
{
    [Serializable]
    public class NetworkApiConfigComponent
    {
        #region Variables
        public string baseUrl;
        public List<NetworkApiEndPoint> apiEndPoints = new();
        #endregion

        #region Modules
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private Dictionary<string, string> GetEndpointsDictionary()
        {
            var dict = new Dictionary<string, string>();
            foreach (var endpoint in apiEndPoints)
            {
                dict[endpoint.key] = endpoint.value;
            }
            return dict;
        }
        #endregion
        
        #region Public Access
        public string GetEndpointValue(string key)
        {
            var dict = GetEndpointsDictionary();
            if (dict.TryGetValue(key, out var value))
            {
                return value;
            }
            
            throw new KeyNotFoundException($"Endpoint key '{key}' not found in API configuration.");
        }
        #endregion
    }
}