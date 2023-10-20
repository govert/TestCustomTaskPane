using ExcelDna.Integration;

namespace TestCustomTaskPane
{
    public class AddIn : IExcelAddIn
    {
        public void AutoOpen()
        {
            System.Windows.Forms.Application.EnableVisualStyles();
        }

        public void AutoClose()
        {
        }

    }
}
