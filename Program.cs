namespace list_algorithm_csharp
{

    class Program
    {
        static void Main(string[] args)
        {
            // saída do exercício 1
            Lista lista = new();
            lista.inserirInicio(22);
            lista.inserirInicio(12);
            lista.inserirInicio(7);
            lista.inserirFim(10);
            
            lista.percurso();

            lista.removerInicio();
            lista.removerFim();
            
            lista.percurso();
            // fim do exercício 1
            System.Console.WriteLine("--------------------------------");
            System.Console.WriteLine("--------------------------------");
            System.Console.WriteLine("--------------------------------");
            // saída do exercício 2

            ListEmployee lista2 = new ListEmployee();
            lista2.inserirInicio("Luffy", 19, "(18) 123123123", 2300.0);
            lista2.inserirInicio("Takamura", 19, "(18) 123123123", 2300.0);
            lista2.inserirInicio("Ippo", 19, "(18) 123123123", 2300.0);
            lista2.inserirFim("Ichigo", 19, "(18) 123123123", 2300.0);
            lista2.inserirFim("Zoro", 19, "(21) 321321312", 2300.0);

            lista2.percurso();
            lista2.consultaNome("Zoro", lista2);

            lista2.removerFim();
            lista2.removerInicio();
            lista2.percurso();

            lista2.impressao();
            // fim do exercício 2
            System.Console.WriteLine("--------------------------------");
            System.Console.WriteLine("--------------------------------");
            System.Console.WriteLine("--------------------------------");
            // saída do exercício 3

            ListSubject lista3 = new ListSubject();

            lista3.inserirInicio("Matematica", 6, 200, "Jorge Campos");
            lista3.inserirInicio("Portugues", 6, 200, "Jorge Campos");
            lista3.inserirInicio("Ingles", 6, 200, "Jorge Campos");
            lista3.inserirInicio("Geografia", 6, 200, "Jorge Campos");
            lista3.inserirInicio("Historia", 6, 200, "Jorge Campos");
            lista3.impressao();

            // fim do exercício 3
            


        }
    }
}

