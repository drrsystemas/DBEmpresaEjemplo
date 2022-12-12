namespace DRR.Core.DBEmpresaEjemplo.Enumerados
{
    public enum ProductoOferta_TipoOfertaId
    {
        Normal = 0, //productos marcados en oferta
        Promocion_por_cantidad = 1, // por comprar x cantidad se aplica la lista de prcios por ej: por mayor
        Acompaña_otro_producto_gratis = 2,//lleva dos paga 1
        Baucher = 3, //genera un baucher con un porcentaje, el mismo se usa en futuras compras
        Oferta_por_marca = 4, //genera un comprobante para participar en un sorteo.
        Aplica_porcentaje_bonificacion = 5
    }
}
