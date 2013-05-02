using System;
using OpenCBS.Enums;
using OpenCBS.Shared;

namespace OpenCBS.CoreDomain.Events.Saving
{
    [Serializable]
    public class SavingCreditInterBranchTransferEvent : SavingTransferEvent
    {
        public override string Code
        {
            get { return OSavingEvents.InterBranchCreditTransfer; }
        }

        public override OCurrency GetAmountForBalance()
        {
            return Amount;
        }

        public override string ExtraInfo
        {
            get
            {
                return string.Format("from {0}", RelatedContractCode);
            }
        }
    }
}