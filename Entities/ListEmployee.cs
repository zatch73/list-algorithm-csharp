class ListEmployee{
    public NoEmployee inicio;
    public NoEmployee fim;

    public ListEmployee() {
        this.inicio = null;
        this.fim = null;
    }

        public void inserirInicio(string nome, int idade, string telefone, double salario){
        NoEmployee novoNo = new NoEmployee(nome, idade, telefone, salario);

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

    public void inserirFim(string nome, int idade, string telefone, double salario){
        NoEmployee no = new NoEmployee(nome, idade, telefone, salario);

        if(this.inicio == null && this.fim == null){
            this.inicio = no;
            this.fim = no;
            System.Console.WriteLine("Insert in end position: " + this.fim.nome);
        }else{
            this.fim.noProx = no;
            this.fim = no;
            System.Console.WriteLine("Insert in end position: " + this.fim.nome);

        }
    }

    public void percurso(){
        
        NoEmployee noAux = this.inicio;
        System.Console.Write("\n[ List: ");
        while(noAux != null){
            Console.Write(noAux.nome);
            if(noAux.noProx != null){
                Console.Write(" -> ");
            }
            noAux = noAux.noProx;            
        }
        System.Console.Write(" ]\n\n");
    }


}