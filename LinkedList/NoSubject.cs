public class NoSubject{
    public String nome;
    public int periodo;
    public int cargaHoraria;
    public String Professor;
    public NoSubject proxNo;

    public NoSubject(String nome, int periodo, int cargaHoraria, String Professor){
        this.nome = nome;
        this.periodo = periodo;
        this.cargaHoraria = cargaHoraria;
        this.Professor = Professor;
        this.proxNo = null;
    }
    
}