using System;
using System.Collections.Generic;
using System.Text;

namespace BoBo3DGal_Eyal
{
    public class Scene
    {
        public Scene(int sceneIndex, string name)
        {
            SceneIndex = sceneIndex;
            _name = name;
        }
        #region Field
        List<TreeOfGameObjects> _hirarchy = new List<TreeOfGameObjects>();
        int _sceneIndex;
        string _name;
        #endregion
        #region Properties
        public List<TreeOfGameObjects> GetHirarchy => _hirarchy;
        public int SceneIndex { get => _sceneIndex; set => _sceneIndex = value;}
        public string Name => _name;
        #endregion
        public void Start()//initializing scene
        {
            Console.WriteLine("Starting Scene");

            #region Hirarcy Test
            //GetHirarchy.Add(new TreeOfGameObjects(new Node(new GameObject("Player"), null)));
            //new Node(new GameObject("Player Hand", new Transform(new Vector3(0, 0, 0))), GetHirarchy[0].Root);
            //BoxCollider bc = new BoxCollider();
            //GetHirarchy[0].Root.GetChildren[0].GetGameObject.AddComponent(bc);
            //GetHirarchy[0].Root.GetChildren[0].GetGameObject.AddComponent(new Transform(new Vector3 (0,1,0)));
            //GetHirarchy[0].Root.GetChildren[0].GetGameObject.RemoveComponent(new BoxCollider());
            //GetHirarchy[0].Root.GetChildren[0].GetGameObject.RemoveComponent(bc);
            //GetHirarchy[0].Root.GetChildren[0].GetGameObject.GetComponent<Transform>();
            //GetGameObject("Player Hand");
            //GetGameObject("Playe");
            #endregion

            OnEnable();

            #region Disable Test
            //OnDisable();
            #endregion
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
                }
                Console.WriteLine("Scene Enabled");
            }
            else
            {
                Console.WriteLine("Error in Hirarcy, Enabling Skipped");
            }
        }
        public void OnDisable()
        {
            if(GetHirarchy != null || GetHirarchy.Count != 0)
            {
                Console.WriteLine("Disabling Scene");
                foreach (var tree in GetHirarchy)
                {
                    tree.Root.DisableNode(tree.Root);
                }
                Console.WriteLine("Scene Disabled");
            }
            else
            {
                Console.WriteLine("Error with Hirarcy, Disabling Skipped");
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
        public override string ToString()
        {
            return _name;
        }
    }
}