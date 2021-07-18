using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoBo3DGal_Eyal
{
    public class Game
    {
        #region Fields
        List<Scene> _sceneList = new List<Scene>(10);
        Scene _currentScene;
        Scene _defaultScene = new Scene(0);
        float _deltaTime;
        bool _isGameOn = false;
        #endregion

        #region Properties
        List<Scene> SceneList { get => _sceneList; set => _sceneList = value; }
        Scene CurrentScene { get => _currentScene; set => _currentScene = value; }
        Scene DefaultScene => _defaultScene;
        float DeltaTime { get => _deltaTime; set => _deltaTime = value; }
        bool IsOn { get => _isGameOn; set => _isGameOn = value; }
        #endregion

        public Game()
        {
            OnEnable();
        }

        #region Methods
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
                Scene scene = ActiveScene();

                if (scene == null)
                {
                    Console.WriteLine("Error in Run");
                    return false;
                }

                Console.WriteLine("Scene Found Attempting to load");
                _isGameOn = true;
                return LoadScene(scene);
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
        #endregion
    }
}