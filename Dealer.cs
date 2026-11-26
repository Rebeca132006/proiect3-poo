using System;

namespace exercitiu3;

public class Dealer
{
    private List<Masina> masini;
    public Dealer()
    {
        masini=new List<Masina>();
    }
    public void AdaugaMasina(Masina masina)
    {
        if(masina!=null)
        {
            masini.Add(masina);
        }
    }
    public void AfiseazaMasiniCuDiscount(int discount)
    {
        foreach(var masina in masini)
        {
            int pretFinal=masina.Pret - (masina.Pret *discount/100);
            Console.WriteLine($"Masina:{masina.Producator}-Autonomie:{masina.GetAutonomie}km {masina.AnProductie}-Pret cu discount:{pretFinal}euro ");
        }
    }
}
