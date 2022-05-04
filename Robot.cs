using System;

namespace Robot {
    class Robot {
        
        // Attributes
        private string name;
        private int numAmmo;

        // Constructor
        public Robot(string name){
            this.name = name;
            this.numAmmo = 1000;
        }


        // Move
        public void Move(string direction){
            Console.WriteLine($"{this.name}: Moving to the {direction}.");
        }

        // Speak
        public void Speak(string sentence) {
            Console.WriteLine($"{this.name}: {sentence}");
        }
        // Fire
        public void Fire(int numBullets) {
            Console.WriteLine($"{this.name}: Firing {numBullets} bullets.");
            this.numAmmo=this.numAmmo-numBullets;
            Console.WriteLine($"{this.numAmmo} rounds remaining.");
        }
        // SelfDestruct
        public void SelfDestruct(string time) {
            Console.WriteLine($"{this.name}: Self destructinf in {time} seconds.");
        }
        // Scan
        public void Scan() {
            Console.WriteLine($"{this.name}: Scanning...");
        }
        // Pray
        public void Pray(string prayer) {
            Console.WriteLine($"{this.name}: {prayer}");
        }
    }
}