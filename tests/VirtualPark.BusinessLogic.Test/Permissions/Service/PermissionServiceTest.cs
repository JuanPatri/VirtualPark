namespace VirtualPark.BusinessLogic.Test.Permissions.Service;

[TestClass]
[TestCategory("Service")]
[TestCategory("Permission")]
public sealed class PermissionServiceTest
{
    [TestMethod]
    [TestCategory("Service")]
    [TestCategory("Permission")]
    [TestCategory("Behaviour")]
    public void Create_WhenArgsAreValid_ShouldReturnPermissionId()
    {
        var roleId = Guid.NewGuid();
        var role = new Role { Id = roleId, Name = "Admin" };

        _roleRepositoryMock
            .Setup(r => r.Get(It.IsAny<Expression<Func<Role, bool>>>()))
            .Returns(role);

        var args = new PermissionArgs("Can manage users", "user.manage", new List<Guid> { roleId });

        Permission? captured = null;
        _permissionRepositoryMock
            .Setup(r => r.Add(It.IsAny<Permission>()))
            .Callback<Permission>(p => captured = p);

        var id = _service.Create(args);

        id.Should().NotBeEmpty();
        captured.Should().NotBeNull();
        captured!.Key.Should().Be("user.manage");
        captured.Roles.Should().ContainSingle(r => r.Id == roleId);
    }
}
