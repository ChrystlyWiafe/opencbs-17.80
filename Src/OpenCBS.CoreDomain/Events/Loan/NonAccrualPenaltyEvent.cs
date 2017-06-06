﻿using OpenCBS.Shared;

namespace OpenCBS.CoreDomain.Events.Loan
{
    public class NonAccrualPenaltyEvent : Event
    {
        public override string Code
        {
            get { return "NAPE"; }
            set { _code = value; }
        }
        public override string Description { get; set; }
        public OCurrency Penalty { get; set; }

        public override Event Copy()
        {
            return (NonAccrualPenaltyEvent)MemberwiseClone();
        }
    }
}