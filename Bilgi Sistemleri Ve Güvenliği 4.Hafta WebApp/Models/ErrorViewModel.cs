using System;

namespace Bilgi_Sistemleri_Ve_Güvenliği_4.Hafta_WebApp.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
