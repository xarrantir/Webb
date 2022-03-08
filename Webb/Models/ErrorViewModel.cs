using System;

namespace Webb.Models
{
    public class MvcMovieContext
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
