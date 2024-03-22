using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Domain.Core.Entity
{
    public class Feedback
    {
        public int Id { get; set; } // Primary key (usually auto-incremented)
        public string LecturerName { get; set; }
        public string ModuleName { get; set; }
        public string Department { get; set; }
        public string Semester { get; set; }
        public int LectureContentRating { get; set; }
        public int LectureEngagementRating { get; set; }
        public int CommunicationRating { get; set; }
        public int ExamplesRating { get; set; }
        public int CoverageRating { get; set; }
        public int PaceRating { get; set; }
        public int ParticipationRating { get; set; }
        public int VisualAidsRating { get; set; }
        public int RealWorldApplicationsRating { get; set; }
        public int ConceptRating { get; set; }
        public int LectureOrganizationRating { get; set; }
        public int InteractionRating { get; set; }
        public int ExplanationClarityRating { get; set; }
        public int SummaryEffectivenessRating { get; set; }
        public int RelevanceToCourseRating { get; set; }
        public string OverallFeedback { get; set; }
    }

}
