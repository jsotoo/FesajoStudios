#nullable disable

namespace FesajoStudios.Shared.Configuration
{
    public class AppSettings
    {
      
      public Jwt Jwt { get; set; }
     

    }


    public class Jwt
    {
        public string SecretKey { get; set; }
        public string Emisor { get; set; }
        public string Audiencia { get; set; }
    }
}
