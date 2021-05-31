using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoBo3DGal_Eyal
{
    public class GameObject
    {
        #region
        private List<Component> _components;
        private string _name;
        private bool _isEnabled;
        #endregion
        #region Properties
        public List<Component> Components { get => _components; set => _components = value; }

        public string Name { get => _name; set => _name = value; }

        public bool IsEnabled { get => _isEnabled; set => _isEnabled = value; }
        #endregion
        public GameObject(Transform transform)
        {
            _components.Add(transform);
        }
        public void Disable()
        {
            throw new System.NotImplementedException();
        }
        public void Enable()
        {
            throw new System.NotImplementedException();
        }
        public void Destroy()
        {
            throw new System.NotImplementedException();
        }
        public void OnDisable()
        {
            throw new System.NotImplementedException();
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
        public void RemoveComponent()
        {
            throw new System.NotImplementedException();
        }
        public void GetComponent()
        {
            throw new System.NotImplementedException();
        }
    }
}