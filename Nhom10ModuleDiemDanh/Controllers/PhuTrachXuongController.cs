﻿using Microsoft.AspNetCore.Mvc;

namespace Nhom10ModuleDiemDanh.Controllers
{
    public class PhuTrachXuongController : Controller
    {
        public IActionResult Index()
        {
            return View("PhuTrachXuong");
        }
    }
}
