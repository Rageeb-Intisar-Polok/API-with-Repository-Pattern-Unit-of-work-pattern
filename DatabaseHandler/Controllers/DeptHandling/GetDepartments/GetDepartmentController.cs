using AdminDBHandler.Models.Dept_Level_Term;
using CoreApiResponse;
using DatabaseHandler.Models_and_repositories.Dept_Level_Term.repositories.DeptRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DatabaseHandler.Controllers.DeptHandling.GetDepartments
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetDepartmentController : BaseController
    {
        IDepartmentRepository _departmentRepository;
        public GetDepartmentController(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }
        [HttpGet]
        public async Task<IActionResult> getDepts()
        {
            try
            {
              //  SortedSet<Department> depts = new SortedSet<Department>();
                var a = await _departmentRepository.GetAll();
                return CustomResult(a);
            }
            catch(Exception ex)
            {
                return CustomResult(ex.Message,System.Net.HttpStatusCode.BadRequest);
            }
        }
    }
}
