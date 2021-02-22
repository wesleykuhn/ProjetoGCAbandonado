using GC.Library.Objects;

namespace GC.Library.Files
{
    internal static class Open
    {
        internal static void RequestPdf(Request request)
        {
            System.Diagnostics.Process.Start(Informations.Directories.PdfRequests + request.Number + ".pdf");
        }

        internal static void WarrantyPdf(Warranty warranty)
        {
            System.Diagnostics.Process.Start(Informations.Directories.PdfWarranties + warranty.Number + ".pdf");
        }
    }
}
