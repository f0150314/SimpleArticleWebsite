namespace TriggerfishTechnicalAssessment.Models
{
    /// <summary>
    /// A container to <see cref="Article"/> details.
    /// </summary>
    public class Article
    {
        public string ImageUrl { get; set; }
        public int ReadTime { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
