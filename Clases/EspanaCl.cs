using static System.Console;

public class Espana : Pais
{
    private string region;

    public Espana(string nombre, string capital, string region) : base(nombre, capital)
    {
        this.region = region;
    }

    public override string Descripcion()
    {
        return $"España es un país de Europa, cuya capital es {capital} y se encuentra en la región de {region}.";
    }
}