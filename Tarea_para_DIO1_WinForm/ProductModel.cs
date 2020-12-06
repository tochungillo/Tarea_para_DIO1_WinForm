namespace Tarea_para_DIO1_WinForm
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string NombreModelo { get; set; }
        public string NombreProducto { get; set; }
        public string Description { get; set; }
        public int ProductionNumber { get; set; }
        public string Color { get; set; }
        public double ListPrice { get; set; }
        public double Size { get; set; }
        public string ProductLine { get; set; }
        public string Class { get; set; }
        public string Style { get; set; }
        public string Category { get; set; }
        public string SubCategory { get; set; }
        public override string ToString()
        {
            return $"{Id} - {NombreModelo} - {NombreProducto} - {Description} - {ProductionNumber} - {Color} - {ListPrice} - {Size} - {ProductLine} - {Class} - {Style} - {Category} - {SubCategory}";
        }
    }
}