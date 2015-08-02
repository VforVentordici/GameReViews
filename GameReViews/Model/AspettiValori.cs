﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameReViews.Model
{


    /* Classe che fattorizza la interazione tra Preferenze (degli UtentiRegistrati) e AspettiValutati (nelle Recensioni)
     * con la classe che mantiene gli Aspetti correntemente utilizzati nel sistema.
     * Questa classe implementa le azioni di rimozione e modifica della valutazione,
     * lasciando astratta la aggiunta.
     */
    public abstract class AspettiValori
    {
        // vedi requisiti non funzionali del progetto
        private readonly static int valoreMinimo = 0;
        private readonly static int valoreMassimo = 10;

        protected Dictionary<Aspetto, int> _aspettiValori;
        protected static readonly Dictionary<Aspetto, int> _emptyAspettiValori = new Dictionary<Aspetto, int>();

        public AspettiValori()
        {
            _aspettiValori = _emptyAspettiValori;
        }

        public abstract void Add(Aspetto aspetto, int value);

        public IEnumerable<KeyValuePair<Aspetto, int>> AspettiValutati
        {
            get
            {
                return _aspettiValori;
            }
        }

        public IEnumerable<KeyValuePair<string, int>> NomiAspettiValori
        {
            get
            {
                return from aspettoValore in _aspettiValori select new KeyValuePair<string, int>(aspettoValore.Key.Nome, aspettoValore.Value);
            }
        }

        public void Remove(Aspetto aspetto)
        {
            #region Precondizioni
            if (aspetto == null)
                throw new ArgumentNullException("aspetto == null");
            #endregion

            if (this._aspettiValori == _emptyAspettiValori)
                return;

            if (this._aspettiValori.ContainsKey(aspetto))
            {
                this._aspettiValori.Remove(aspetto);

                // aggiorna il reference counter degli aspetti
                Document.GetInstance().Aspetti.Remove(aspetto);
            }
        }

        public void ModificaValutazione(Aspetto aspetto, int valutazione)
        {
            #region Precondizioni
            if (aspetto == null)
                throw new ArgumentNullException("aspetto == null");
            if(!AspettiValori.IsValueValid(valutazione))
                throw new ArgumentException("!AspettiValori.IsValueValid(value)");
            #endregion

            if (this._aspettiValori == _emptyAspettiValori)
                return;

            if (this._aspettiValori.ContainsKey(aspetto))
                this._aspettiValori[aspetto] = valutazione;
        }

        public static int ValoreMinimo
        {
            get { return AspettiValori.valoreMinimo; }
        }

        public static int ValoreMassimo
        {
            get { return AspettiValori.valoreMassimo; }
        }

        public static Boolean IsValueValid(int value)
        {
            bool res = false;

            if (value >= ValoreMinimo && value <= ValoreMassimo)
                res = true;

            return res;
        }
    }
}
