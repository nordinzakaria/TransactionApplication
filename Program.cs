

using System;
using TransactionPackage;

class Program
{
    static void Main(string[] args)
    {
        Transaction transaction = new Transaction();
        transaction.setVal(1);
        transaction.setDate(DateTime.Now);

        TransactionList transactionList = new TransactionList();
        transactionList.Add(transaction);

    }
}