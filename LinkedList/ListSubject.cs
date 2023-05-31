public class ListSubject {
    public NoSubject inicio;
    public NoSubject fim;

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
}