public class NoSubject{
    public String nome;
    public int periodo;
    public int cargaHoraria;
    public String professor;
    public NoSubject noProx;

    public NoSubject(String nome, int periodo, int cargaHoraria, String professor){
        this.nome = nome;
        this.periodo = periodo;
        this.cargaHoraria = cargaHoraria;
        this.professor = professor;
        this.noProx = null;
    }
    
}