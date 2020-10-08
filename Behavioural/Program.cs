using System;
using Behavioural.Command.Editor;
using Behavioural.Observer;

namespace Behavioural
{
    class Program
    {
        static void Main(string[] args)
        {    
          var dataSource = new DataSource();
          var sheet1 = new SpreadSheet();
          var sheet2 = new SpreadSheet();
          var chart = new Chart();
          
          dataSource.AddObserver(sheet1);
          dataSource.AddObserver(sheet2);
          dataSource.AddObserver(chart);

          dataSource.Val = 2;
          
        }
    }
}