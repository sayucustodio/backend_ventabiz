namespace appsales.Request
{
   public class CreateProductRequest
{
    public int codempresa { get; set; }
    public string codigo_sku { get; set; }
    public string nombre { get; set; }

    public string? descripcion { get; set; }
    public string? codigo_barra { get; set; }
    public long? categoria_id { get; set; }
    public decimal? precio_compra { get; set; }
    public decimal? precio_venta { get; set; }
    public decimal? stock_actual { get; set; }
    public decimal? stock_minimo { get; set; }
    public string? unidad_medida { get; set; }
    public string? imagen_url { get; set; }
    public bool? estado { get; set; }
}

}
