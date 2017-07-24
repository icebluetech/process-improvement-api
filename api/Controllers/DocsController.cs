using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using idata;
using model;
using System.IO;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using Microsoft.WindowsAzure.Storage.File;

namespace api.Controllers
{
    

    [Produces("application/json")]
    [Route("api/[controller]")]
    public class DocsController : Controller
    {
        private readonly IDocsRepository _docsRepository;

        public DocsController(IDocsRepository docsRepository)
        {
            _docsRepository = docsRepository;
        }
        // GET: api/Docs
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Docs/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
        
        // POST: api/Docs
        [HttpPost]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> Post()
        {
            var files = Request.Form.Files;

            CloudStorageAccount storageAccount = new CloudStorageAccount(new Microsoft.WindowsAzure.Storage.Auth.StorageCredentials("processimprovement", "kVatBtO1SKg9Sp4y8v1PzpY7J4F9yJSodKNFq+lg8ZDj63w+RTdlTgYYzLS2ot7LRfrtwhRhNGPkOL+n77tbAg=="), true);
            CloudFileClient fileClient = storageAccount.CreateCloudFileClient();
            CloudFileShare share = fileClient.GetShareReference("uploads");

            foreach (var file in files)
            {
                if (file.Length > 0)
                {
                    CloudFileDirectory rootDir = share.GetRootDirectoryReference();
                    //CloudFileDirectory innoDir = rootDir.GetDirectoryReference();
                    CloudFile cloudFile = rootDir.GetFileReference(file.FileName);

                    using (var fileStream = file.OpenReadStream())
                    {
                        await cloudFile.UploadFromStreamAsync(fileStream);
                    }
                }

                _docsRepository.Save(new Doc { Name = file.FileName, InnovationId = int.Parse(file.Name) });
            }

            
            return Ok();
        }

        //PUT: api/Docs/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
