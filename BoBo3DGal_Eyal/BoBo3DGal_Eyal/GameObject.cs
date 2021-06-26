using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoBo3DGal_Eyal
{
    public class GameObject
    {
        #region
        //List<GameObject> _gameObjects = new List<GameObject>();
        Node _parentNode;
        private List<Component> _components = new List<Component>();
        private string _name;
        private bool _isEnabled;
        bool _isSetActive = true;
        #endregion
        #region Properties
        //public List<GameObject> GetSetGameObjects { get => _gameObjects; set => _gameObjects = value; }
        public List<Component> Components { get => _components; set => _components = value; }
        public string Name { get => _name; set => _name = value; }
        public bool IsEnabled { get => _isEnabled; set => _isEnabled = value; }
        public bool IsSetActive { get => _isSetActive; set
            { // if changing set active to value it will also change isEnabled 
                _isSetActive = value;
                _isEnabled = value;
            }
        }
        public Node GetSetParentNode { get => _parentNode; set => _parentNode = value; }
        #endregion
        public GameObject(string name)//Default constructor that transform is vector3 zero
        {
            Name = name;
            Console.WriteLine($"New Game Object has been created {ToString()}");
            Transform tr = new Transform(new Vector3(0, 0, 0));
            AddComponent(tr);
            tr.GetSetGameObject = this;
        }
        public GameObject(string name,Transform transform)//Constructor with Transform that the player will enter
        {
            Name = name;
            Console.WriteLine($"New Game Object has been created {ToString()}");
            AddComponent(transform);
            transform.GetSetGameObject = this;
        }
        #region Methods
        public void Disable()
        {
            Console.WriteLine($"Disabling GameObject{ToString()}");
            IsEnabled = false;
            //need implementation
            Console.WriteLine($"GameObject Disabled {ToString()}");
        }
        public void EnableGameObject()
        {
            Console.WriteLine($"Enabling GameObject {ToString()}");
            if(_isSetActive == false)
            {
                Console.WriteLine($"Not enabling {ToString()}");
                return;
            }
            IsEnabled = true;
            //need implementation
            Console.WriteLine($"GameObject Enabled {ToString()}");
        }
        public void Destroy(List<GameObject> gameObjects)
        {
            Console.WriteLine($"Destroying {this}");
            OnDisable();
            Console.WriteLine($"{Name} is Destroyed");
            gameObjects.Remove(this);
        }
        public void OnDisable()
        {
            Console.WriteLine($"Removing all Components from {this} GameObject");
            foreach (var component in Components)
            {
                Components.Remove(component);
            }
            Console.WriteLine($"All Components Are Removed from {this}");
        }
        public void AddComponent(Component component)
        {
            Console.WriteLine("Trying to add Componnent");
            if(component == null)
            {
                Console.WriteLine("Error in Add Component");
                return;
            }
            if (CheckForTransform(component))
            {
                Console.WriteLine("Cant Add for more than one Transform to an object");
                return;
            }
            Components.Add(component);
            Console.WriteLine("Component added");
        }
        public void RemoveComponent(Component component)
            //if the spechific component exists inside of the componnenst it will be removed
        {
            if(_components == null)//cant really be null but still good to check
            {
                Console.WriteLine("ERROR Game Object Componnents Are NULL");
                return;
            }
            bool isTransform = component is Transform;
            if (component != null || isTransform != true)
            {
                Console.WriteLine("Attempting to remove Component");
                for (int i = 0; i < _components.Count; i++)
                {
                    if(_components[i] == component)
                    {
                        Console.WriteLine($"Removing Component {_components[i]}");
                        _components.Remove(component);
                        return;
                    }
                }
                Console.WriteLine("Component not found");
            }
            else if(isTransform == true) 
            {
                Console.WriteLine("Transform can not be removed");
            }
            else
            {
                Console.WriteLine("Component is null");
            }
        }
        public T GetComponent<T>() where T : Component
        {
            Console.WriteLine("Trying to get component");
            if(typeof(T) == null)
            {
                Console.WriteLine("Error in Get Component");
                return null;
            }
            foreach (var item in _components)
            {
                if(item.GetType() == typeof(T))
                {
                    Console.WriteLine($"Found component {item}");
                    return item as T;
                }
            }
            return null;
            //SearchComponent
            Console.WriteLine("Did not find component");
        }
        public override string ToString()
        {
            return $"Name:{Name}, IsEnabled: {IsEnabled}";
        }
        bool CheckForTransform(Component component)
        {
            if (component is Transform)
            {
                foreach (var componnent in _components)
                {
                    if (componnent is Transform)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        #endregion
    }
}