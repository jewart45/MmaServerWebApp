using System;

namespace MmaServerWebApp.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; } = "Heyo Josh";

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
