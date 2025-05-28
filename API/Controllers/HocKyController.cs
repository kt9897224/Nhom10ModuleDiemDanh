﻿using API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HocKyController : ControllerBase
    {
        private readonly ModuleDiemDanhDbContext _diemDanhDbContext;
        public HocKyController(ModuleDiemDanhDbContext moduleDiemDanhDbContext)
        {
            _diemDanhDbContext = moduleDiemDanhDbContext;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var data = await _diemDanhDbContext.hocKy.ToListAsync();
            return Ok(data);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var hocKy = await _diemDanhDbContext.hocKy.FindAsync(id);
            if (hocKy == null) return NotFound();
            return Ok(hocKy);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromForm] HocKy hocKy)
        {
            hocKy.IdHocKy = Guid.NewGuid();
            hocKy.NgayTao = DateTime.Now;
            hocKy.TrangThai = true;

            _diemDanhDbContext.hocKy.Add(hocKy);
            await _diemDanhDbContext.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, [FromBody] HocKy updatedHocKy)
        {
            var hocKy = await _diemDanhDbContext.hocKy.FindAsync(id);
            if (hocKy == null) return NotFound();

            hocKy.TenHocKy = updatedHocKy.TenHocKy;
            hocKy.NgayCapNhat = DateTime.Now;
            hocKy.TrangThai = updatedHocKy.TrangThai;
            await _diemDanhDbContext.SaveChangesAsync();

            return Ok(hocKy);
        }

        [HttpPost("doi-trang-thai/{id}")]
        public async Task<IActionResult> DoiTrangThai(Guid id)
        {
            var hocKy = await _diemDanhDbContext.hocKy.FindAsync(id);
            if (hocKy == null)
            {
                return NotFound();
            }

            hocKy.TrangThai = !hocKy.TrangThai;
            hocKy.NgayCapNhat = DateTime.Now;

            _diemDanhDbContext.hocKy.Update(hocKy);
            await _diemDanhDbContext.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}
