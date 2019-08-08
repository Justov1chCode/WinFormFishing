using System;
using System.Collections.Generic;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace Fishing
{
    class Game
    {
        public const string NO_BAIT_EQUIPED = "Не назначена наживка";
        public const string NO_LURE_EQUIPED = "Не назначена приманка";
        public static bool isBaitMoving = false;
        public static OzeroForm ozeroForm = new OzeroForm();
        public static Point CastPoint;
        public static Random fishMovingX = new Random();
        public static Random fishMovingY = new Random();
        public static Random randomWeigth = new Random();
        public static int roadX = 0;
        public static int roadY = 470;
        public static int windingSpeed = 0;
        public static int moveLeftRigthSpeed = 0;
        public static int moveUpDownSpeed = 0;
        public static int nettingY = 800;
        public static int fishpowerX = 0;
        public static int fishpowerY = 0;
        public static bool isFishAttack = false;
        public static Random randomFish = new Random();
        public static Random randomGathering = new Random();
        public static int Deep;
        public static GUI gui = new GUI();
        public static CurrentFish currentFish;
        
   
    }
}
