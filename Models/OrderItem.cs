
namespace SelfDC.Models
{
    public class OrderItem
    {
        public string productCode { get; set; }
        public string barcode { get; set; }
        public int qta { get; set; }

        public OrderItem(string productCode, string barcode, int qta)
        {
            this.productCode = productCode;
            this.barcode = barcode;
            this.qta = qta;
        }

        public OrderItem(string productCode, int qta)
        {
            this.productCode = productCode;
            this.barcode = "";
            this.qta = qta;
        }

        public OrderItem(string productCode)
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
