using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Final_Poo_Beta
{
    internal class PecaComplex : Peca
    {
       // public double diamcabe;
       // public double passo;



        public PecaComplex(string nome, double altura, double diametro, string material, int codigo, double diametroInterno,  double diamcabe, double passo)
            : base(nome, altura, diametro, material, codigo, diametroInterno)
        {

            this.diamcabe = diamcabe;
            this.passo = passo;
            if (nome == "rosca mecanica" || nome == "Rosca mecanica")
            {

                DefineCab();
                DefineDiametroInterno();

            }
            if (nome == "parafuso" || nome == "Parafuso")
            {

                DefineDiametroInterno();

            }

            else if (nome == "engrenagem" || nome == "Engrenagem")
            {

                DefineCab();

            }
        }
        public override void DefineCab()
        {
            this.diamcabe = 0;

        }
        public override void DefineDiametroInterno()
        {
            this.diametroInterno = 0;
        }

        public override string ToString()
        {
            return "Codigo: " + Codigo.ToString() + "\n "
                            +
          "Peca:" + nome.ToString() + "\n  "
               +
          "Altura:  " + altura.ToString() + " mm\n  "
               +
          "Diametro:  " + diametro.ToString() + " mm\n  "
               +
          "Diametro Interno: " +diametroInterno.ToString() + " mm\n  "
              +
          "Diam.Cabeca:  " + diamcabe.ToString() + " mm\n  "
               +
          "Passo:  " + passo.ToString() + " mm\n  "
               +
         "Material:  " + material.ToString() + " \n  ";
        }
    }
}