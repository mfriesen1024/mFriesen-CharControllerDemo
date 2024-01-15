using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterController2D : MonoBehaviour
{
    [SerializeField] float primaryMoveSpeed = 1;
    [SerializeField] Rigidbody2D rb;
    Vector2 move;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        Vector2 tempMove = move.normalized * Time.deltaTime * primaryMoveSpeed;
        float x = tempMove.x + transform.position.x;
        float y = tempMove.y + transform.position.y;
        tempMove = new Vector2(x, y);
        rb.MovePosition(tempMove);
    }

    void OnMove(InputValue value)
    {
        move = value.Get<Vector2>();
    }
}
