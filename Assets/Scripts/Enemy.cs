using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 2f;
    public int health = 100;
    public string enemyType = "Base";

    void Start()
    {
        Debug.Log($"[{enemyType}] Enemy spawned! Speed={speed}, HP={health}");
    }

    void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);

        if (transform.position.y < -6f)
        {
            Destroy(gameObject);
        }
    }
}