using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Articles.Models;
using Microsoft.AspNetCore.Mvc;

namespace Articles.Interfaces
{
    public interface IArticlesService
    {
        public Task<ArticlesComponentModel> GetArticles();
    }
}
