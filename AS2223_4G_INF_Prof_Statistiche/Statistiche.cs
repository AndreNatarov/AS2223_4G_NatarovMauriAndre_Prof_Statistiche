using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS2223_4G_INF_NatarovMauriAndre_Statistiche
{
    public class Statistiche
    {
        int SommaValoriSenzaPeso = 0;
        double SommaValoriConPeso = 0;
        double MoltiplicazioneValore = 0;
        int MediaPonderata = 0;
        int NumeroValori = 0;

        public Statistiche()
        {

        }

        /// <summary>
        /// Aggiungi un valore senza peso per le statistiche (media aritmetica)
        /// </summary>
        /// <param name="valore"></param>
        public void AddValue(int valore)
        { 
            
            do {
                SommaValoriSenzaPeso = SommaValoriSenzaPeso + valore;
            } while (valore != 0);
        }

        /// <summary>
        /// Aggiungi un valore con peso per le statistiche (media ponderata)
        /// </summary>
        /// <param name="valore"></param>
        /// <param name="peso"></param>
        public void AddValue(int valore, double peso)
        {
            
            do {
                MoltiplicazioneValore = valore * peso;
                double temp = MoltiplicazioneValore;
                SommaValoriConPeso = temp + MoltiplicazioneValore;
            } while (valore != 0 && peso != 0);
        }

        /// <summary>
        /// Ritorna la media aritmetica dei valori :
        ///     mediaAritmetica = sommaValori/numeroValori
        /// </summary>
        /// <returns></returns>
        public double MediaAritmetica()
        {
            double MediaAritmetica = SommaValoriSenzaPeso/NumeroValori;
        }

        /// <summary>
        /// Ritorna la media ponderata dei valori :
        ///     mediaPonderata = sommaValoriPerPeso/sommaPesi
        /// </summary>
        /// <returns></returns>
        public double MediaPonderata()
        {
            
        }

        /// <summary>
        /// Azzera i valori inseriti per la statistica
        /// </summary>
        public void ClearValue()
        {

        }

        /// <summary>
        /// Ritorna il numero di elementi inseriti per la statistica
        /// </summary>
        /// <returns></returns>
        public int CountValue()
        {
            do
            {
                NumeroValori++;
            } while (valore != 0);
        }

    }
}
