using System;
using UnityEngine;

namespace com.Klazapp.Utility
{
    [CreateAssetMenu(fileName = "Network Header Config Template", menuName = "Klazapp/Templates/Network/Network Header Config Template")]
    [Serializable]
    public class NetworkHeaderConfigTemplate : ScriptableObject
    {
        [Header("Network Api Config")]
        public NetworkHeaderConfigComponent networkHeaderConfigComponent;
    }
}