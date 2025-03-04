using ClosedXML.Excel;
using TelephonyUI.Models.CallCenterModels;

namespace TelephonyUI.Services.Interfaces
{
	public interface IDataExportService
	{
		Task ExportToFormattedCsv(IEnumerable<Call> data);
		Task ExportToExcel(IEnumerable<Call> data);
		Task ExportToPDF(IEnumerable<Call> data, bool isLandscape);
	}
}
