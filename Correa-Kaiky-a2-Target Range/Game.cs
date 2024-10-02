// Include code libraries you need below (use the namespace).
using System;
using System.Numerics;
using System.Runtime.CompilerServices;

// The namespace your code is in.
namespace Game10003
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Place your variables here:
        float[] xCoordinates = [];
        float[] yCoordinates = [];
        float targetsize = 5;

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            //Define's the Screen elements
            Window.SetSize(600, 800);
            Window.SetTitle("Target Scenario");
            Window.TargetFPS = 10;
            Window.ClearBackground(Color.Black);

            //separates the coordinates in an array


            //Amount of targets on screen 
            int amount = 40;
            xCoordinates = new float[amount];
            yCoordinates = new float[amount];
            for (int i = 0; i < amount; i++)
            {
                xCoordinates[i] = Random.Integer(10, 590);
                yCoordinates[i] = Random.Integer(10, 450);

            }


        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            //Colors used throughout the coded
            Color brown = new Color(0x9e, 0x45, 0x39);
            Color purpletarget = new Color(0x4a, 0x24, 0x80);
            Color stone = new Color(0x7f, 0x70, 0x8a);
            Color water = new Color(0x4d, 0x65, 0xb4);
            Color grass = new Color(0x0e, 0xaf, 0x9b);
            Color Prism = new Color(0x8f, 0xd3, 0xff);
            Color PrismLine = new Color(0x8f, 0xf8, 0xe2);
            Color purpleobs = new Color(0x83, 0x1c, 0x5d);
            Color lowflame = new Color(0xea, 0x4f, 0x36);
            Color midflame = new Color(0xf5, 0x7d, 0x4a);
            Color highflame = new Color(0xfb, 0xb9, 0x54);
            Color darkblue = new Color(0x4d, 0x65, 0xb4);
            Color lightblue = new Color(0x4d, 0x9b, 0xe6);
            Color skyblue = new Color(0x8f, 0xd3, 0xff);
            Color star = new Color(0x48, 0x4a, 0x77);
            //

            
            

            void NightTime()
            {
                for (int i = 0; i < 20; i++)
                {
                    Draw.LineSize = 0;
                    Draw.FillColor = Color.Black;
                    int nighttimeline = i * 30;
                    Draw.Square(nighttimeline + 0, 0, 500);

                }
            }
            //Function that creates a layer of grass stone for the scenario
            void GrassScenario()
            {
                for (int i = 0; i < 20; i++)
                {
                    Draw.LineSize = 0;
                    Draw.FillColor = grass;
                    int grassline = i * 30;
                    Draw.Square(grassline + 0, 490, 45);
                }
            }
            //executes the function
            GrassScenario();

            //Function that creates a layer of dirt stone for the scenario
            void DirtScenario()
            {
                for (int i = 0; i < 20; i++)
                {
                    Draw.LineSize = 1;
                    Draw.LineColor = Color.Black;
                    Draw.FillColor = brown;
                    int squareline = i * 30;
                    Draw.Square(squareline + 0, 500, 45);
                }
            }
            //executes the function
            DirtScenario();
            //Function that creates a layer of stone stone for the scenario
            void StoneScenario()
            {
                for (int i = 0; i < 20; i++)
                {
                    Draw.LineSize = 1;
                    Draw.FillColor = stone;
                    int stoneline = i * 30;
                    Draw.Square(stoneline + 0, 530, 45);

                }
            }
            //executes the function
            StoneScenario();
            //Function that creates a layer of water stone for the scenario
            void WaterScenario()
            {
                for (int i = 0; i < 20; i++)
                {
                    Draw.LineSize = 0;
                    Draw.FillColor = water;
                    int waterline = i * 30;
                    Draw.Square(waterline + 0, 560, 45);
                }
            }
            //executes the function
            WaterScenario();
            //Function that creates a layer of prism stone for the scenario
            void PrismaScenario()
            {
                for (int i = 0; i < 20; i++)
                {
                    Draw.LineSize = 1;
                    Draw.LineColor = PrismLine;
                    Draw.FillColor = Prism;
                    int prismline = i * 30;
                    Draw.Square(prismline + 0, 590, 45);
                }
            }
            //executes the function
            PrismaScenario();
            //Function that creates a layer of obsidian stone for the scenario
            void ObsidianScenario()
            {
                for (int i = 0; i < 20; i++)
                {
                    Draw.LineSize = 1;
                    Draw.LineColor = purpleobs;
                    Draw.FillColor = Color.Black;
                    int obsidianline = i * 30;
                    Draw.Square(obsidianline + 0, 620, 45);
                }
            }
            //executes the function
            ObsidianScenario();
            //Function that creates a layer of dark flame for the scenario
            void LowFlameScenario()
            {
                for (int i = 0; i < 20; i++)
                {
                    Draw.LineSize = 0;
                    Draw.FillColor = lowflame;
                    int lowflameline = i * 30;
                    Draw.Square(lowflameline + 0, 650, 45);
                }
            }
            //executes the function
            LowFlameScenario();
            //Function that creates a layer of bright flame for the scenario
            void MidFlameScenario()
            {
                for (int i = 0; i < 20; i++)
                {
                    Draw.LineSize = 0;
                    Draw.FillColor = midflame;
                    int midflameline = i * 30;
                    Draw.Square(midflameline + 0, 680, 45);
                }
            }
            //executes the function
            MidFlameScenario();
            //Function that creates a layer of brighter flame for the scenario
            void HighFlameScenario()
            {
                for (int i = 0; i < 20; i++)
                {
                    Draw.LineSize = 0;
                    Draw.FillColor = highflame;
                    int highflameline = i * 30;
                    Draw.Square(highflameline + 0, 710, 45);
                }
            }
            //Executes the function
            HighFlameScenario();
            //Function that creates a layer of blue sky for the scenario
            void DarkBlueSky()
            {
                for (int i = 0; i < 20; i++)
                {
                    Draw.LineSize = 0;
                    Draw.FillColor = darkblue;
                    int darkblueskyline = i * 30;
                    Draw.Square(darkblueskyline + 0, 0, 45);
                }
            }
            //Executes the fumction
            DarkBlueSky();
            //Function that creates a layer of light blue sky for the scenario
            void LightBlueSky()
            {
                for (int i = 0; i < 20; i++)
                {
                    Draw.LineSize = 0;
                    Draw.FillColor = lightblue;
                    int lightblueskyline = i * 30;
                    Draw.Square(lightblueskyline + 0, 30, 45);
                }
            }
            //Executes the Function
            LightBlueSky();
            //Function that creates a layer of lighter tone of blue sky for the scenario
            void BlueSky()
            {
                for (int i = 0; i < 20; i++)
                {
                    Draw.LineSize = 0;
                    Draw.FillColor = skyblue;
                    int blueskyline = i * 30;
                    Draw.Square(blueskyline + 0, 80, 400);
                }
            }
            //Executes the Function
            BlueSky();

            Console.WriteLine("Change the Targets\n" +
                "Space Bar -> Change Target Color\n" +
                "Down Key -> Night Time Mode" +
                "Up Key -> Target Side Swap");

            //sets the basic for the targets design
            Draw.LineSize = 1;
            Draw.LineColor = Color.White;


            //draws targets randomly on the screen
            void RandomStars()
            {
                for (int i = 0; i < xCoordinates.Length; i++)
                {
                    Draw.LineSize = 1;
                    Draw.LineColor = star;
                    Draw.FillColor = Color.White;
                    Draw.Circle(xCoordinates[i], yCoordinates[i], targetsize);
                }
            }
            void CircleTargetLeft()
            {
                Draw.LineSize = 1;
                Draw.LineColor = Color.Black;
                Draw.FillColor = Color.Red;
                Draw.Circle(200, 300, 80);
                Draw.FillColor = Color.White;
                Draw.Circle(200, 300, 50);
                Draw.FillColor = Color.Red;
                Draw.Circle(200, 300, 20);
            }
            void CircleTargetRight()
            {
                Draw.LineSize = 1;
                Draw.LineColor = Color.Black;
                Draw.FillColor = Color.Red;
                Draw.Circle(500, 300, 80);
                Draw.FillColor = Color.White;
                Draw.Circle(500, 300, 50);
                Draw.FillColor = Color.Red;
                Draw.Circle(500, 300, 20);
            }
            void CircleTargetRight2()
            {
                Draw.LineSize = 1;
                Draw.LineColor = Color.White;
                Draw.FillColor = Color.Blue;
                Draw.Circle(500, 300, 80);
                Draw.FillColor = Color.Black;
                Draw.Circle(500, 300, 50);
                Draw.FillColor = Color.Blue;
                Draw.Circle(500, 300, 20);
            }
            void CircleTargetLeft2()
            {
                Draw.LineSize = 1;
                Draw.LineColor = Color.White;
                Draw.FillColor = Color.Blue;
                Draw.Circle(200, 300, 80);
                Draw.FillColor = Color.Black;
                Draw.Circle(200, 300, 50);
                Draw.FillColor = Color.Blue;
                Draw.Circle(200, 300, 20);
            }
            CircleTargetLeft();
            //Variable to decide between two possible outcome related to drawing the target when the UP key is pressed
            int coinflip = Random.Integer(0, 3);
            //Checks the Input of Space key to change the Target Color
            if (Input.IsKeyboardKeyDown(KeyboardInput.Space))
            {
                CircleTargetLeft2();
            }
            //Check for down arrow key to change scenario
            else if (Input.IsKeyboardKeyDown(KeyboardInput.Down))
            {
                NightTime();
                RandomStars();
                CircleTargetLeft();
            }
            //Uses Coin Flip and up key to change the location of the target
            if (Input.IsKeyboardKeyDown(KeyboardInput.Up) && coinflip == 1)
            {
                CircleTargetRight();
            }
            else if (Input.IsKeyboardKeyDown(KeyboardInput.Up) && coinflip == 2)
            {
                CircleTargetRight2();
            }
        }
    }
}
