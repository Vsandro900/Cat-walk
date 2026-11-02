using UnityEngine;

public class Coin : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void GetBumped()
    {
        Destroy(gameObject);

        //Respawn
        float randomX = Random.Range(-5f, 5f);
        float randomY = Random.Range(-1.5f, 1.5f);

        //teleport the cat food (coin) to a random place more score
        transform.position =new Vector2 (randomX, randomY);
    }
}
