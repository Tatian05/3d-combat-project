using UnityEngine;
public class PlayerModel
{
    #region Constructor

    Transform _transform;
    Rigidbody _rb;
    int _walkSpeed, _runSpeed;

    #endregion

    Vector3 _movementDirection;
    Camera _camera;
    float _movementSpeed, _currentSpeed;
    public PlayerModel(Transform transform, Rigidbody rb, int walkSpeed, int runSpeed)
    {
        _transform = transform;
        _rb = rb;
        _walkSpeed = walkSpeed;
        _runSpeed = runSpeed;

        _camera = Helpers.MainCamera;
        _currentSpeed = _walkSpeed;
    }

    public void OnUpdate(float x, float z)
    {
        _movementDirection = Quaternion.AngleAxis(_camera.transform.rotation.eulerAngles.y, Vector3.up) * new Vector3(x, 0, z);
        _movementSpeed = z < 0 ? _currentSpeed * .5f : _currentSpeed;
        if (_movementDirection != Vector3.zero) _transform.forward = _movementDirection * Mathf.Sign(z);
    }

    public void OnFixedUpdate()
    {
        Movement();
    }

    void Movement()
    {
        _rb.velocity = _movementDirection * _movementSpeed;
    }
    public void SetCurrentSpeed(bool isRunning)
    {
        _currentSpeed = isRunning ? _runSpeed : _walkSpeed;
    }
}
