using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using API.Data;
using Newtonsoft.Json;
using System.Text;

namespace Nhom10ModuleDiemDanh.Controllers
{
    public class BanDaoTaosController : Controller
    {
        private readonly string apiUrl = "https://localhost:7296/api/BanDaoTao";


        public BanDaoTaosController()
        {

        }

        // GET: BanDaoTaos
        public async Task<IActionResult> Index()
        {
            List<BanDaoTao> data = new List<BanDaoTao>();
            using (HttpClient client = new HttpClient())
            {
                using (var reponse = await client.GetAsync(apiUrl))
                {
                    if (reponse.IsSuccessStatusCode)
                    {
                        string api = await reponse.Content.ReadAsStringAsync();
                        data = JsonConvert.DeserializeObject<List<BanDaoTao>>(api);
                    }
                }

            }
            return View(data);

        }

        // GET: BanDaoTaos/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            BanDaoTao banDaoTao = new BanDaoTao();
            using (HttpClient client = new HttpClient())
            {
                using (var reponse = await client.GetAsync($"{apiUrl}/{id}"))
                {
                    if (reponse.IsSuccessStatusCode)
                    {
                        string api = await reponse.Content.ReadAsStringAsync();
                        banDaoTao = JsonConvert.DeserializeObject<BanDaoTao>(api);
                    }
                    else
                    {
                        return NotFound();
                    }
                }

            }
            return View(banDaoTao);

        }

        // GET: BanDaoTaos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BanDaoTaos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdBanDaoTao,TenBanDaoTao,MaBanDaoTao,Email,IdVaiTro,NgayTao,NgayCapNhat,TrangThai")] BanDaoTao banDaoTao)
        {
            if (!ModelState.IsValid)
            {
                return View(banDaoTao);
            }
            using (var httpclient = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(banDaoTao), Encoding.UTF8, "application/json");
                using (var response = await httpclient.PostAsync(apiUrl, content))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        return RedirectToAction(nameof(Index));
                    }

                }
            }
            return View(banDaoTao);
        }

        // GET: BanDaoTaos/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            BanDaoTao banDaoTao = new BanDaoTao();
            using (var httpclient = new HttpClient())
            {
                using (var response = await httpclient.GetAsync($"{apiUrl}/{id}"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string api = await response.Content.ReadAsStringAsync();
                        banDaoTao = JsonConvert.DeserializeObject<BanDaoTao>(api);
                    }
                    else
                    {
                        return NotFound();
                    }
                }
            }
            return View(banDaoTao);
        }

        // POST: BanDaoTaos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("IdBanDaoTao,TenBanDaoTao,MaBanDaoTao,Email,IdVaiTro,NgayTao,NgayCapNhat,TrangThai")] BanDaoTao banDaoTao)
        {
            if (id != banDaoTao.IdBanDaoTao)
            {
                return NotFound();
            }
            if (!ModelState.IsValid)
            {
                return View(banDaoTao);
            }
            using (var httpclient = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(banDaoTao), Encoding.UTF8, "application/json");
                using (var response = await httpclient.PostAsync($"{apiUrl}/{id}", content))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        return RedirectToAction(nameof(Index));
                    }

                }
            }
            return View(banDaoTao);
        }

        // GET: BanDaoTaos/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            BanDaoTao banDaoTao = new BanDaoTao();
            using (var httpclient = new HttpClient())
            {
                using (var response = await httpclient.GetAsync($"{apiUrl}/{id}"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string api = await response.Content.ReadAsStringAsync();
                        banDaoTao = JsonConvert.DeserializeObject<BanDaoTao>(api);
                    }
                    else
                    {
                        return NotFound();
                    }
                }
            }
            return View(banDaoTao);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            using (var httpclient = new HttpClient())
            {
                using (var response = await httpclient.DeleteAsync($"{apiUrl}/{id}"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        return RedirectToAction(nameof(Index));
                    }
                }
            }
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task<IActionResult> ToggleStatus(Guid id)
        {
            // Gọi API lấy bản ghi hiện tại
            BanDaoTao banDaoTao = null;
            using (var httpClient = new HttpClient())
            {
                var res = await httpClient.GetAsync($"{apiUrl}/{id}");
                if (res.IsSuccessStatusCode)
                {
                    string json = await res.Content.ReadAsStringAsync();
                    banDaoTao = JsonConvert.DeserializeObject<BanDaoTao>(json);
                }
                else return NotFound();
            }

            // Đảo trạng thái
            banDaoTao.TrangThai = !banDaoTao.TrangThai;
            banDaoTao.NgayCapNhat = DateTime.Now;

            // Gửi PUT lại API
            using (var httpClient = new HttpClient())
            {
                var json = JsonConvert.SerializeObject(banDaoTao);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await httpClient.PutAsync($"{apiUrl}/{id}", content);
                if (!response.IsSuccessStatusCode)
                {
                    return BadRequest();
                }
            }

            return RedirectToAction("Index");
        }

    }
}
