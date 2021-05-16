using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaCore.Excepciones
{
    public class BusinessExceptions:Exception
    {
        public BusinessExceptions() 
        {

        }
        public BusinessExceptions(string message): base(message)
        {

        }
    }
}
