using DocumentsWeb.Models;

namespace DocumentsWeb.Interfaces
{
    public interface IDocumentService
    {
        byte[] GetFileByte(ConstructionFrameModel construction);
    }
}
