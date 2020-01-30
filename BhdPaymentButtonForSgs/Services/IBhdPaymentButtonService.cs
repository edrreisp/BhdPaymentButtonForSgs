using System.Threading.Tasks;
using BhdPaymentButtonForSgs.Infrastructure.Dtos;
using BhdPaymentButtonForSgs.Infrastructure.ObjectsForBhd;

namespace BhdPaymentButtonForSgs.Services
{
    public interface IBhdPaymentButtonService
    {
        Task<BhdPaymentButtonResponse> PayWithBhdButton(BhdPaymentButtonApiDto dto);
    }
}
