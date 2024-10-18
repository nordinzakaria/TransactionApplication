

using System;
using TransactionPackage;

class Program
{
    static void Main(string[] args)
    {
        Transaction transaction = new Transaction(10, DateTime.Now);
        transaction.Employee = new Employee("Ahmad", "54455");

        Console.WriteLine("Max # of transactions allowed = " + TransactionList.MAX);
        TransactionList transactionList = new TransactionList();
        transactionList.Add(transaction);

        Business business = new Business();
        business.initFirestore();

        var taskfb = Task.Run(async () => await business.SaveTransaction(transaction));
        taskfb.Wait(); // Blocks until the task completes

        Transaction transaction2 = new Transaction(500, DateTime.Now);
        transaction2.Employee = new Employee("Nava", "31158");

        taskfb = Task.Run(async () => await business.SaveTransaction(transaction));
        taskfb.Wait(); // Blocks until the task completes

        var task = Task.Run(async () => await business.RestoreTransactions());
        task.Wait(); // Blocks until the task completes

        business.TransList.Display();


    }
}