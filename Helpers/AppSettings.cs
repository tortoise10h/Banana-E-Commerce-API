using System;

namespace Banana_E_Commerce_API.Helpers
{
    public class AppSettings
    {
        public string SecretKey { get; set; }
        public TimeSpan TokenLifeTime { get; set; }
        public string UploadDir { get; set; }
        public string ProductImageDir { get; set; }
        public string ImportBillImageDir { get; set; }
    }
}