

using System;
using TransactionPackage;

class Program
{
    static void Main(string[] args)
    {
        Transaction transaction = new Transaction();
        transaction.Val = 1;
        transaction.Date = DateTime.Now;
        transaction.Employee = new Employee();

        TransactionList transactionList = new TransactionList();
        transactionList.Add(transaction);

        Business business = new Business();
        business.initFirestore();

    }
}