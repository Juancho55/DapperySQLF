using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RedArborTest.API.Models.EmployeeAPI;
using RedArborTest.API.ModelsAPI.Mapper;
using Services.Services.Employee;
using System.Net.Mime;

namespace RedArborTest.API.Controllers
{
    [ApiController]
    [Produces(MediaTypeNames.Application.Json)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]

    public class EmployeeController : BaseController
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IMapper mapper, IEmployeeService employeeService) : base(mapper)
        {
            _employeeService = employeeService;
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("/api/redarbor/")]
        public async Task<IActionResult> Save([FromBody] EmployeeRequestModel modelAPI)
        {
            if (!ModelState.IsValid) return GetBadRequest();
            try
            {
                bool result = await _employeeService.SaveAsync(new EmployeeMap().Mapreq(modelAPI));

                return new Result.CreateResult(result);
            }
            catch (Exception ex)
            {
                return GetErrorresult(ex);
            }
        }

        [HttpPut]
        [AllowAnonymous]
        [Route("/api/redarbor/")]
        public async Task<IActionResult> Update(int id, [FromBody] EmployeeRequestModel modelAPI)
        {
            if (!ModelState.IsValid) return GetBadRequest();
            try
            {
                bool result = await _employeeService.UpdateAsync(id, new EmployeeMap().Mapreq(modelAPI, id));

                return new Result.CreateResult(result);
            }
            catch (Exception ex)
            {
                return GetErrorresult(ex);
            }
        }

        [HttpDelete]
        [AllowAnonymous]
        [Route("/api/redarbor/")]
        public async Task<IActionResult> Delete(int id)
        {
            if (!ModelState.IsValid) return GetBadRequest();
            try
            {
                bool result = await _employeeService.DeleteAsync(id);

                return new Result.CreateResult(result);
            }
            catch (Exception ex)
            {
                return GetErrorresult(ex);
            }
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("/api/redarbor/")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                List<EmployeeResponseModel> result = new EmployeeMap().Mapresponse(await _employeeService.GetAllAsync());

                return new Result.CreateResult(result);
            }
            catch (Exception ex)
            {
                return GetErrorresult(ex);
            }
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("/api/redarbor/ById")]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                EmployeeResponseModel result = new EmployeeMap().Mapresponse(await _employeeService.GetByIdAsync(id));

                return new Result.CreateResult(result);
            }
            catch (Exception ex)
            {
                return GetErrorresult(ex);
            }
        }
    }
}
