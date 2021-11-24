using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Week7_Paola_Mocci.Entities
{
    public class NotFoundException: Exception
    {
        public NotFoundException()
        {

        }
        public NotFoundException(string messaggio) : base(messaggio)
        {

        }

        public NotFoundException(string messaggio, Exception innerException) : base(messaggio, innerException)
        {

        }

        protected NotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {

        }


    }
}
