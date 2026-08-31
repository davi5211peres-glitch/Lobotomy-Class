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
                throw new ArgumentException("\n| O nome do funcionario não pode ser vazio. |\n");

            nomeE = value;
        }
    }

    public int IdadeE
    {
        get { return idadeE; }
        set
        {
            if (value <= 0 || value > 120)
                throw new ArgumentException("\n| Idade do funcionario não pode ser maior que 120 ou menor que 0. |\n");

            idadeE = value;
        }
    }

    public string DepartamentoE
    {
        get { return departamentoE; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("\n| O departamento do funcionario não pode ser vazio. |\n");

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