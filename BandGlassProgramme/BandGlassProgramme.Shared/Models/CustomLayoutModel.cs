using System.Collections.Generic;

namespace BandGlassProgramme.Models
{
    public class CustomLayoutModel
    {
        public List<LayoutDetail> layoutDetails { get; init; }
    }

    public class LayoutDetail
    {
        public string participant { get; init; }
        public string color { get; init; }
        public int xPos { get; init; }
        public int yPos { get; init; }
    }
}
