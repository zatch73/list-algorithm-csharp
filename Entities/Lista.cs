public class Lista{

    public No inicio;
    public No fim;

    public Lista(){
        this.inicio = null;
        this.fim = null;
    }

    public void inserirInicio(int value){
        No novoNo = new(value);

        if(this.inicio == null && this.fim == null){
            this.inicio = novoNo;
            this.fim = novoNo;
            System.Console.WriteLine("Insert in start position: " + this.inicio.valor);
        }
        else if(this.inicio != null){
            novoNo.noProx = this.inicio;
            this.inicio = novoNo;
            System.Console.WriteLine("Insert in start position: " + this.inicio.valor);
        }
    }

    public void inserirFim(int value){
        No no = new No(value);

        if(this.inicio == null && this.fim == null){
            this.inicio = no;
            this.fim = no;
            System.Console.WriteLine("Insert in end position: " + this.fim.valor);
        }else{
            this.fim.noProx = no;
            this.fim = no;
            System.Console.WriteLine("Insert in end position: " + this.fim.valor);

        }
    }

    public void removerInicio(){
       if(this.inicio == null && this.fim == null){
        System.Console.WriteLine("an empty list");
       }else if(this.inicio != null){
            System.Console.WriteLine("Remove of start position: " + this.inicio.valor);
            this.inicio = this.inicio.noProx;

       }
    }

    public void removerFim(){
        No noAux = this.inicio;
       if(this.inicio == null && this.fim == null){
        System.Console.WriteLine("an empty list");
       }else if(this.inicio != null){

            while(noAux != null){
                if(noAux.noProx == this.fim){
                    System.Console.WriteLine("Remove of end position: " + noAux.noProx.valor);
                    this.fim = noAux.noProx;
                    noAux.noProx = null;

                }
                noAux = noAux.noProx;            
            }
       }
    }

    public Boolean consulta(int Valor, ref No noAtual, ref No noAnterior){ 
        
        noAtual = this.inicio;
        noAnterior = null;

        while(noAtual != null){

            if(noAtual.valor == Valor){ //SE ENCONTROU O VALOR
                return(true);
            }
            noAnterior = noAtual;
            noAtual = noAtual.noProx;
        }
    
        return(false);
    }

    public void percurso(){
        
        No noAux = this.inicio;
        System.Console.Write("\n[ List: ");
        while(noAux != null){
            Console.Write(noAux.valor);
            if(noAux.noProx != null){
                Console.Write(" -> ");
            }
            noAux = noAux.noProx;            
        }
        System.Console.Write(" ]\n\n");
    }
}