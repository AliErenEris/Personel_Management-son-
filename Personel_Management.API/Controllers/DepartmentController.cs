using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Personel_Management.Core.DTOs;
using Personel_Management.Core.Entities;
using Personel_Management.Core.Service;

namespace Personel_Management.API.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartmentService _departmentService;
        private readonly IMapper _mapper;

        public DepartmentController(IMapper mapper, IDepartmentService departmentService)
        {
            _departmentService = departmentService;
            _mapper = mapper;
        }


        [HttpGet]
        public async Task<IActionResult> All()
        {
            var departments = await _departmentService.GetAllAsync();
            var departmentsDtos = _mapper.Map<List<departmentDto>>(departments.ToList());
            
            return Ok(departmentsDtos);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var department = await _departmentService.GetByIdAsync(id);
            var departmentDto = _mapper.Map<departmentDto>(department);
            return Ok(departmentDto);
        }

        [HttpPost]
        public async Task<IActionResult> Save(departmentDto departmentDto)
        {
            var department = await _departmentService.AddAsync(_mapper.Map<Department>(departmentDto));
            departmentDto = _mapper.Map<departmentDto>(department);
            return Ok(departmentDto);
        }

        [HttpPut]
        public async Task<IActionResult> Update(departmentDto productDto)
        {
            await _departmentService.UpdateAsync(_mapper.Map<Department>(productDto));
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            var product = await _departmentService.GetByIdAsync(id);
            await _departmentService.RemoveAsync(product);
            return Ok();
        }

    }
}
