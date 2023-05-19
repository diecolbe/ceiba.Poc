using ceiba.dapr.traffic.control.Domain;
using ceiba.dapr.traffic.control.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace VehicleRegistrationService.Controllers;

[ApiController]
[Route("[controller]")]
public class VehicleInfoController : ControllerBase
{
    private readonly ILogger<VehicleInfoController> _logger;
    private readonly IVehicleInfoRepository _vehicleInfoRepository;

    public VehicleInfoController(ILogger<VehicleInfoController> logger, IVehicleInfoRepository vehicleInfoRepository) =>
        (_logger, _vehicleInfoRepository) = (logger, vehicleInfoRepository);


    [HttpGet("{licenseNumber}")]
    public async Task<VehicleInfo> GetVehicleInfo(string? licenseNumber)
    {
        _logger.LogInformation($"Retrieving vehicle-info for licensenumber {licenseNumber}");
        VehicleInfo info = await
        Task.Run(() =>
        {
            return _vehicleInfoRepository.GetVehicleInfo(licenseNumber);

        });
        return info;
    }
}