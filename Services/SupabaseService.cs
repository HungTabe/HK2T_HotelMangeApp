using System.Net.Http;
using System.Threading.Tasks;
using HK2TProject_HotelManage_Server.Models;
using Newtonsoft.Json;
using Supabase.Gotrue;

public class SupabaseService
{
    private readonly HttpClient _httpClient;
    private readonly string _supabaseUrl = "https://ayumhpefkklgjyfuiytf.supabase.co"; // Thay thế bằng URL của dự án Supabase của bạn
    private readonly string _apiKey = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6ImF5dW1ocGVma2tsZ2p5ZnVpeXRmIiwicm9sZSI6ImFub24iLCJpYXQiOjE3MTE5Mzk3NzIsImV4cCI6MjAyNzUxNTc3Mn0.9uFV7Zz8S9wl-_No6y3qGcjbmpRQDiWx0SS1RVW0cac"; // Thay thế bằng khóa API của bạn

    public SupabaseService(HttpClient httpClient)
    {
        _httpClient = httpClient;
        _httpClient.DefaultRequestHeaders.Add("apikey", _apiKey);
        _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {_apiKey}");
    }

    // Ví dụ: Lấy dữ liệu từ table
    public async Task<string> GetData()
    {
        var response = await _httpClient.GetAsync($"{_supabaseUrl}/rest/v1/Demo");
        response.EnsureSuccessStatusCode();
        var content = await response.Content.ReadAsStringAsync();
        return content;
    }

    public async Task<List<Users>> GetUsers()
    {
        var response = await _httpClient.GetAsync($"{_supabaseUrl}/rest/v1/users?select=*");
        response.EnsureSuccessStatusCode();
        var content = await response.Content.ReadAsStringAsync();
        var users = JsonConvert.DeserializeObject<List<Users>>(content);
        return users ?? new List<Users>();
    }
}
