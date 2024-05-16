using System;
using System.Collections.Generic;

namespace com.Klazapp.Utility
{
    [Serializable]
    public class NetworkHeaderConfigComponent
    {
        #region Variables
        public List<NetworkHeaderRequest> headerRequests = new();
        #endregion

    }
}