using System.Collections.Generic;
using TriggerfishTechnicalAssessment.Models;

namespace TriggerfishTechnicalAssessment.Repositories
{
    public class ArticleRepository
    {
        private readonly List<string> _titles = new List<string>()
        {
            "Why demand for in-store contactless payments is here to stay",
            "7 ways to increase ecommerce sales",
            "How technology empowers businesses to prepare for the future of commerce"
        };

        private readonly List<string> _descriptions = new List<string>()
        {
            "The demand for in-store contactless payment technology has increased over the past two years. " +
            "Learn more about this growing trend and how you can leverage it.",

            "Increase ecommerce sales with these 6 ideas to improve your customers' online payment experience.",

            "The future of commerce is ever changing. Learn how our future-forward commerce " +
            "technology keeps businesses at the forefront and removes complexity."
        };

        private readonly List<int> _readTime = new List<int>()
        {
            4, 6, 5
        };

        private readonly List<string> _imageFiles = new List<string>()
        {
            "Image1.PNG",
            "Image2.PNG",
            "Image3.PNG"
        };

        private const string _imageRootPath = "/images/";
        private const int _articleCount = 3;

        /// <summary>
        /// Get article details.
        /// </summary>
        /// <returns>List of <see cref="Article"/>s.</returns>
        public List<Article> GetArticles()
        {
            // Initialise an article list
            var articles = new List<Article>();
            for (int i = 0; i < _articleCount; i++)
            {
                // Populate article details
                var article = new Article()
                {
                    Title = _titles[i],
                    Description = _descriptions[i],
                    ReadTime = _readTime[i],
                    ImageUrl = $"{_imageRootPath}{_imageFiles[i]}"
                };

                // Add to the list
                articles.Add(article);
            }

            return articles;
        }
    }
}