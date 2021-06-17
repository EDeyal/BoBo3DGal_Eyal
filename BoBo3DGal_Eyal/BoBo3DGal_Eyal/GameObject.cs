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
        List<GameObject> _gameObjects = new List<GameObject>();
        private List<Component> _components = new List<Component>();
        private string _name;
        private bool _isEnabled;
        #endregion
        #region Properties
        public List<GameObject> GetSetGameObjects { get => _gameObjects; set => _gameObjects = value; }
        public List<Component> Components { get => _components; set => _components = value; }
        public string Name { get => _name; set => _name = value; }
        public bool IsEnabled { get => _isEnabled; set => _isEnabled = value; }
        #endregion
        public GameObject(string name,Transform transform)
        {
            Name = name;
            Console.WriteLine($"New Game Object has been created {ToString()}");
            _components.Add(transform);
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
        public void Enable()
        {
            Console.WriteLine($"Enabling GameObject {ToString()}");
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
            if(component == null)
            {
                Console.WriteLine("Error in Add Component");
                return;
            }
            Components.Add(component);
        }
        public void RemoveComponent(Component component)
        {
            bool isTransform = component is Transform;
            if (component != null || isTransform != true)
            {
                Console.WriteLine("Removing Component");
                //need implementation
                Console.WriteLine("Component Removed");
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
        public void GetComponent(string nameOfComponent)
        {
            if(nameOfComponent == "" || nameOfComponent == null)
            {
                Console.WriteLine("Error in Get Component");
                return;
            }
            //SearchComponent
            Console.WriteLine("Component Recieved");
        }
        public override string ToString()
        {
            return $"GameObject Name:{Name}, IsEnabled: {IsEnabled}";
        }
        #endregion
    }
}