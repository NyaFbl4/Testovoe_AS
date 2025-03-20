using UnityEngine;
using Zenject;

namespace Testovoe_AS
{
    public class InputSystem : MonoBehaviour
    {
        [SerializeField] private JoystickForMovement _joystick;
        [SerializeField] private PlayerMovementLogic _playerMovementLogic;
        [SerializeField] private FixedTouchField _fixedTouchField;
        [SerializeField] private CameraController _cameraController;

        
        public void Update()
        {
            MoveCharacter();
            //RotationCharacter();
        }

        private void MoveCharacter()
        {
            var moveDirection = _joystick.ReturnVectorDirection();
        
            _playerMovementLogic.Move(moveDirection);
        }

        private void RotationCharacter()
        {
            _cameraController.LockAxis = _fixedTouchField.TouchDist;
        }
    }
}