using UnityEngine.Networking;

namespace com.Klazapp.Utility
{
    public interface INetworkWebRequestBuilder
    {
        public UnityWebRequest BuildRequest(NetworkHttpMethod httpMethod, string apiUrl, string jsonData = "");

        public UnityWebRequest BuildBinaryRequest(NetworkHttpMethod httpMethod, string apiUrl, byte[] binaryData);
    }
}
