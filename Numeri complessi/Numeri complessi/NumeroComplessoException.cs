using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Numeri_complessi
{
    class NumeroComplessoException : Exception //eredita dalla classe generalizzata exception
    {
        public NumeroComplesso PrimoOperatore { get; set; }
        public NumeroComplesso SecondoOperatore { get; set; }


        public NumeroComplessoException(){


            }

        public NumeroComplessoException(string messaggio) : base(messaggio)
        {

        }

        public NumeroComplessoException(string messaggio, Exception innerException): base(messaggio, innerException)
        {

        }

        protected NumeroComplessoException(SerializationInfo info, StreamingContext context): base(info, context)
        {

        }

    }
}
