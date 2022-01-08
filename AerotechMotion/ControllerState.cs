using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aerotech.A3200;
using Aerotech.A3200.Information;
using Aerotech.A3200.Status;
using Aerotech.A3200.Tasks;

namespace AerotechMotion
{
    public class ControllerState
    {
        private bool _connected = false;
        public bool connected
        {
            get { return _connected; }
            set { _connected = value; }
        }

        private Controller _myController = null;
        public Controller myController
        {
            get { return _myController; }
            set { _myController = value; }
        }
        public ControllerState() { }
        public TasksCollection Task()
        {
            return _myController.Tasks;
        }
        public ControllerInformation Information()
        {
            return _myController.Information;
        }
        public void Reset()
        {
            try
            {
                _myController.Reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Controller not connected");
            }
        }

        public void Disconnect()
        {
            Controller.Disconnect();
        }
        internal void OnControllerResetting(ControllerEventArgs e)
        {
            EventHandler<ControllerEventArgs> handler = ControllerResetting;
            if (handler != null)
            {
                handler(_myController, e);
            }

        }
        public event EventHandler<ControllerEventArgs> ControllerResetting;
    }
}
