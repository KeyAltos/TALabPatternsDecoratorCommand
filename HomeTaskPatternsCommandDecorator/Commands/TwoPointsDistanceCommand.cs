using HomeTaskPatternsCommandDecorator.Recievers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskPatternsCommandDecorator.Commands
{
    public class TwoPointsDistanceCommand:ICommand
    {
        private TwoPointsDistance twoPointsDistance;

        public TwoPointsDistanceCommand(TwoPointsDistance twoPointsDistance)
        {
            this.twoPointsDistance = twoPointsDistance;
        }

        public void Execute()
        {
            twoPointsDistance.CalculateDistance();
        }
    }
}
