using System;
using System.Collections;
using UnityEngine.Networking;

namespace com.Klazapp.Utility
{
    public interface INetworkWebRequestSender
    {
        public IEnumerator SendWebRequest(UnityWebRequest request, Action<UnityWebRequest> onSuccess, Action<UnityWebRequest> onError);
    }
}
