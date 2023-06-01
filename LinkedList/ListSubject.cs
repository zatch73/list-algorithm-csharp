using System.Text;
public class ListSubject {
    public NoSubject inicio;
    public NoSubject fim;

    private List<NoSubject> listaTemporaria;

    public ListSubject() {
        this.inicio = null;
        this.fim = null;
    }

    public void inserirInicio(string nome, int periodo, int cargaHoraria, string professor){
        NoSubject novoNo = new NoSubject(nome, periodo, cargaHoraria, professor);

        if(this.inicio == null && this.fim == null){
            this.inicio = novoNo;
            this.fim = novoNo;
            System.Console.WriteLine("Insert in start position: " + this.inicio.nome);
        }
        else if(this.inicio != null){
            novoNo.noProx = this.inicio;
            this.inicio = novoNo;
            System.Console.WriteLine("Insert in start position: " + this.inicio.nome);
        }
    }

    public void impressao(){
        
        NoSubject noAux = this.inicio;
        System.Console.Write("List");
        while(noAux != null){
            System.Console.WriteLine("\nNome: "+noAux.nome);
            System.Console.WriteLine("Período: "+noAux.periodo);
            System.Console.WriteLine("Carga Horaria: "+noAux.cargaHoraria);
            System.Console.WriteLine("Professor: "+noAux.professor);
            noAux = noAux.noProx;            
        }
    }

    public Boolean consulta(string nome, ref NoSubject noAtual, ref NoSubject noAnterior){ 
        
        noAtual = this.inicio;
        noAnterior = null;

        while(noAtual != null){
            if(noAtual.nome == nome){ //SE ENCONTROU O VALOR
                return(true);
            }
            noAnterior = noAtual;
            noAtual = noAtual.noProx;
        }
    
        return(false);
    }

    public void consultaNome(string nome, ListSubject lista){
        NoSubject? noAtual = null;
        NoSubject? noAnterior = null;

        Boolean encontrou = lista.consulta(nome, ref noAtual, ref noAnterior);
        if (encontrou)
        {
            Console.WriteLine("Encontrou o no de valor: " + noAtual.nome);
        }
        else
        {
            Console.WriteLine("Não encontrou o no procurado!");
        }
    }

    //a) Implemente a operação de inserção ordenada de um elemento por nome da disciplina

    public byte conversor(string letra){
       byte[] codigoANSI = Encoding.GetEncoding("ISO-8859-1").GetBytes(letra.ToString());
       return codigoANSI[0];
    }
    public void ordenacaoLista(){

       NoSubject noAtual = this.inicio;
       NoSubject noAnterior = null;

        while(noAtual != null){
            while(conversor(noAtual.nome) < (conversor(noAtual.noProx.nome))){
                System.Console.WriteLine(noAtual.nome);
                noAnterior = noAtual;
                noAtual = noAtual.noProx;
            }
            noAnterior = noAtual;
            noAtual = noAtual.noProx;
        }
    }
}