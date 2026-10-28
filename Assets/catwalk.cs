using UnityEngine;

public class catwalk : MonoBehaviour
{
    public Rigidbody2D RB;
    public float speed = 5;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 vel = new Vector2(0, 0);
        if (Input.GetKey(KeyCode.RightArrow))
        {
            vel.x = speed;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            vel.x = -speed;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            vel.y = speed;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            vel.y = -speed;
        }
        RB.linearVelocity = vel;
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        
            if (other.gameObject.CompareTag("Cat Food"))
            {
                Destroy(other.gameObject);
            }

        
    }
}
