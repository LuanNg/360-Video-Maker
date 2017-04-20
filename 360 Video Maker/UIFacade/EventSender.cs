using Entities;
using Entities.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _360_Video_Maker.UIFacade
{
    public class EventSender
    {
        public event EventHandler CoordinatesChanged;

        public void ChangeCoordinatesForSelectedVideo(int index)
        {
            Coordinates coord = new Coordinates();
        }

        public void VideoCoordChanged(CoordType type, int index, double value)
        {

        }
    }
}
