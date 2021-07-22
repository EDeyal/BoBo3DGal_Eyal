using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoBo3DGal_Eyal
{
    public class Ridigbooty : Component
    {
        #region Fields
        GameObject _parent;
        Transform _transform;
        BoxCollider _boxCollider;

        string _name;
        float _velocity, _gravityScale, _mass, _drag;
        Vector3 _position;
        bool _useGravity, _isKinematic, _freezRotation;
        #endregion

        #region Properties
        public GameObject Parent { get => _parent; set => _parent = value; }
        public Transform TransformP { get => _transform; set => _transform = value; }
        public BoxCollider BoxColliderP { get => _boxCollider; set => _boxCollider = value; }
        public string Name { get => _name; set => _name = value; }
        public float Velocity { get => _velocity; set => _velocity = value; }
        public float GravityScale { get => _gravityScale; set => _gravityScale = value; }
        public float Mass { get => _mass; set => _mass = value; }
        public float Drag { get => _drag; set => _drag = value; }
        public Vector3 Position { get => _position; set => _position = value; }
        public bool UseGravity { get => _useGravity; set => _useGravity = value; }
        public bool IsKinematic { get => _isKinematic; set => _isKinematic = value; }
        public bool FreezRotation { get => _freezRotation; set => _freezRotation = value; }
        #endregion

        public Ridigbooty(GameObject gameObject)
        {
            Name = gameObject.Name;
            TransformP = gameObject.GetComponent<Transform>();
            BoxColliderP = gameObject.GetComponent<BoxCollider>();
        }

        #region Methods
        public void AddForce(Vector3 force)
        {/*
            //Apply a force to this Rigidbody in direction of this GameObjects up axis
            m_Rigidbody.AddForce(transform.up * m_Thrust);
        */}

        public void MovePosition(Vector3 position)
        {/*
            //Store user input as a movement vector
            Vector3 m_Input = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

            //Apply the movement vector to the current position, which is
            //multiplied by deltaTime and speed for a smooth MovePosition
            m_Rigidbody.MovePosition(transform.position + m_Input * Time.deltaTime * m_Speed);
        */}

        public void ApplyConstantForce(Vector3 vector3, float amount)
        {
            throw new System.NotImplementedException();
        }

        public void ApplyGravity()
        {
            //need to add another condition for checking collision from the bottom
            if (UseGravity)
                //need to happen on each update
                Position = new Vector3(Position.X, Position.Y - Physics.Gravity, Position.Z);
        }
        #endregion

        #region Overrides
        public override string ToString()
        {
            return $"Rigidbody of {Name}" + Environment.NewLine;
        }
        #endregion
    }
}