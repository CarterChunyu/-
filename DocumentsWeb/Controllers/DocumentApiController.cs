using DocumentsWeb.Interfaces;
using DocumentsWeb.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.StaticFiles;

namespace DocumentsWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocumentApiController : ControllerBase
    {
        private readonly IDocumentService _documentService;

        public DocumentApiController(IDocumentService documentService)
        {
            _documentService = documentService;
        }

        [HttpPost("SaveFile")]
        public FileContentResult SaveFile([FromBody] ConstructionFrameModel construction)
        {
            construction.guid = Guid.NewGuid();
            var bytes = _documentService.GetFileByte(construction);
            string? contentType = string.Empty;
            new FileExtensionContentTypeProvider().TryGetContentType($"{construction.Filename}.docx", out contentType);   
            return File(bytes, contentType, $"{construction.Filename}.docx");
        }
    }
}
