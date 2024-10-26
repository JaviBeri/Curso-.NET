namespace Proyecto_Tienda.Models;

// Guarda el historial de conversiones entre monedas

public class HistoricoConversiones
{
    public int Id { get; set; }
    public int MonedaOrigenId { get; set; }
    public int MonedaDestinoId { get; set; }
    public decimal TasaConversion { get; set; }
    // Cantidad convertida
    public decimal Cantidad { get; set; }
    // Resultado de la conversión
    public decimal Resultado { get; set; }
    public DateTime Fecha { get; set; }
}