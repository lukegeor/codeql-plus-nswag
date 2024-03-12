using Microsoft.AspNetCore.Mvc;

namespace WebApi.ControllersImpl;

public class DataControllerImpl : IDataController
{
    private readonly ILogger<DataControllerImpl> _logger;

    public DataControllerImpl(ILogger<DataControllerImpl> logger)
    {
        _logger = logger;
    }

    public Task<ActionResult<ICollection<DataDto>>> GetDataAsync(
        CancellationToken cancellationToken = default)
    {
        return Task.FromResult((ActionResult<ICollection<DataDto>>) new OkObjectResult(new[]
        {
            new DataDto
            {
                Id = "1",
                Info = "Info"
            }
        }));
    }

    public Task<ActionResult<DataDto>> GetDataForUserAsync(string userId,
        CancellationToken cancellationToken = default)
    {
        _logger.LogDebug($"UserId: {userId}");
        return Task.FromResult((ActionResult<DataDto>) new OkObjectResult(
            new DataDto
            {
                Id = "1",
                Info = "Info"
            }));
    }
}