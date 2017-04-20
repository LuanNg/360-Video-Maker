using Entities.Attributes;

namespace Entities
{
    public class Coordinates
    {
        [CoodinatesValidator(CoordType.U, ErrorMessage = "Invalid value")]
        public double U;
        [CoodinatesValidator(CoordType.V, ErrorMessage = "Invalid value")]
        public double V;

        [CoodinatesValidator(CoordType.Rotation, ErrorMessage = "Invalid value")]
        public double Rotation;

        [CoodinatesValidator(CoordType.Vert_FOV, ErrorMessage = "Invalid value")]
        public double Hoz_FOV;
        [CoodinatesValidator(CoordType.Hoz_FOV, ErrorMessage = "Invalid value")]
        public double Vert_FOV;
    }
}