using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Articles.Interfaces;
using Articles.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace Articles.Services
{
    public class ArticlesService : IArticlesService
    {
        private string jsonFilePath = "./Data/articles.json";
        public Task<ArticlesComponentModel> GetArticles()
        {
            ArticlesComponentModel articles = new ArticlesComponentModel();

            try
            {
                using (StreamReader sr = File.OpenText(jsonFilePath))
                {
                    articles.Articles = JsonConvert.DeserializeObject<List<ArticleModel>>(sr.ReadToEnd());
                    articles.Success = true;
                }
            }
            catch (Exception ex)
            {
                articles.Success = false;
                articles.Error = ex.Message;
            }

            return Task.FromResult(articles);
        }

    }
}


