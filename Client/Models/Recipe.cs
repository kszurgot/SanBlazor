namespace Client.Models
{
    public class Recipe
    {
        //public Recipe(int id, string name, List igredients, string thumbnail)

        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime PublishedAt { get; set; }

        public string OrgLink { get; set; }

        public string Image { get; set; }

        public string ThumbnailImage { get; set; }

        public List<Step> Steps { get; set; }

        public List<Ingredient> Ingredients { get; set; }
    }
}
