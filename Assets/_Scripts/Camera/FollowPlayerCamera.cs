using UnityEngine;

namespace Camera
{
    public class FollowPlayerCamera : MonoBehaviour
    {
        [SerializeField] Transform _player;
        [SerializeField] Vector3 _distance = new Vector3(0, -10, 15);
        [SerializeField] float _smoothCamera, _maxSpeed;

        Vector3 _currentVelocity;

        private void Start()
        {
            transform.position = _player.position - _distance;      
        }
        void LateUpdate()
        {;
            transform.position = Vector3.SmoothDamp(transform.position, _player.position - _distance, ref _currentVelocity, _smoothCamera, _maxSpeed);
        }
    }
}
