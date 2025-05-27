using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Text;
using API.Data;

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

            var response = await _client.PostAsync("", content);
            if (response.IsSuccessStatusCode)
                return RedirectToAction("Index");

            return View(model);
        }

        public async Task<IActionResult> Edit(Guid id)
        {
            var response = await _client.GetAsync(id.ToString());
            var json = await response.Content.ReadAsStringAsync();
            var hocKy = JsonSerializer.Deserialize<HocKy>(json, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            return View(hocKy);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Guid id, HocKy model)
        {
            var json = JsonSerializer.Serialize(model);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _client.PutAsync(id.ToString(), content);
            if (response.IsSuccessStatusCode)
                return RedirectToAction("Index");

            return View(model);
        }

        public async Task<IActionResult> ChangeStatus(Guid id)
        {
            var response = await _client.PutAsync($"TrangThai/{id}", null);
            return RedirectToAction("Index");
        }
    }
}
