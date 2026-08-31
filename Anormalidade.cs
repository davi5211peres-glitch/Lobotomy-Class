public class Anormalidade
{
    private string nomeA = "";
    private string nivelA = "";

    public string Nome
    {
        get { return nomeA; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("| O nome da anormalidade não pode ser vazio. |");

            nomeA = value;
        }
    }

    public string NivelA
    {
        get { return nivelA; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("| O nivel da anormalidade não pode ser vazio. |");

            nivelA = value;
        }
    }

    public Anormalidade(string nomeA, string nivelA)
    {
        Nome = nomeA;
        NivelA = nivelA;
    }

    public override string ToString()
    {
        return $"| Anormalidade: {Nome} | Nivel: {NivelA} |";
    }
}