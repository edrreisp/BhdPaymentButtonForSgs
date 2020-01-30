namespace BhdPaymentButtonForSgs.Infrastructure.ObjectsForBhd
{
    public class BhdPaymentButtonResponse
    {
        public string jwt { get; set; }
        public string access_token { get; set; }
        public string redirect_url { get; set; }
    }
}
