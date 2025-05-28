using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using API.Data;
using Azure;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.Blazor;

namespace AppView.Controllers
{
    public class CaHocsController : Controller
    {
        private readonly string _apiBase = "https://localhost:7296/api/CaHocs";

        // GET: CaHocs
        public async Task<IActionResult> Index()
        {
            List<CaHoc> danhSach = new List<CaHoc>();
            using (var http = new HttpClient())
            {
                var response = await http.GetAsync(_apiBase);
                string json = await response.Content.ReadAsStringAsync();

                var wrapper = JsonConvert.DeserializeObject<ApiResponse<List<CaHoc>>>(json);
                danhSach = wrapper.data;
            }
            return View(danhSach);
        }

        // GET: CaHocs/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null) return NotFound();

            CaHoc caHoc = null;
            using (var http = new HttpClient())
            {
                var response = await http.GetAsync($"{_apiBase}/{id}");
                string json = await response.Content.ReadAsStringAsync();

                var wrapper = JsonConvert.DeserializeObject<ApiResponse<CaHoc>>(json);
                caHoc = wrapper.data;
            }
            return View(caHoc);
        }

        // GET: CaHocs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CaHocs/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CaHoc caHoc)
        {
            try
            {
                using (var http = new HttpClient())
                {
                    var content = new StringContent(JsonConvert.SerializeObject(caHoc), Encoding.UTF8, "application/json");
                    var response = await http.PostAsync(_apiBase, content);

                    if (!response.IsSuccessStatusCode)
                    {
                        var err = await response.Content.ReadAsStringAsync();
                        ViewBag.Error = $"API trả lỗi {response.StatusCode}: {err}";
                        return View(caHoc);
                    }
                }

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Error = "Lỗi xử lý dữ liệu: " + ex.Message;
                return View(caHoc);
            }
        }


        // GET: CaHocs/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null) return NotFound();

            CaHoc caHoc = null;
            using (var http = new HttpClient())
            {
                var response = await http.GetAsync($"{_apiBase}/{id}");
                string json = await response.Content.ReadAsStringAsync();

                var wrapper = JsonConvert.DeserializeObject<ApiResponse<CaHoc>>(json);
                caHoc = wrapper.data;
            }
            return View(caHoc);
        }

        // POST: CaHocs/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, CaHoc caHoc)
        {
            using (var http = new HttpClient())
            {
                var content = new StringContent(JsonConvert.SerializeObject(caHoc), Encoding.UTF8, "application/json");
                var response = await http.PutAsync($"{_apiBase}?id={id}", content);

                if (!response.IsSuccessStatusCode)
                {
                    var err = await response.Content.ReadAsStringAsync();
                    ViewBag.Error = $"Lỗi API: {response.StatusCode} - {err}";
                    return View(caHoc);
                }
            }

            return RedirectToAction(nameof(Index));
        }

        // GET: CaHocs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            using (var http = new HttpClient())
            {
                var response = await http.DeleteAsync($"{_apiBase}/{id}");

                if (!response.IsSuccessStatusCode)
                {
                    var error = await response.Content.ReadAsStringAsync();
                    ViewBag.Error = $"Xoá thất bại: {response.StatusCode} - {error}";
                    return RedirectToAction(nameof(Delete), new { id }); // Trả về view lỗi
                }
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
