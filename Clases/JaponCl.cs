using static System.Console;

public class Japon : Pais
{
    private string moneda;

    public Japon(string nombre, string capital, string moneda) : base(nombre, capital)
    {
        this.moneda = moneda;
    }

    public override string Descripcion()
    {
        return $"Japón es un país de Asia, cuya capital es {capital} y su moneda oficial es el {moneda}.";
    }
}