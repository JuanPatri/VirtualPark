using VirtualPark.BusinessLogic.TypeIncidences.Models;

namespace VirtualPark.BusinessLogic.Test.TypeIncidences.Models;

[TestClass]
[TestCategory("TypeIncidenceArgsTest")]
public class TypeIncidenceArgsTest
{
    [TestMethod]
    public void Type_Getter_ReturnsAssignedValue()
    {
        var typeIncidenceArgs = new TypeIncidenceArgs("Locked");
        typeIncidenceArgs.Type.Should().Be("Locked");
    }
}
