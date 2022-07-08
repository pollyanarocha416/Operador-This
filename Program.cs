class Calculos{
    public int v1;
    public int v2;
    public Calculos(int v1, int v2){
    //(o v1 e v2 q ta fora) e o v1 e v2 q ta dentro
        this.v1 = v1;
        this.v2 = v2;
    }
    
    public int Somar(){
        return v1 + v2;
    }
}

class Program{
    static void Main(){
        Calculos c = new Calculos(10, 2);
        Console.WriteLine(c.Somar());
    }
}
