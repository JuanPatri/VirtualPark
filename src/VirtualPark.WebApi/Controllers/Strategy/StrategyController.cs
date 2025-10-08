using Microsoft.AspNetCore.Mvc;
using VirtualPark.BusinessLogic.Strategy.Models;
using VirtualPark.BusinessLogic.Strategy.Services;
using VirtualPark.BusinessLogic.Validations.Services;
using VirtualPark.WebApi.Controllers.Strategy.ModelsIn;
using VirtualPark.WebApi.Controllers.Strategy.ModelsOut;

namespace VirtualPark.WebApi.Controllers.Strategy;

[ApiController]
[Route("strategies")]
public class StrategyController(IStrategyService strategyService) : ControllerBase
{
    private readonly IStrategyService _strategyService = strategyService;

   
}
