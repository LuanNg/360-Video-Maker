using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Entities.Attributes
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    sealed public class CoodinatesValidator : ValidationAttribute
    {
        readonly CoordType _coord;

        public CoodinatesValidator(CoordType coord)
        {
            this._coord = coord;
        }

        public override bool IsValid(object value)
        {
            double vidCoord = Convert.ToDouble(value);

            if (_coord == CoordType.U || _coord == CoordType.V)
            {
                if (vidCoord >= 0 && vidCoord <= 1)
                    return true;
            }

            if (_coord == CoordType.Rotation)
            {
                if (vidCoord >= 0 && vidCoord <= 360)
                {
                    return true;
                }
            }

            if (_coord == CoordType.Hoz_FOV || _coord == CoordType.Vert_FOV)
            {
                if (vidCoord > 0 && vidCoord <= 360)
                    return true;
            }

            return false;
        }
    }

    public enum CoordType
    {
        U,
        V,
        Rotation,
        Hoz_FOV,
        Vert_FOV
    }
}
