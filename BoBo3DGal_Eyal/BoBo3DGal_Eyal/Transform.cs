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
        Transform _transform;
        
        string _name;
        Vector3 _position;
        Vector3 _scale;
        Vector3 _xAxis = new Vector3(1, 0, 0);
        Vector3 _yAxis = new Vector3(0, 1, 0);
        Vector3 _zAxis = new Vector3(0, 0, 1);
        #endregion

        #region Properties
        public GameObject Parent { get => _parent; set => _parent = value; }
        public Transform TransformP { get => _transform; set => _transform = value; }
        public string Name { get => _name; set => _name = value; }
        public Vector3 Position { get => _position; set => _position = value; }
        public Vector3 Scale { get => _scale; set => _scale = value; }
        public Vector3 XAxis { get => _xAxis; set => _xAxis = value; }
        public Vector3 YAxis { get => _yAxis; set => _yAxis = value; }
        public Vector3 ZAxis { get => _zAxis; set => _zAxis = value; }
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

        //need fixes
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

        //need fixes
        #region Static Methods
        public static void Destroy(GameObject parentGameObject)
        {
            //check if gameObject exist
            if (parentGameObject == null)
                Console.WriteLine("Couldn't find parent GameObject to destroy");

            //removes a GameObject.
            Destroy(parentGameObject);
        }

        public static void Destroy(Component parentComponent)
        {
            //check if gameObject exist
            if (parentComponent == null)
                Console.WriteLine("Couldn't find parent Component to destroy");

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

        #region Overrides
        public override string ToString()
        {
            return $"Transform of {Name}" + Environment.NewLine
                 + $"Position: {Position}," + Environment.NewLine
                 + $"Scale: {Scale}" + Environment.NewLine;
        }

        public override bool Equals(object obj)
        {
            return obj is Transform transform &&
                   EqualityComparer<GameObject>.Default.Equals(GameObjectP, transform.GameObjectP) &&
                   EqualityComparer<Transform>.Default.Equals(TransformP, transform.TransformP) &&
                   Name == transform.Name &&
                   EqualityComparer<GameObject>.Default.Equals(_parent, transform._parent) &&
                   EqualityComparer<Transform>.Default.Equals(_transform, transform._transform) &&
                   _name == transform._name &&
                   EqualityComparer<Vector3>.Default.Equals(_position, transform._position) &&
                   EqualityComparer<Vector3>.Default.Equals(_scale, transform._scale) &&
                   EqualityComparer<Vector3>.Default.Equals(_xAxis, transform._xAxis) &&
                   EqualityComparer<Vector3>.Default.Equals(_yAxis, transform._yAxis) &&
                   EqualityComparer<Vector3>.Default.Equals(_zAxis, transform._zAxis) &&
                   EqualityComparer<GameObject>.Default.Equals(Parent, transform.Parent) &&
                   EqualityComparer<Transform>.Default.Equals(TransformP, transform.TransformP) &&
                   Name == transform.Name &&
                   EqualityComparer<Vector3>.Default.Equals(Position, transform.Position) &&
                   EqualityComparer<Vector3>.Default.Equals(Scale, transform.Scale) &&
                   EqualityComparer<Vector3>.Default.Equals(XAxis, transform.XAxis) &&
                   EqualityComparer<Vector3>.Default.Equals(YAxis, transform.YAxis) &&
                   EqualityComparer<Vector3>.Default.Equals(ZAxis, transform.ZAxis);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        #endregion

        #region Operators
        public static bool operator ==(Transform firstTransform, Transform secondTransform)
        {
            if (firstTransform == secondTransform)
                return true;
            else
                return false;
        }
        public static bool operator !=(Transform firstTransform, Transform secondTransform)
        {
            if (firstTransform != secondTransform)
                return true;
            else
                return false;
        }
        #endregion
    }
}