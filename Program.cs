namespace ListAlgorithm
{

    class Program
    {
        static void Main(string[] args)
        {

            Lista lista = new();
            lista.inserirInicio(22);
            lista.inserirInicio(12);
            lista.inserirInicio(7);
            lista.inserirFim(10);
            
            lista.percurso();

            lista.removerInicio();
            lista.removerFim();
            
            lista.percurso();
            // No? noAtual = null;
            // No? noAnterior = null;

            // Boolean encontrou = lista.consulta(10, ref noAtual, ref noAnterior);
            // if (encontrou)
            // {
            //     Console.WriteLine("Encontrou o no de valor: " + noAtual.valor);
            // }
            // else
            // {
            //     Console.WriteLine("Não encontrou o no procurado!");
            // }
        }
    }
}

