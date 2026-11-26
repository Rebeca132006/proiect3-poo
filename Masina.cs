using System;
using System.Runtime.CompilerServices;

namespace exercitiu3;

public class Masina
{
    private string producator;
    private int autonomie;
    public int AnProductie{get;private set;}
    public int Pret{get;set;}
    public string Producator
    {
        get{return producator;}
        set{producator=value;}
    }
    public int GetAutonomie()
    {
        return autonomie;
    }
    public void SetAutonime(int autonomie)
    {
        this.autonomie=autonomie;
    }
    public Masina(string producator,int Autonomie,int anProductie,int pret)
    {
        this.producator=producator;
        this.autonomie=Autonomie;
        this.AnProductie =anProductie;
        this.Pret=pret;

        
    }
    public override string ToString()
    {
        return $"Masina: {producator}-Autonomie:{autonomie},km{AnProductie}-pret:{Pret} euro ";
    }
}
