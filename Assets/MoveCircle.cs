using UnityEngine;
using System.Collections;

public class MoveCircle : MonoBehaviour
{
    Rigidbody2D rb;

    [SerializeField] float period;
    [SerializeField] float speed;
    float timer = 0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate(){
        timer += Time.deltaTime;
        rb.AddForce(new Vector2(Mathf.Sin(timer), rb.linearVelocity.y) * speed);
        if(timer/period >= 1){
            rb.linearVelocity = new Vector2(0, rb.linearVelocity.y);
            speed *= -1;
            timer -= period;
            
        }
    }
}
