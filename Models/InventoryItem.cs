
namespace SelfDC.Models
{
    public class InventoryItem
    {
        public string productCode { get; set; }
        public string barcode { get; set; }
        public double qta { get; set; }

        public InventoryItem()
        {
            this.productCode = "";
            this.barcode = "";
            this.qta = 0;
        }

        public InventoryItem(string productCode, string barcode, double qta)
        {
            this.productCode = productCode;
            this.barcode = barcode;
            this.qta = qta;
        }

        public InventoryItem(string productCode, double qta)
        {
            this.productCode = productCode;
            this.barcode = "";
            this.qta = qta;
        }

        public InventoryItem(string productCode)
        {
            this.productCode = productCode;
            this.barcode = "";
            this.qta = 1;
        }

        public override string ToString()
        {
            return string.Format("{0,7} | {1,13} | {2,3}", this.productCode, this.barcode, this.qta);
        }
    }
}
