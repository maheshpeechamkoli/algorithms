using System;

namespace delegates {
    public delegate void Firm1 (int num);
    public class Firmware1 {

        ActionDemo1 demo = new ActionDemo1 ();
        public Firmware1 () {
            demo.abcEvent += print;
        }
        public void print (int i) {
            Console.WriteLine ("Inside Anonymous method. Value: {0}", i.ToString ());
        }

        public void callPunlisher () {
            demo.aveva ();
        }
    }


    public class ActionDemo1 {
        public event Firm1 abcEvent;
        public void aveva () {
            for (var i = 0; i < 100; i++) {
                abcEvent (i);
            }
        }
    }

}