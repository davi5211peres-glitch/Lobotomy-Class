public class Anormalidade
{
    private string nomeA = "";
    private string nivelA = "";

    public string NomeA
    {
        get { return nomeA; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("\n| O nome da anormalidade não pode ser vazio. |\n");

            nomeA = value;
        }
    }

    public string NivelA
    {
        get { return nivelA; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("\n| O nivel da anormalidade não pode ser vazio. |\n");

            nivelA = value;
        }
    }

    public Anormalidade(string nomeA, string nivelA)
    {
        NomeA = nomeA;
        NivelA = nivelA;
    }

    public override string ToString()
    {
        return $"| Anormalidade: {NomeA} | Nivel: {NivelA} |";
    }
}