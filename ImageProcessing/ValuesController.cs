using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ImageProcessing
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public static IWebHostEnvironment _hostEnvironment;
        public ValuesController(IWebHostEnvironment hostEnvironment)
        {
            _hostEnvironment = hostEnvironment;
        }
        [HttpPost]
        public Task<JoinClass> Post([FromForm] Product pobjfile)
        {
            JoinClass joinClass = new JoinClass();
            
            //joinClass._CustomerList = new List<Customer>();
            joinClass._Product = new Product();

            try
            {
                joinClass._CustomerList = new List<Customer>()
                {
                    new Customer() {CustomerID = pobjfile.Prod_CustomerID, CustomerName = "tharmesh"},
                    new Customer() {CustomerID = pobjfile.Prod_CustomerID, CustomerName = "Sairam"}
                };

                joinClass._Product.ImageID = pobjfile.ImageID;
                joinClass._Product.ImageName = "\\Upload\\"+pobjfile.F_File.FileName;

                if(!Directory.Exists(_hostEnvironment.ContentRootPath+ "\\Upload\\"))
                {
                    Directory.CreateDirectory(_hostEnvironment.ContentRootPath + "\\Upload\\");
                }

                using 
                (
                    FileStream fs = System.IO.File.Create(_hostEnvironment.ContentRootPath + "\\Upload\\" + pobjfile.F_File.FileName))
                {
                    pobjfile.F_File.CopyTo(fs);
                    fs.Flush();
                }
            }
            catch (Exception ex) 
            {
                throw;
            }

            return Task.FromResult(joinClass);
        }
    }
}
