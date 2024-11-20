using Infraestructure.Interface;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Services.Services.Employee;

namespace Test
{
    [TestClass]
    public class EmployeeServiceTest
    {
        [TestMethod]
        public Task EmployeeServiceAdd()
        {
            ///Arrange

            var employeeInsert = new Models.Employee.Employee()
            {
                CompanyId = 1,
                CreateOn = DateTime.Now,
                DeleteOn = DateTime.Now,
                Email = "prueba1@test.com",
                EmployeeId = 1,
                FAX = "000.000.000",
                LastLogin = DateTime.Now,
                Name = "JhonE",
                Passwrod = "12345678",
                PortalId = 1,
                RoleId = 1,
                StatusId = 1,
                Telephone = "000.000.000",
                UpdateOn = DateTime.Now,
                UserName = "PlayJuanda"
            };

            ///Act

            Mock<IEmployeeSave> mockSave = new Mock<IEmployeeSave>();
            Mock<IEmployeeUpdate> mockUpdate = new Mock<IEmployeeUpdate>();
            Mock<IEmployeeDelete> mockDelete = new Mock<IEmployeeDelete>();
            Mock<IEmployeeGet> mockGet = new Mock<IEmployeeGet>();

            EmployeeService service = new EmployeeService(mockDelete.Object, mockSave.Object, mockUpdate.Object, mockGet.Object);

            Task<bool> result = service.SaveAsync(employeeInsert);

            ///Assert
            Assert.IsTrue(result.Result);
            return result;
        }
    }
}
