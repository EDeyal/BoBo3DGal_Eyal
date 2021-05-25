using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoBo3DGal_Eyal
{
    public class GameObject
    {
        private List<Component> _components;
        private string _name;
        private bool _isEnabled;

        public List<Component> Components { get => _components; set => _components = value; }

        public string Name { get => _name; set => _name = value; }

        public bool IsEnabled { get => _isEnabled; set => _isEnabled = value; }

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

        public void AddComponent()
        {
            throw new System.NotImplementedException();
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