using FluentAssertions;
using Moq;
using VirtualPark.BusinessLogic.TypeIncidences.Entity;
using VirtualPark.BusinessLogic.TypeIncidences.Models;
using VirtualPark.BusinessLogic.TypeIncidences.Service;
using VirtualPark.Repository;

namespace VirtualPark.BusinessLogic.Test.TypeIncidences.Service;

[TestClass]
[TestCategory("TypeIncidenceService")]
public class TypeIncidenceServiceTest
{
    private Mock<IRepository<TypeIncidence>> _mockTypeIncidenceRepository = null!;
    private TypeIncidenceService _typeIncidenceService = null!;
    private TypeIncidenceArgs _typeIncidenceArgs = null!;

    [TestInitialize]
    public void Initialize()
    {
        _mockTypeIncidenceRepository = new Mock<IRepository<TypeIncidence>>(MockBehavior.Strict);
        _typeIncidenceService = new TypeIncidenceService(_mockTypeIncidenceRepository.Object);
        _typeIncidenceArgs = new TypeIncidenceArgs(type: "Locked");
    }

}
