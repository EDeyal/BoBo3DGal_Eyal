using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoBo3DGal_Eyal
{
    public class Transform : Component
    {

        #region Fields
        GameObject _parent;
        
        string _name;
        Vector3 _localPosition;
        Vector3 _forward;
        Vector3 _right;
        Vector3 _down;
        Vector3 _position;
        Vector3 _scale;
        #endregion

        #region Properties
        public GameObject Parent { get => _parent; set => _parent = value; }
        public string Name { get => _name; set => _name = value; }
        public Vector3 Position { get => _position; set => _position = value; }
        public Vector3 Scale { get => _scale; set => _scale = value; }
        #endregion

        #region Constructors
        public Transform(GameObject gameObject)
        {
            Name = gameObject.Name;
            Position = new Vector3(0, 0, 0);
            Scale = new Vector3(1, 1, 1);
            Console.WriteLine($"New Transform{this}");
        }

        public Transform(Vector3 position, Vector3 scale)
        {
            Name = base.Name;
            Position = position;
            Scale = scale;
            Console.WriteLine(Environment.NewLine + $"New Transform{this}" + Environment.NewLine);
        }
        #endregion

        #region Static Methods
        public static void Destroy(GameObject parentGameObject)
        {
            if (parentGameObject == null)
                Console.WriteLine("Couldn't destroy parent GameObject");

            //removes a GameObject.
            Destroy(parentGameObject);
        }

        public static void Destroy(Component parentComponent)
        {
            if (parentComponent == null)
                Console.WriteLine("Couldn't destroy parent Component");

            //removes a Component.
            Destroy(parentComponent);
        }

        /*
        public static void Destroy(Assest parentAssest)
        {
            //removes an asset.
            Destroy(parentAssest);
        }
        */

        public static void DontDestroyOnLoad()
        {
            //do not destroy the target Object when loading a new Scene.
        }

        public static T FindObjectOfType<T>(List<T> listOfAllLoadedObjects)
        {
            //check if list empty
            if (listOfAllLoadedObjects.Count == 0)
                Console.WriteLine("No objects have loaded yet.");

            //returns first loaded object
            return listOfAllLoadedObjects.First();
        }

        public static T FindObjectsOfType<T>(List<T> listOfAllLoadedObjects)
        {
            //check if list empty
            if (listOfAllLoadedObjects.Count == 0)
                Console.WriteLine("No objects have loaded yet.");

            //returns all loaded objects
            foreach (T obj in listOfAllLoadedObjects)
                return obj;

            return default;
        }
        #endregion

        #region Methods

        public void Translate(Vector3 translation)
        {
            //not good
            Position.Add(translation);
        }

        public void Translate(float x, float y, float z)
        {
            //not good
            Position.Add(new Vector3(x,y,z));
        }

        public T GetComponent<T>() where T : Component
        {
            foreach (Component component in Parent.Components)
                if (component is T)
                    return component as T;
            
            return null;
        }

        public T GetComponents<T>() where T : Component
        {
            foreach (Component component in Parent.Components)
                return component as T;

            return null;
        }
        #endregion

        #region Overrides
        public override string ToString()
        {
            return $"Transform of {Name}" + Environment.NewLine
                 + $"Position: {Position}," + Environment.NewLine
                 + $" Scale: {Scale}";
        }
        #endregion
    }
}