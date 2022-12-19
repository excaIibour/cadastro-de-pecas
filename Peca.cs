using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Peca : Seguranca
{
    /*
    public string nome = ""; // { get; private set; }
    public double altura = 0;
    public double diametro = 0;
    public double diametroInterno = 0;
    public string material = "";
    */
    public string nome { get; set; } // { get; private set; }
    public double altura { get; set; }
    public double diametro { get; set; }
    public double diametroInterno { get; set; }
    public string material { get; set; }
    //----------------------------------
    public double diamcabe;
    public double passo;
    //----------------------------------
    public int Codigo { get; set; }

    public virtual void DefineCab ()
    {
        
       
    }
    public virtual void DefineDiametroInterno()
    {

    }

    public Peca(string nome, double altura, double diametro, string material, int codigo, double diametroInterno)
    {
        this.nome = nome;
        this.altura = altura;
        this.diametro = diametro;
        this.material = material;
        Codigo = codigo;
        this.diametroInterno = diametroInterno;
    }
    public string Nome(string a)
    {
        return nome;
    }

    
    public string Nomes()
    {
        return nome + "\n";
    }
    //
    
    //
    
   public override string  ToString()
    {

        return "Codigo: " + Codigo.ToString() + "\n "
                         +
       "Peca:" + nome.ToString() + "\n  "
            +
       "Altura:  " + altura.ToString() + " mm\n  "
            +
       "Diametro:  " + diametro.ToString() + " mm\n  "
       +
       "Diametro Interno: " + diametroInterno.ToString() + " mm\n  "
        +
      "Material:  " + material.ToString() + " \n  ";
                  
     
            
        //"Codigo: " codigo.ToString()

    }

}


