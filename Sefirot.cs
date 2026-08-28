class Sefirot
{
    private string? Nome;
    private string? Departamento;

    public Sefirot(string nome , string departamento)
    {
        this.nome == nome;
        this.departamento == departamento;
    }

    public void MostrarNome()
    {
        Console.WriteLine("Nome: " + nome);
    }

}
class Program
{
    static void Main()
    {
        // Criando o objeto e colocando um valor no atributo privado
        Sefirot sefirot1 = new Sefirot("Chesed");

        // Mostrando o valor
        sefirot1.MostrarNome();
    }
}
