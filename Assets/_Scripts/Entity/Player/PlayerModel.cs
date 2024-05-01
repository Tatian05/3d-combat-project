using UnityEngine;
public class PlayerModel
{
    #region Constructor

    Rigidbody _rb;
    int _walkSpeed, _runSpeed;

    #endregion

    public int CurrentSpeed { get; private set; }

    public PlayerModel(Rigidbody rb, int walkSpeed, int runSpeed)
    {
        _rb = rb;
        _walkSpeed = walkSpeed;
        _runSpeed = runSpeed;
    }
    public void Walk(float x, float z)
    {
        CurrentSpeed = _walkSpeed;
        float speed = z < 0 ? _walkSpeed * .5f : _walkSpeed;
        _rb.velocity = new Vector3(x,0, z) * speed;
    }

    public void Run(float x, float z)
    {
        CurrentSpeed = _runSpeed;
        float speed = z < 0 ? _runSpeed * .5f : _runSpeed;
        _rb.velocity = new Vector3(x, 0, z) * speed;
    }
}
