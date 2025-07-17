using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] float _moveSpeed;
    [SerializeField] float _jumpForce;
    Rigidbody2D _rb;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();

    }
    void Update()
    {
        _moveSpeed = Input.GetAxisRaw("Horizontal");
        if (Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log("W‚ª‰Ÿ‚³‚ê‚½");
            _rb.AddForce(Vector2.up * _jumpForce, ForceMode2D.Force);
        }
    }
}

