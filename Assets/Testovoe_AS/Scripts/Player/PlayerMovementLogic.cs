using UnityEngine;
using Zenject;

namespace Testovoe_AS
{
    public class PlayerMovementLogic : MonoBehaviour, IMovementController
    {
        [SerializeField] private  Transform _playerTransform;
        [SerializeField] private  CharacterController _characterController;
        [SerializeField] private  float _moveSpeed;
        [SerializeField] private  float _gravityForce;

        private float _currentAttractionPlayer;

        private void Start()
        {
            //_moveSpeed = config.MoveSpeed;
            //_gravityForce = config.GravityForce;
        }
        
        /*
        [Inject]
        public void Construct(Transform playerTransform, CharacterController characterController, PlayerConfig config)
        {
            _playerTransform = playerTransform;
            _characterController = characterController;
            _moveSpeed = config.MoveSpeed;
            _gravityForce = config.GravityForce;
        }
        */

        public void Move(Vector3 moveDirection)
        {
            moveDirection = _playerTransform.TransformDirection(moveDirection);
            moveDirection *= _moveSpeed;
            moveDirection.y = _currentAttractionPlayer;
            _characterController.Move(moveDirection * Time.deltaTime);
        }

        public void UpdateGravity()
        {
            if (!_characterController.isGrounded)
            {
                _currentAttractionPlayer -= _gravityForce * Time.deltaTime;
            }
            else
            {
                _currentAttractionPlayer = 0;
            }
        }
    }
}