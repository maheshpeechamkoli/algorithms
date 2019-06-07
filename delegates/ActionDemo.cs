using System;

namespace delegates {

    public delegate void Firm (int num);
    public class ActionDemo {

      //  Action<int> action = (i) => {Console.WriteLine("Inside Anonymous method. Value: {0}", i.ToString());};
      Firm delfirm = (i) => {Console.WriteLine("Inside Anonymous method. Value: {0}", i.ToString());};
        public void aveva(){
            Firmware obj = new Firmware();
            obj.FirmwareUpdate(delfirm);
        }
    }

    public class Firmware {
        public void FirmwareUpdate (Firm act) {
            for (var i = 0; i < 100; i++) {
                act (i);
            }
        }
    }
}