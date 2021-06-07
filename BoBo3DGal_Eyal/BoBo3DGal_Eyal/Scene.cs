using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoBo3DGal_Eyal
{
    public class Scene
    {
        public Scene(int sceneIndex)
        {
            SceneIndex = sceneIndex;
        }
        List<GameObject> _gameObjects = new List<GameObject>();
        int _sceneIndex;

        public List<GameObject> GetSetGameObjects { get => _gameObjects; set => _gameObjects = value; }
        public int SceneIndex { get => _sceneIndex; set => _sceneIndex = value; }
        void Start()
        {
            Console.WriteLine("Starting Scene");
            GetSetGameObjects.Add(new GameObject("Empty Game Object",new Transform(new Vector3(0,0,0))));
            Console.WriteLine("Scene Started");
        }
        public void Update()
        {
            Console.WriteLine("Executing Update");
            Console.ReadLine();
        }
        public void OnEnable()
        {
            Console.WriteLine("Enabling Scene");
            foreach (var gameObject in GetSetGameObjects)
            {
                gameObject.Enable();
            }
            Start();
            Console.WriteLine("Scene Enabled");
        }
        public void OnDisable()
        {
            foreach (var gameObject in GetSetGameObjects)
            {
                gameObject.Disable();
            }
        }
        public void GetGameObject(GameObject gameObject)
        {
            throw new System.NotImplementedException();
        }
    }
}