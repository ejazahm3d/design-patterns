using System;

namespace Behavioural.Template
{
    public class TransferForMoneyTask: Task
    {
        private readonly AuditTrail _auditTrail;

        public TransferForMoneyTask(AuditTrail auditTrail) : base(auditTrail)
        {
            _auditTrail = auditTrail;
        }

        protected override void DoExecute()
        {
            Console.WriteLine("Transferring money");
        }
    }
}