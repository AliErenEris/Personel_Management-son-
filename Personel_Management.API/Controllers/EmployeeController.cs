using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Personel_Management.Core.DTOs;
using Personel_Management.Core.Entities;
using Personel_Management.Core.Service;
using Personel_Management.Service.Services;

namespace Personel_Management.API.Controllers
{
    public class EmployeeController : Controller
    {

        private readonly IEmployeeService _employeeService;
        private readonly IMapper _mapper;

        public EmployeeController(IEmployeeService employeeService, IMapper mapper)
        {
            _employeeService = employeeService;
            _mapper = mapper;
        }


        [HttpGet]
        public async Task<IActionResult> All()
        {
            var employees = await _employeeService.GetAllAsync();
            var employeesDtos = _mapper.Map<List<EmployeeDto>>(employees.ToList());

            return Ok(employeesDtos);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var employee = await _employeeService.GetByIdAsync(id);
            var employeeDto = _mapper.Map<EmployeeDto>(employee);
            return Ok(employeeDto);
        }

        [HttpPost]
        public async Task<IActionResult> Save(EmployeeDto employeeDto)
        {
            var employee = await _employeeService.AddAsync(_mapper.Map<Employee>(employeeDto));
            employeeDto = _mapper.Map<EmployeeDto>(employee);
            return Ok(employeeDto);
        }

        [HttpPut]
        public async Task<IActionResult> Update(EmployeeDto employeeDto)
        {
            await _employeeService.UpdateAsync(_mapper.Map<Employee>(employeeDto));
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            var employee = await _employeeService.GetByIdAsync(id);
            await _employeeService.RemoveAsync(employee);
            return Ok();
        }
    }
}
