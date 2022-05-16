using System;

namespace CustomExceptions
{
    internal class MyExceptions
    {
        static void Main(string[] args)
        {
            try
            {
                //object obj = "aaa";
                //int variable = (int)obj;

                var numero = Ejemplo();
            }
            catch (OutOfMemoryException ex)
            {


            }
            catch (DivideByZeroException ex)
            {


            }
            catch (InvalidCastException ex)
            {


            }
            catch (Exception ex) // captura cualquier error
            {


            }
            finally
            {

            }


        }

        public static int Ejemplo()
        {
            try
            {
                object obj = "aaa";
                int variable = (int)obj;
            }
            catch (Exception ex) // captura cualquier error
            {
                // return 0;
                //Se lanza la excepcion
                throw new MyException();

            }
            finally
            {


            }

            return 1;

        }
    }
    }

