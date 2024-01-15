using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterController2D : MonoBehaviour
{
    [SerializeField] float primaryMoveSpeed;
    [SerializeField] Rigidbody2D rb;
    Vector2 move;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        
    }

    void OnMove(InputValue value)
    {
        move = value.Get<Vector2>();
        Debug.Log(move.normalized);
    }
}
