using System;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Moq;
using VirtualPark.BusinessLogic.Permissions.Entity;
using VirtualPark.BusinessLogic.Roles.Entity;
using VirtualPark.BusinessLogic.Roles.Models;
using VirtualPark.BusinessLogic.Roles.Service;
using VirtualPark.BusinessLogic.Users.Entity;
using VirtualPark.WebApi.Controllers.Roles;
using VirtualPark.WebApi.Controllers.Roles.ModelsIn;
using VirtualPark.WebApi.Controllers.Roles.ModelsOut;

namespace VirtualPark.WebApi.Test.Controllers.Roles;

[TestClass]
public class RoleControllerTest
{
    private Mock<IRoleService> _roleServiceMock = null!;
    private RoleController _roleController = null!;

    [TestInitialize]
    public void Initialize()
    {
        _roleServiceMock = new Mock<IRoleService>(MockBehavior.Strict);
        _roleController = new RoleController(_roleServiceMock.Object);
    }
    #region Create
    [TestMethod]
    public void CreateRole_ValidInput_ReturnsCreatedRoleResponse()
    {
        var p1 = Guid.NewGuid().ToString();
        var p2 = Guid.NewGuid().ToString();
        var returnId = Guid.NewGuid();

        var request = new CreateRoleRequest
        {
            Name = "Admin",
            Description = "Full access",
            PermissionsIds = [p1, p2]
        };

        var expectedArgs = request.ToArgs();

        _roleServiceMock
            .Setup(s => s.Create(It.Is<RoleArgs>(a =>
                a.Name == expectedArgs.Name &&
                a.Description == expectedArgs.Description &&
                a.PermissionIds.Count == expectedArgs.PermissionIds.Count &&
                a.PermissionIds.All(expectedArgs.PermissionIds.Contains))))
            .Returns(returnId);

        var response = _roleController.CreateRole(request);

        response.Should().NotBeNull();
        response.Should().BeOfType<CreateRoleResponse>();
        response.Id.Should().Be(returnId.ToString());

        _roleServiceMock.VerifyAll();
    }
    #endregion
}
