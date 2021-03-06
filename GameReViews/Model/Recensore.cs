﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameReViews.Model
{
    public class Recensore : UtenteRegistrato
    {

        public Recensore(string nome, string passowrd) : base(nome, passowrd)
        {

        }


        /*
         *Non manteniamo una lista (che dovrebbe essere consistente), ma lo calcoliamo dal modello 
         */
        public IEnumerable<Recensione> Recensioni
        {
            get
            {
                 // return from recensione in Model.GetInstance().Recensioni.RecensioniSet.Where(r => r.Autore.Equals(this))
                 //      //where recensione.Autore.Equals(this) //sarebbe così, però con le lambda si prendono più punti
                 //    select recensione;

                //solo con lambda, non c'è bisogno di usare linq in questo caso
                return Document.GetInstance().Videogiochi.Recensioni.Where(r => r.Autore.Equals(this));
            }
        }


        //In recensione c'è già il riferimento all'autore...

        //public void AddRecensione(Recensione recensione)
        //{
        //    #region Precondizioni
        //    if (recensione == null)
        //        throw new ArgumentNullException("recensione == null");
        //    if (!recensione.Autore.Equals(this))
        //        throw new ArgumentException("!recensione.Autore.Equals(this)");
        //    #endregion

        //    Model.GetInstance().Recensioni.AddRecensione(recensione);
        //}

         
    }
}
