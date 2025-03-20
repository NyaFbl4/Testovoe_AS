using System;
using UnityEngine;

namespace Testovoe_AS
{
    [Serializable]
    public class PlayerConfig
    {
        [SerializeField] private float _moveSpeed;
        [SerializeField] private float _gravityForce;

        public float MoveSpeed => _moveSpeed;
        public float GravityForce => _gravityForce;
    }
}