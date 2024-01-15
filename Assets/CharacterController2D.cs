using UnityEngine;

public class CharacterController2D : MonoBehaviour
{
    [SerializeField] float primaryMoveSpeed;
    [SerializeField] Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
}
