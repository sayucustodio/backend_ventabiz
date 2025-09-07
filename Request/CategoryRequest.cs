namespace appsales.Request
{
    public class CategoryRequest
    {
    }
    public class CreateCategoryRequest
    {
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public int codempresa { get; set; }
    }

    public class UpdateCategoryRequest
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public bool estado { get; set; }
        public int codempresa { get; set; }
    }
}
