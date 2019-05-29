using System.Windows.Forms;

namespace stokTakip
{
    internal class DataGridPrinter : DataGridView
    {
        private object dataGrid1;
        private object printDocument1;
        private object customers;

        public DataGridPrinter(object dataGrid1, object printDocument1, object customers)
        {
            this.dataGrid1 = dataGrid1;
            this.printDocument1 = printDocument1;
            this.customers = customers;
        }
    }
}