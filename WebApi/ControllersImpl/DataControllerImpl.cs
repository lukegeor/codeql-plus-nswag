using Microsoft.AspNetCore.Mvc;

namespace WebApi.ControllersImpl;

public class DataControllerImpl : IDataController
{
    public Task<ActionResult<DataDto>> GetDataAsync(CancellationToken cancellationToken = default(CancellationToken))
    {
        return Task.FromResult((ActionResult<DataDto>)new OkObjectResult(new DataDto
        {
            Id = "1",
            Info = "Info"
        }));
    }
}