using ceiba.dapr.traffic.control.Domain.Models;

namespace ceiba.dapr.traffic.control.Domain
{
    public interface IVehicleInfoRepository
    {
        VehicleInfo GetVehicleInfo(string? licenseNumber);
    }
}