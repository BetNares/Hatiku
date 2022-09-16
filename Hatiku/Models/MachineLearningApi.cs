using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hatiku.Models
{
    public class MlApi
    {
        private string id;
        private string endpoint;
        private string apiKey;
        private bool isConnect;

        public string Id { get => id; set => id = value; }
        public string Endpoint { get => endpoint; set => endpoint = value; }
        public string ApiKey { get => apiKey; set => apiKey = value; }
        public bool IsConnect { get => isConnect; set => isConnect = value; }

    }
}
