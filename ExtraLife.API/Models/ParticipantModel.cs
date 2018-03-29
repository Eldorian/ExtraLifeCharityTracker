using System;

namespace ExtraLife.API.Models
{
    public class ParticipantModel
    {
        public string DisplayName { get; set; }
        public decimal TotalRaisedAmount { get; set; }
        public decimal FundraisingGoal { get; set; }
        public int ParticipantId { get; set; }
        public DateTime CreatedOn { get; set; }
        public string AvatarUrl { get; set; }
        public int TeamId { get; set; }
        public bool IsTeamCaptain { get; set; }

    }
}
