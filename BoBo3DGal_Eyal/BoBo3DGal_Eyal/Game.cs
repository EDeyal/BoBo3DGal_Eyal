using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoBo3DGal_Eyal
{
    public class Game
    {
        #region Fields
        float _deltaTime;
        Scene _currentScene;
        List<Scene> _sceneList;
        #endregion

        #region Properties
        float DeltaTime { get => _deltaTime; set => _deltaTime = value; }
        Scene CurrentScene { get => _currentScene; set => _currentScene = value; }
        List<Scene> SceneList { get => _sceneList; set => _sceneList = value; }
        #endregion

        public Game(Scene scene)
        {
            SceneList.Add(scene);
        }

        public bool Run()
        {
            if (ActiveScene() == null)
            {
                Console.WriteLine("Error in Run");
                return false;
            }
            LoadScene(ActiveScene());
            return true;
        }
        public bool LoadScene(Scene scene)
        {
            if(scene == null)
            {
                Console.WriteLine("Error in LoadScene");
                return false;
            }
            scene.Start();
            return true;
        }
        public Scene ActiveScene()
        {
            if(CurrentScene == null)
            {
                Console.WriteLine("Error in Active Scene");
                return null;
            }
            return CurrentScene;
        }
    }
}