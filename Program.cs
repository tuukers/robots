using System;

namespace Robot {
    class Program{
        static void Main(string[] args){
            Robot myRobot0 = new Robot("Terminator1");
            Robot myRobot1 = new Robot("Terminator2");

            myRobot0.Scan();
            myRobot0.Fire(7);
            myRobot0.Fire(20);

        }
    }
}