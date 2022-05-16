using System;

namespace CustomExceptions
{
    internal class MyException : ApplicationException
    {

        public MyException() : base("Esta es mi custom exception") 
        {
        
        
        
        }
       
    }
}
