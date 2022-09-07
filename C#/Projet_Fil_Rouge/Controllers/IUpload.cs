namespace APIAspNetCore.Controllers
{
    internal interface IUpload
    {
        public string Upload(IFormFile file);
    }
}