using System;
using UnityEngine;
using UnityEngine.Networking;

namespace com.Klazapp.Utility
{
    [CreateAssetMenu(fileName = "Network Api Config Template", menuName = "Klazapp/Templates/Network/Network Api Config Template")]
    [Serializable]
    public class NetworkApiConfigTemplate : ScriptableObject
    {
        [Header("Network Api Config")]
        public NetworkApiConfigComponent networkApiConfigComponent;
        
        public string BuildUrl(string basePath, params (string key, string value)[] queryParameters)
        {
            var uriBuilder = new System.Text.StringBuilder($"{networkApiConfigComponent.baseUrl}{basePath}");
            
            if (queryParameters.Length <= 0) 
                return uriBuilder.ToString();
            
            uriBuilder.Append("?");
            
            foreach (var (key, value) in queryParameters)
            {
                uriBuilder.Append($"{UnityWebRequest.EscapeURL(key)}={UnityWebRequest.EscapeURL(value)}&");
            }
            
            uriBuilder.Length--; // Removes the last '&' for cleanliness
            
            return uriBuilder.ToString();
        }

        public string GetUrlByEndPoint(string endPoint)
        {
            return networkApiConfigComponent.GetEndpointValue(endPoint);
        }
    }
}