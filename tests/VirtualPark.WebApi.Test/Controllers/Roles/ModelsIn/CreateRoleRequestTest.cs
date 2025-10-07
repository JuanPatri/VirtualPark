using FluentAssertions;
using VirtualPark.WebApi.Controllers.Roles.ModelsIn;

namespace VirtualPark.WebApi.Test.Controllers.Roles.ModelsIn;

[TestClass]
public class CreateRoleRequestTest
{
    #region Name
    [TestMethod]
    [TestCategory("Validation")]
    public void Name_Getter_ReturnsAssignedValue()
    {
        var request = new CreateRoleRequest { Name = "Admin" };
        request.Name.Should().Be("Admin");
    }
    #endregion
    #region Description
    [TestMethod]
    [TestCategory("Validation")]
    public void Description_Getter_ReturnsAssignedValue()
    {
        var request = new CreateRoleRequest { Description = "Full access to system" };
        request.Description.Should().Be("Full access to system");
    }
    #endregion
    #region Permissions
    [TestMethod]
    [TestCategory("Validation")]
    public void Permissions_Getter_ReturnsAssignedValue()
    {
        var perms = new List<string> { "users.read", "users.write" };
        var request = new CreateRoleRequest { Permissions = perms };

        request.Permissions.Should().Contain(new[] { "users.read", "users.write" });
    }
    #endregion
    #region ToArgs
        #region Success
        [TestMethod]
        [TestCategory("Validation")]
        public void ToArgs_ShouldMapAllFields_WhenInputIsValid()
        {
            var request = new CreateRoleRequest
            {
                Name = "Manager",
                Description = "Manage users and content",
                Permissions = new List<string> { "users.read", "users.update", "content.publish" }
            };

            var args = request.ToArgs();

            args.Should().NotBeNull();
            args!.Name.Should().Be("Manager");
            args.Description.Should().Be("Manage users and content");
            args.Permissions.Should().Contain(new[] { "users.read", "users.update", "content.publish" });
            args.Permissions.Should().HaveCount(3);
        }
        #endregion

        #region Failure
        [TestMethod]
        [TestCategory("Validation")]
        public void ToArgs_ShouldThrow_WhenPermissionsIsNull()
        {
            var request = new CreateRoleRequest
            {
                Name = "Reporter",
                Description = "Read-only access",
                Permissions = null
            };

            Action act = () => request.ToArgs();

            act.Should()
               .Throw<InvalidOperationException>()
               .WithMessage("Permission list can't be null");
        }

        [TestMethod]
        [TestCategory("Validation")]
        public void ToArgs_ShouldThrow_WhenPermissionsIsEmpty()
        {
            var request = new CreateRoleRequest
            {
                Name = "Reporter",
                Description = "Read-only access",
                Permissions = new List<string>()
            };

            Action act = () => request.ToArgs();

            act.Should()
               .Throw<InvalidOperationException>()
               .WithMessage("Permission list can't be null");
        }

        [TestMethod]
        [TestCategory("Validation")]
        public void ToArgs_ShouldThrow_WhenNameIsNull()
        {
            var request = new CreateRoleRequest
            {
                Name = null,
                Description = "Some description",
                Permissions = new List<string> { "users.read" }
            };

            Action act = () => request.ToArgs();

            act.Should().Throw<ArgumentException>();
        }

        [TestMethod]
        [TestCategory("Validation")]
        public void ToArgs_ShouldThrow_WhenNameIsEmpty()
        {
            var request = new CreateRoleRequest
            {
                Name = string.Empty,
                Description = "Some description",
                Permissions = new List<string> { "users.read" }
            };

            Action act = () => request.ToArgs();

            act.Should().Throw<ArgumentException>();
        }

        [TestMethod]
        [TestCategory("Validation")]
        public void ToArgs_ShouldThrow_WhenDescriptionIsNull()
        {
            var request = new CreateRoleRequest
            {
                Name = "Operator",
                Description = null,
                Permissions = new List<string> { "users.read" }
            };

            Action act = () => request.ToArgs();

            act.Should().Throw<ArgumentException>();
        }

        [TestMethod]
        [TestCategory("Validation")]
        public void ToArgs_ShouldThrow_WhenDescriptionIsEmpty()
        {
            var request = new CreateRoleRequest
            {
                Name = "Operator",
                Description = string.Empty,
                Permissions = new List<string> { "users.read" }
            };

            Action act = () => request.ToArgs();

            act.Should().Throw<ArgumentException>();
        }
        #endregion
        #endregion
}
