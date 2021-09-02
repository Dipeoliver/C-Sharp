using Herança.Entities;
using System;

namespace Herança
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1001, "Diego", 0.00);
            BussinessAccount bacc = new BussinessAccount(1002, "Claudia", 0.00, 500.00);

            //UPCASTING -> conversão de uma sub classe para classe (DIRETO)
            Account acc1 = bacc;
            Account acc2 = new BussinessAccount(1003, "Mario", 0.00, 500.00);
            Account acc3 = new SavingsAccount(1004, "Jose", 0.00, 0.001);




            // DOWNCASTING -> conversão de uma classe para sub classe (NÂO É DIERETO) usar casting
            BussinessAccount bacc1 = (BussinessAccount)acc2;
            // outro metodo de fazer casting
            Account bacc2 = acc2 as BussinessAccount;



            // exemplo abaixo da erro porque a o acc3 e uma classe SavingAccount
            //BussinessAccount bacc2 = (BussinessAccount)acc3;

            // Veriifcar antes de fazer uma conversão
            if (acc3 is BussinessAccount)
            {
                BussinessAccount bacc3 = (BussinessAccount)acc3;
            }



        }
    }
}
