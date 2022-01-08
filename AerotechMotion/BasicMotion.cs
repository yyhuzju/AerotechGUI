using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Aerotech.A3200;
using Aerotech.A3200.Exceptions;
using Aerotech.A3200.Status;
using Aerotech.A3200.Variables;
using Aerotech.A3200.Tasks;
using Aerotech.A3200.Information;
using Aerotech.Common;
using Aerotech.Common.Collections;


namespace AerotechMotion
{
    public class BasicMotion
    {
        private Controller _controller = null;
        private AxisMask _axisMask = AxisMask.None;
        public Controller controller {
            get { return _controller; }
            set { _controller = value; } 
        }
        public AxisMask axisMask { 
            get { return _axisMask; }
            set { _axisMask = value; } }
        public void AbortMotion(Variable variable)
        {
            try
            {
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
            
        }
        public void WaitFormMotionDone()
        { 

        }

    }
}
