using System;
using System.Collections.Generic;
using System.Text;

namespace Numeri_complessi
{
    class NumeroComplesso
    {
        //a+ib

        public double ParteReale { get; set; }
        public double ParteImmaginaria { get; set; }

        public NumeroComplesso Divisione(NumeroComplesso value)
        {
            double denom = Math.Pow(value.ParteReale, 2) + Math.Pow(value.ParteImmaginaria, 2);

            if (denom == 0)
            {
                //Eccezione personalizzata

                throw new NumeroComplessoException("Non è possibile realizzare questa divisione perché il divisore è uguale a zero.")
                {
                    PrimoOperatore = this,
                    SecondoOperatore = value
                };
            }

            double parteRealeRisultato = (((this.ParteReale * value.ParteReale) + (this.ParteImmaginaria * value.ParteImmaginaria)) / denom);
            double parteImmaginariaRisultato = (((this.ParteImmaginaria * value.ParteReale) - (this.ParteReale * value.ParteImmaginaria)) / denom);

            return new NumeroComplesso
            {
                ParteReale = parteRealeRisultato,
                ParteImmaginaria = parteImmaginariaRisultato,
            };

        }

        public override string ToString()
        {
            if (ParteImmaginaria < 0)
            {
                return $"{ParteReale} - {Math.Abs(ParteImmaginaria)}i";
            }
            else
            {
                return $"{ParteReale} + {ParteImmaginaria}i";
            }


        }
    }


}
