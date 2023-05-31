class NoEmployee{
    public String nome;
    public int idade;
    public String telefone;
    public double salario;
    public NoEmployee proxNo;

    public NoEmployee(String nome, int idade, String telefone, double salario) {
        this.nome = nome;
        this.idade = idade;
        this.telefone = telefone;
        this.salario = salario;
        proxNo = null;
    }

}