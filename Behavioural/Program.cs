using System;
using Behavioural.Iterator;
using Behavioural.Memento;
using Behavioural.State;
using Behavioural.Strategy;
using Behavioural.Template;
using static System.Console;

namespace Behavioural
{
    class Program
    {
        static void Main(string[] args)
        {
          var transferMoney = new TransferForMoneyTask(new AuditTrail());
          transferMoney.Execute();
        }
    }
}