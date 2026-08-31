public class Sefirot
{
    private string nomeS = "";
    private string departamentoS = "";

    public string NomeS
    {
        get { return nomeS; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("| O nome do sefirot não pode ser vazio. |");

            nomeS = value;
        }
    }

    public string DepartamentoS
    {
        get { return departamentoS; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("| O departamento não pode ser vazio. |");

            departamentoS = value;
        }
    }

    public Sefirot(string nomeS, string departamentoS)
    {
        NomeS = nomeS;
        DepartamentoS = departamentoS;
    }

    public override string ToString()
    {
        return $"| Nome: {NomeS} | Departamento: {DepartamentoS} |";
    }
}