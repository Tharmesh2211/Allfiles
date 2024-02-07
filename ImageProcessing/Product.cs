namespace ImageProcessing
{
    public class Product
    {
        public int ImageID {  get; set; }
        public string ImageName { get; set; }
        public string ProdName {  get; set; }
        public string ProdModel { get; set; }
        public int Prod_CustomerID { get; set; }
        public IFormFile F_File { get; set; }

    }
}
