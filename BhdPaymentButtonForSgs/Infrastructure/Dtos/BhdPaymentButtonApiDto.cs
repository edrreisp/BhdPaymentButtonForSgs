using System.ComponentModel.DataAnnotations;
using BhdPaymentButtonForSgs.Enums;

namespace BhdPaymentButtonForSgs.Infrastructure.Dtos
{
    /// <summary>
    /// Objeto que el backend de la aplicacion de jade Enviara a este servicio
    /// Solo envia la data necesaria para la transacción, excluyendo las llaves
    /// que solo son almacenadas por el servidor de SGS
    /// </summary>
    public class BhdPaymentButtonApiDto
    {
        [Required]
        public RestaurantType restaurantType { get; set; }
        [Required]
        public string billingNumber { get; set; }
        [Required]
        public string amount { get; set; }
        [Required]
        public string returnedURL { get; set; }
        [Required]
        public string cancelledURL { get; set; }
        [Required]
        public string transactionId { get; set; }
        [Required]
        public string scope { get; set; }
        [Required]
        public string description { get; set; }
    }
}
