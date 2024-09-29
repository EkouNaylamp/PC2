using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace PC2.Models;

public class CuentaBancaria
{
    public int Id { get; set; }
    public string? NombreTitular { get; set; }
    public string? TipoCuenta { get; set; }
    public decimal SaldoInicial { get; set; }
    public string? Email { get; set; }
}