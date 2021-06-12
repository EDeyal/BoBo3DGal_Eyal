using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoBo3DGal_Eyal
{
    public class Game
    {
        public Game()
        {
            OnEnable();
        }
        #region Fields
        bool _isGameOn = false;
        float _deltaTime;
        Scene _currentScene;
        Scene _defaultScene = new Scene(0);
        List<Scene> _sceneList = new List<Scene>(10);
        #endregion

        #region Properties
        bool IsOn { get => _isGameOn; set => _isGameOn = value; }
        float DeltaTime { get => _deltaTime; set => _deltaTime = value; }
        Scene CurrentScene { get => _currentScene; set => _currentScene = value; }
        Scene DefaultScene => _defaultScene;
        List<Scene> SceneList { get => _sceneList; set => _sceneList = value; }
        #endregion
        public void OnEnable()
        {
            Console.WriteLine("Enabling Game");
            SceneList.Add(DefaultScene);
            CurrentScene = DefaultScene;
            Console.WriteLine("Game Enabled");
        }
        public bool Run()
        {
            Console.WriteLine("Attempting to run Game");
            if (!_isGameOn)
            {
                if (ActiveScene() == null)
                {
                    Console.WriteLine("Error in Run");
                    return false;
                }
                Console.WriteLine("Scene Found Attempting to load");
                _isGameOn = true;
                return LoadScene(ActiveScene());
            }
            CurrentScene.Update();
            Console.WriteLine("Game Running");
            return true;
        }
        public bool LoadScene(Scene scene)
        {
            Console.WriteLine("Loading Scene");
            if(scene == null)
            {
                Console.WriteLine("Error in LoadScene");
                return false;
            }
            scene.Start();
            Console.WriteLine("Scene Loadded");
            return true;
        }
        public Scene ActiveScene()
        {
            Console.WriteLine("Checking for active Scene");
            if(CurrentScene == null)
            {
                Console.WriteLine("Error in Active Scene");
                return null;
            }
            Console.WriteLine("Active Scene: " + CurrentScene.ToString());
            return CurrentScene;
        }
    }
}