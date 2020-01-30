using System;
namespace BhdPaymentButtonForSgs.Infrastructure.ObjectsForBhd
{
    /// <summary>
    /// Objeto que se le envia al servicio
    /// https://AMBIENTE.bhdleon.com.do/bhdleon/boton/v2/proveedores/autenticacion
    /// para solicitar el Token que debe ser devuelto al consumidor del servicio
    /// </summary>
    public class BhdPaymentButtonRequest
    {
        public string clientId { get; set; }
        public string clientSecret { get; set; }
        public string billingNumber { get; set; }
        public string currency { get; private set; } = "RD";
        public string amount { get; set; }
        public string returnedURL { get; set; }
        public string cancelledURL { get; set; }
        public string transactionId { get; set; }
        public string scope { get; set; }
        public string description { get; set; }
    }
}