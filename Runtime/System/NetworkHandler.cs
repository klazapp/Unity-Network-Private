using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Networking;

namespace com.Klazapp.Utility
{
    public abstract class NetworkHandler : MonoBehaviour, INetworkWebRequestBuilder, INetworkWebRequestSender
    {
        #region INetworkWebRequestBuilder
        public UnityWebRequest BuildRequest(NetworkHttpMethod httpMethod, string apiUrl, string jsonData = "")
        {
            UnityWebRequest webRequest;
            
            switch (httpMethod)
            {
                case NetworkHttpMethod.Get:
                    webRequest = UnityWebRequest.Get(apiUrl);
                    break;
                case NetworkHttpMethod.Post:
                    webRequest = new UnityWebRequest(apiUrl, "POST");
                    var jsonToSend = new System.Text.UTF8Encoding().GetBytes(jsonData);
                    webRequest.uploadHandler = new UploadHandlerRaw(jsonToSend);
                    webRequest.downloadHandler = new DownloadHandlerBuffer();
                    break;
                case NetworkHttpMethod.Put:
                    webRequest = UnityWebRequest.Put(apiUrl, jsonData);
                    break;
                case NetworkHttpMethod.Delete:
                    webRequest = UnityWebRequest.Delete(apiUrl);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(httpMethod), httpMethod, null);
            }

            if (webRequest == null)
            {
                throw new InvalidOperationException("Failed to create a web request due to an invalid or unsupported HTTP httpMethod.");
            }
            
            webRequest.SetRequestHeader("Content-Type", "application/json");
            return webRequest;
        }
        
        public UnityWebRequest BuildBinaryRequest(NetworkHttpMethod httpMethod, string apiUrl, byte[] binaryData)
        {
            UnityWebRequest webRequest;

            switch (httpMethod)
            {
                case NetworkHttpMethod.Post:
                    webRequest = new UnityWebRequest(apiUrl, "POST");
                    webRequest.uploadHandler = new UploadHandlerRaw(binaryData);
                    webRequest.downloadHandler = new DownloadHandlerBuffer();
                    break;
                case NetworkHttpMethod.Get:
                case NetworkHttpMethod.Put:
                case NetworkHttpMethod.Delete:
                default:
                    throw new ArgumentOutOfRangeException(nameof(httpMethod), httpMethod, null);
            }

            if (webRequest == null)
            {
                throw new InvalidOperationException("Failed to create a web request due to an invalid or unsupported HTTP httpMethod.");
            }

            webRequest.SetRequestHeader("Content-Type", "application/octet-stream");
            return webRequest;
        }
        #endregion

        #region INetworkWebRequestSender
        public IEnumerator SendWebRequest(UnityWebRequest request, Action<UnityWebRequest> onSuccess, Action<UnityWebRequest> onError)
        {
            yield return request.SendWebRequest();

            if (request.result is UnityWebRequest.Result.ConnectionError or UnityWebRequest.Result.ProtocolError)
            {
                onError?.Invoke(request);
            }
            else
            {
                onSuccess?.Invoke(request);
            }
        }
        #endregion
    }
}
