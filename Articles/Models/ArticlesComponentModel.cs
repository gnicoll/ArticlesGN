using System;
using System.Collections.Generic;
namespace Articles.Models
{
    public class ArticlesComponentModel
    {
        public ArticlesComponentModel()
        {
            Articles = new List<ArticleModel>();
            Success = true;
            Error = null;
        }

        public IEnumerable<ArticleModel> Articles { get; set; }

        public bool Success { get; set; }

        public string Error { get; set; }
    }
}
