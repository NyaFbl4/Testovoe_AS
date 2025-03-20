using UnityEngine;

namespace Testovoe_AS
{
    public interface IMovementController
    {
        void Move(Vector3 direction);
        void UpdateGravity();
    }
}