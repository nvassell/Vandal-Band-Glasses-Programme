using System.Collections.Generic;

namespace BandGlassProgramme.Models
{
    public class DefaultLayoutModel
    {
        public List<string> participantNames { get; init; }
        public int numRows { get; init; }
        public int numColumns { get; init; }
        public string customLayoutDirectory { get; init; } = "./Custom_Layouts/";
    }
}
