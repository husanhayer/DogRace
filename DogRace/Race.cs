using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogRace
{
    // decalaring an Interface for returning a value to main Class and using the concept of Multiple Inheritance 
     public interface Move {
        // User Define Method declaring in the block of interface for better working
        int run(int num);

        // user define to reset all the images of the dog move back to the starting position this is returning a value to the main value
         int resetImage();
    }
    public class Race:Move
    {
        // user method to return a unique no for increment 
        public int run(int Number) {
            return Number;
        }
        
        // reset all the Images to the starting position
        public int resetImage() {
                return -1;
        }
    }
}
