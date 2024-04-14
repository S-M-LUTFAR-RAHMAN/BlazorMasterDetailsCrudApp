using BlazorMasterDetailsCrudApp.Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace BlazorMasterDetailsCrudApp.Client.Services
{
    public class CategoryService
    {
        private readonly HttpClient http;

        public CategoryService(HttpClient http)
        {
            this.http = http;
        }



        public async Task<List<ProductCategory>?> GetCategoryList()
        {
            return await this.http.GetFromJsonAsync<List<ProductCategory>>("/ProductCategories");
        }
        public async Task<ProductCategory?> GetCategoryById(int id)
        {
            return await this.http.GetFromJsonAsync<ProductCategory>($"/ProductCategories/{id}");
        }


        public async Task<HttpResponseMessage> Save(ProductCategory data)
        {
            return await this.http.PostAsJsonAsync<ProductCategory>("/ProductCategories", data);
        }
        public async Task<HttpResponseMessage> Update(ProductCategory data)
        {
            return await this.http.PutAsJsonAsync<ProductCategory>($"/ProductCategories/{data.ProductCategoryID}", data);
        }
        public async Task<HttpResponseMessage> Delete(int id)
        {
            return await this.http.DeleteAsync($"/ProductCategories/{id}" );
        }
    }
}
