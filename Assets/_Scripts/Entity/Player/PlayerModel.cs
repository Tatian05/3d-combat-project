using UnityEngine;
public class PlayerModel
{
    #region Constructor

    Transform _transform;
    Rigidbody _rb;
    float _acceleration;

    #endregion

    Vector3 _movementDirection;
    Camera _camera;
    float _movementSpeed, _currentSpeed;
    bool _isBlocking;
    public PlayerModel(Transform transform, Rigidbody rb, float acceleration)
    {
        _transform = transform;
        _rb = rb;
        _acceleration = acceleration;

        _camera = Helpers.MainCamera;
    }

    Vector3 _currentVelocity, _desiredVelocity;

    public void MovementUpdate(float x, float z)
    {
        _movementSpeed = z < 0 ? _currentSpeed * .5f : _currentSpeed;

        _movementDirection = Quaternion.AngleAxis(_camera.transform.rotation.eulerAngles.y, Vector3.up) * (new Vector3(x, 0, z) * _movementSpeed);
        _desiredVelocity = (_movementDirection - _rb.velocity) * _acceleration;

        if (_movementDirection != Vector3.zero)
            _transform.forward = Vector3.SmoothDamp(_transform.forward, _isBlocking ? new Vector3(_camera.transform.forward.x, 0, _camera.transform.forward.z) : _movementDirection * Mathf.Sign(z), ref _currentVelocity, .1f, 30);
    }

    public void MovementFixedUpdate()
    {
        _rb.AddForce(_desiredVelocity, ForceMode.VelocityChange);
        //_rb.velocity = _desiredVelocity;
    }

    public void Blocking(bool isBlocking)
    {
        _isBlocking = isBlocking;
    }

    public void SetCurrentSpeed(int speed) { _currentSpeed = speed; }
}
