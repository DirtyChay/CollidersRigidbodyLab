using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    Rigidbody2D rb;

    [SerializeField][Tooltip("How far until object tries to go the other way.")]
    public float radius=1;

    [SerializeField] [Tooltip("How much force at each step.")]
    public Vector2 movement;

    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    
    void Update() {
        var velocity_x = rb.velocity.x;
        var velocity_y = rb.velocity.y;

        if (Mathf.Abs(velocity_x) > radius) {
            movement.x = movement.x * -1;
        }
        
        if (Mathf.Abs(velocity_y) > radius) {
            movement.y = movement.y * -1;
        }
        
        rb.velocity += movement * Time.fixedDeltaTime;

    }
}
