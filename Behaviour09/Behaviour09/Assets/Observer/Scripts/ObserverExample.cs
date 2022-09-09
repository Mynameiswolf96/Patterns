using UnityEngine;

namespace Observer.Scripts
{
    public class ObserverExample : MonoBehaviour
    {
        private Radio _radio;
        private Dancer _jack;
        private Singer _jill;

        [ContextMenu("Test Observer")]
        private void TestObserver()
        {
            _radio = new Radio();

            _jack = new Dancer();
            _jack.Listen(_radio);

            _jill = new Singer();
            _jill.Listen(_radio);
        }

        [ContextMenu("Wait 1 minute")]
        private void WaitABit()
        {
            _radio.Wait(1);
        }

        [ContextMenu("Wait 5 minutes")]
        private void WaitABitLonger()
        {
            _radio.Wait(5);
        }
    }
}