public class Employee
{
    private string nomeE = "";
    private int idadeE;
    private string departamentoE = "";

    public string NomeE
    {
        get { return nomeE; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("O nome do funcionario não pode ser vazio.");

            nomeE = value;
        }
    }

    public int IdadeE
    {
        get { return idadeE; }
        set
        {
            if (value < 0 || value > 120)
                throw new ArgumentException("| Idade do funcionario inválida. |");

            idadeE = value;
        }
    }

    public string DepartamentoE
    {
        get { return departamentoE; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("| O departamento do funcionario não pode ser vazio. |");

            departamentoE = value;
        }
    }

    public Employee(string nomeE, int idadeE, string departamentoE)
    {
        NomeE = nomeE;
        IdadeE = idadeE;
        DepartamentoE = departamentoE;
    }

    public override string ToString()
    {
        return $"| Funcionario: {NomeE} | Idade: {IdadeE} | Departamento: {DepartamentoE} |";
    }
}