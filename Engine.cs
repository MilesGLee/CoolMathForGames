using System;
using System.Collections.Generic;
using System.Text;

namespace CoolMathForGames
{
    class Engine
    {
        private static bool _applicationShouldClose = false;
        private static int _currentSceneIndex;
        private Scene[] _scenes = new Scene[0];

        //Called to begin the application
        public void Run() 
        {
            //Call start for the entire application
            Start();

            //Loop until the application is told to close
            while (!_applicationShouldClose) 
            {
                Update();
                Draw();
            }
            //Call end for entire application
            End();
        }

        //Called when the application starts
        private void Start() 
        {
            _scenes[_currentSceneIndex].Start();
        }

        //Called everytime the the game loops
        private void Update() 
        {
            _scenes[_currentSceneIndex].Update();
        }

        //Called every time the game loops to update visuals
        private void Draw() 
        {
            _scenes[_currentSceneIndex].Draw();
        }

        //Called when the application exits
        private void End() 
        {
            _scenes[_currentSceneIndex].End();
        }


        //Adds a scene to the engine's scene array
        public int AddScene(Scene scene) 
        {
            //Create a new temporary array
            Scene[] tempArray = new Scene[_scenes.Length + 1];

            //Copy all values from old array into new array
            for (int i = 0; i < _scenes.Length; i++) 
            {
                tempArray[i] = _scenes[i];
            }
            //Set the last index to be the new scene
            tempArray[_scenes.Length] = scene;

            //Set the old array to be the new array
            _scenes = tempArray;

            //Return the last index
            return _scenes.Length - 1;
        }
    }
}
