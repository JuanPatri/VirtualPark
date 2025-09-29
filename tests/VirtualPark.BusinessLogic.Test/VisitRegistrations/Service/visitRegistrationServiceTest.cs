using Moq;
using VirtualPark.BusinessLogic.VisitorsProfile.Entity;
using VirtualPark.BusinessLogic.VisitorsProfile.Service;
using VirtualPark.BusinessLogic.VisitRegistrations.Entity;
using VirtualPark.Repository;

namespace VirtualPark.BusinessLogic.Test.VisitRegistrations.Service;

[TestClass]
[TestCategory("Service")]
[TestCategory("VisitRegistrationServiceTest")]
public class VisitRegistrationServiceTest
{
    private Mock<IRepository<VisitRegistration>> _repositoryMock = null!;
    private VisitRegistrationService _service = null!;

    [TestInitialize]
    public void Initialize()
    {
        _repositoryMock = new Mock<IRepository<VisitRegistration>>(MockBehavior.Strict);
        _service = new VisitRegistrationService(_repositoryMock.Object);
    }
}
