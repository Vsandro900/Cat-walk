using UnityEngine;

public class Hazard : MonoBehaviour
{
    public bool isMovingLeft = true;
    public bool isMovingUp = true;
  
    public int boundX = 5;
    public int boundY = 5;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = transform.position.x;
        float moveY = transform.position.y;
        if (isMovingLeft)
        {
            moveX -= 1 * Time.deltaTime;
        }
        else //otherwise
        {
            //move right.
            moveX += 1 * Time.deltaTime;
        }

        if (moveX <= -boundX)
        {
            isMovingLeft = false;

        }
        else if (moveX >= boundX)
        {
            isMovingLeft = true;
        }
       
        if(isMovingUp)
        {
            moveY += 1 * Time.deltaTime; 
        }
        else
        {
            moveY -= 1 * Time.deltaTime;
        }
        transform.position = new Vector2(moveX, moveY);
        

    }
}
