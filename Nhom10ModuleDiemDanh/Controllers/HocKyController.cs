using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Text;
using API.Data;
using System.Net.Http;

namespace Nhom10ModuleDiemDanh.Controllers
{
    public class HocKyController : Controller
    {
        private readonly HttpClient _client;

        public HocKyController(IHttpClientFactory factory)
        {
            var client = factory.CreateClient("MyApi"); 
            client.BaseAddress = new Uri("https://localhost:7296/api/"); 
            _client = client;
        }

        public async Task<IActionResult> Index()
        {
            var response = await _client.GetAsync("HocKy");

            if (!response.IsSuccessStatusCode)
            {
                return View(new List<HocKy>());
            }

            var json = await response.Content.ReadAsStringAsync();
            if (string.IsNullOrWhiteSpace(json))
            {
                return View(new List<HocKy>());
            }

            var data = JsonSerializer.Deserialize<List<HocKy>>(json, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            return View(data);
        }

        public IActionResult Create() => View();

        [HttpPost]
        public async Task<IActionResult> Create(HocKy model)
        {
            var json = JsonSerializer.Serialize(model);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _client.PostAsync("HocKy", content);
            if (response.IsSuccessStatusCode)
                return RedirectToAction("Index");

            return View(model);
        }

        public async Task<IActionResult> Edit(Guid id)
        {
            var response = await _client.GetAsync($"HocKy/{id}");
            if (!response.IsSuccessStatusCode) return NotFound();

            var json = await response.Content.ReadAsStringAsync();
            var hocKy = JsonSerializer.Deserialize<HocKy>(json, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            return View(hocKy);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(HocKy model)
        {
            var json = JsonSerializer.Serialize(model);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _client.PutAsync($"HocKy/{model.IdHocKy}", content);

            if (response.IsSuccessStatusCode)
                return RedirectToAction("Index");

            return View(model);
        }

        public async Task<IActionResult> ToggleStatus(Guid id)
        {
            HocKy hocKy = null;

            // Gọi API lấy bản ghi hiện tại
            var getResponse = await _client.GetAsync($"HocKy/{id}");
            if (!getResponse.IsSuccessStatusCode)
            {
                return NotFound();
            }

            var json = await getResponse.Content.ReadAsStringAsync();
            hocKy = JsonSerializer.Deserialize<HocKy>(json, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            if (hocKy == null)
            {
                return NotFound();
            }

            // Đảo trạng thái (giả định thuộc tính là 'TrangThai' kiểu bool)
            hocKy.TrangThai = !hocKy.TrangThai;
            hocKy.NgayCapNhat = DateTime.Now; // nếu có thuộc tính này

            // Gửi PUT để cập nhật lại
            var putJson = JsonSerializer.Serialize(hocKy);
            var content = new StringContent(putJson, Encoding.UTF8, "application/json");

            var putResponse = await _client.PutAsync($"HocKy/{id}", content);
            if (!putResponse.IsSuccessStatusCode)
            {
                return BadRequest("Không thể cập nhật trạng thái.");
            }

            return RedirectToAction("Index");
        }
    }
}
