using Alat.models;
using System;

namespace Alat
{
    class Program
    {
        static void Main(string[] args)
        {
            Transaction toyinTransction = new Transaction("WEM120A", "Payment of school fees",
                "cash transafer", 23794.13m, 100322.92m);

            string status = toyinTransction.PerformTransaction();
            Console.WriteLine(status);
            Console.WriteLine($"Your balance after the transaction is { toyinTransction.GetTransactionBalance()}");
        }
    }
}
