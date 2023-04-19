class Program
{
    static void Main(string[] args)
    {
        MiniZoo miniZoo = new MiniZoo();
        miniZoo.AdicionarAnimal(new Mamifero("Leao", 5));
        miniZoo.AdicionarAnimal(new Reptil("Cobra", 2));

        miniZoo.EmitirSomDeTodosOsAnimais();
        miniZoo.ImprimirTodosOsAnimais();
    }
}
