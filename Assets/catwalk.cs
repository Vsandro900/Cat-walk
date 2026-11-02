using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class catwalk : MonoBehaviour
{
    public Rigidbody2D RB;

    public TextMeshProUGUI ScoreText;

    public float speed = 5;

    public int Score = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UpdateScore();
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

   void OnTriggerEnter2D(Collider2D other) 
   {
        
        Coin coin = other.gameObject.GetComponent<Coin>();
        if (coin != null)
        {
            coin.GetBumped();
            Score++;
            UpdateScore();

            if (Score >= 1)
            {
                SceneManager.LoadScene("Level Two");
            }
        }

        if (other.gameObject.CompareTag("Enemy"))
        {
            // Restart Level
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            // message
            Debug.Log("You Died");  
        }
    }
    public void UpdateScore()
    {
        ScoreText.text = "Score: " + Score;
    }

}
