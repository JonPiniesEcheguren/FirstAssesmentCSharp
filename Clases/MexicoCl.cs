using static System.Console;

public class Mexico : Pais
{
    private string idioma;

    public Mexico(string nombre, string capital, string idioma) : base(nombre, capital)
    {
        this.idioma = idioma;
    }

    public override string Descripcion()
    {
        return $"México es un país de América del Norte, cuya capital es {capital} y su idioma oficial es el {idioma}.";
    }
}