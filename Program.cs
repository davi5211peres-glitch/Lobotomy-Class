class Program
{
    static void Main(string[] args)
    {

        Sefirot sefirot1 = new Sefirot("Chesed", "Extração");
        Sefirot sefirot2 = new Sefirot("Geburah", "Segurança");

        Employee funcionario1 = new Employee("João", 25, "Treinamento");
        Employee funcionario2 = new Employee("Carlos", 32, "Controle");

        Anormalidade anormalidade1 = new Anormalidade("Big Bird", "HE");
        Anormalidade anormalidade2 = new Anormalidade("Nothing There", "Aleph");


        sefirot2.DepartamentoS = "Disciplinar";
        sefirot1.NomeS = "Binah";

        funcionario1.IdadeE = 26;
        funcionario2.DepartamentoE = "Informação";

        anormalidade1.NivelA = "WAW";
        anormalidade2.NomeA = "Censored";

        Console.WriteLine("================================");
        Console.WriteLine("            SEFIROT");
        Console.WriteLine("================================");

        Console.WriteLine(sefirot1);
        Console.WriteLine(sefirot2);

        Console.WriteLine();
        Console.WriteLine("================================");
        Console.WriteLine("          FUNCIONÁRIOS");
        Console.WriteLine("================================");

        Console.WriteLine(funcionario1);
        Console.WriteLine(funcionario2);


        Console.WriteLine();
        Console.WriteLine("================================");
        Console.WriteLine("        ANORMALIDADES");
        Console.WriteLine("================================");

        Console.WriteLine(anormalidade1);
        Console.WriteLine(anormalidade2);

        Console.WriteLine();
    }
}