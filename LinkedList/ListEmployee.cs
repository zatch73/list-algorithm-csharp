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

    public Boolean consulta(string nome, ref NoEmployee noAtual, ref NoEmployee noAnterior){ 
        
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

    public void consultaNome(string nome, ListEmployee lista){
        NoEmployee? noAtual = null;
        NoEmployee? noAnterior = null;

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

    public void removerInicio(){
       if(this.inicio == null && this.fim == null){
        System.Console.WriteLine("an empty list");
       }else if(this.inicio != null){
            System.Console.WriteLine("Remove of start position: " + this.inicio.nome);
            this.inicio = this.inicio.noProx;

       }
    }

    public void removerFim(){
        NoEmployee noAux = this.inicio;
        if(this.inicio == null && this.fim == null){
            System.Console.WriteLine("an empty list");
        }else if(this.inicio != null){
            while(noAux != null){
                if(noAux.noProx == this.fim){
                    System.Console.WriteLine("Remove of end position: " + noAux.noProx.nome);
                    this.fim = noAux.noProx;
                    noAux.noProx = null;

                }
                noAux = noAux.noProx;            
            }
       }
    }

    public void impressao(){
        
        NoEmployee noAux = this.inicio;
        System.Console.Write("List");
        while(noAux != null){
            System.Console.WriteLine("\nNome: "+noAux.nome);
            System.Console.WriteLine("Idade: "+noAux.idade);
            System.Console.WriteLine("Telefone: "+noAux.telefone);
            System.Console.WriteLine("Salario: "+noAux.salario);
            noAux = noAux.noProx;            
        }
    }
}