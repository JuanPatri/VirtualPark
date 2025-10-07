using Microsoft.AspNetCore.Mvc;
using VirtualPark.BusinessLogic.Incidences.Models;
using VirtualPark.BusinessLogic.Incidences.Service;
using VirtualPark.WebApi.Controllers.Incidences.ModelsIn;
using VirtualPark.WebApi.Controllers.Incidences.ModelsOut;

namespace VirtualPark.WebApi.Controllers.Incidences;

[ApiController]
[Route("api/incidences")]
public sealed class IncidenceController(IIncidenceService incidenceService) : ControllerBase
{
    private readonly IIncidenceService _incidenceService = incidenceService;

}
