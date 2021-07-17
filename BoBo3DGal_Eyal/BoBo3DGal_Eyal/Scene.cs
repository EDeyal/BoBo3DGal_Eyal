using System;
using System.Collections.Generic;
using System.Text;

namespace BoBo3DGal_Eyal
{
    public class Scene
    {
        public Scene(int sceneIndex)
        {
            SceneIndex = sceneIndex;
        }
        #region Field
        List<TreeOfGameObjects> _hirarchy = new List<TreeOfGameObjects>();
        //List<GameObject> _gameObjects = new List<GameObject>();
        int _sceneIndex;
        #endregion
        #region Properties
        List<TreeOfGameObjects> GetHirarchy => _hirarchy;
        //public List<GameObject> GetSetGameObjects { get => _gameObjects; set => _gameObjects = value; }
        public int SceneIndex { get => _sceneIndex; set => _sceneIndex = value;}

        #endregion
        public void Start()//initializing scene
        {
            Console.WriteLine("Starting Scene");
            //GetSetGameObjects.Add(new GameObject("Empty Game Object", new Transform(new Vector3(0, 0, 0))));

            //testing hirarcy
            /*
            GetHirarchy.Add(new TreeOfGameObjects(new Node(new GameObject("Player"), null)));
            new Node(new GameObject("Player Hand", new Transform(new Vector3(0, 0, 0), new Vector3(1, 1, 1))), GetHirarchy[0].Root);
            BoxCollider bc = new BoxCollider();
            GetHirarchy[0].Root.GetChildren[0].GetGameObject.AddComponent(bc);
            GetHirarchy[0].Root.GetChildren[0].GetGameObject.AddComponent(new Transform(new Vector3 (0,1,0)));
            GetHirarchy[0].Root.GetChildren[0].GetGameObject.RemoveComponent(new BoxCollider());
            GetHirarchy[0].Root.GetChildren[0].GetGameObject.RemoveComponent(bc);
            GetHirarchy[0].Root.GetChildren[0].GetGameObject.GetComponent<Transform>();
            GetGameObject("Player Hand");
            GetGameObject("Playe");
            */



            OnEnable();
            Console.WriteLine("Scene Started");
        }
        public void Update()
        {
            Console.WriteLine("Executing Update");
            Console.ReadLine();
        }
        public void OnEnable()//Enabling all game objects
        {
            if(GetHirarchy != null || GetHirarchy.Count != 0)
            {
                Console.WriteLine("Enabling Scene");
                foreach (var tree in GetHirarchy)
                {
                    tree.Root.EnableNode(tree.Root);
                    //gameObject.Enable();
                }
                Console.WriteLine("Scene Enabled");
            }
            else
            {
                Console.WriteLine("Game Objects ListEmpty, Enabling Skipped");
            }
        }
        public void OnDisable()
        {
            foreach (var tree in GetHirarchy)
            {
                tree.Root.GetGameObject.Disable();
            }
        }
        public void GetGameObject(string gameObjectName)
        {
            Console.WriteLine($"Looking for GameObject with the name:{gameObjectName}");
            foreach (var tree in GetHirarchy)
            {
                tree.Root.FindGameObject(gameObjectName);
            }
        }
    }
}