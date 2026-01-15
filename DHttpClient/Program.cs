// Questions: any issues with the HTTP client?

async Task<string> GetUserAsync(int id)
{
    using (var client = new HttpClient())
    {
        var response = await client.GetAsync($"https://api.example.com/users/{id}");
        return await response.Content.ReadAsStringAsync();
    }
}
