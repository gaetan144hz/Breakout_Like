using UnityEngine;
using TMPro;

public class Disque : MonoBehaviour
{
    [SerializeField] public int currentScore;
    private int startScore;
    private int lastScore;
    
    [SerializeField] float speed;

    private Rigidbody2D rb;

    Vector3 lastVelocity;

    public TextMeshProUGUI scoreText;

    // Start is called before the first frame update
    void Awake()
    {
        rb = this.GetComponent<Rigidbody2D>();

        var num = Random.Range(1, 10);
        Vector3 moveDir = new Vector3(num, num).normalized;
        rb.velocity = moveDir * speed;
    }

    void Update()
    {
        lastVelocity = rb.velocity;
        lastScore = currentScore;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) //&& collision.gameObject.CompareTag("Disque")
        {
            var speed = lastVelocity.magnitude;
            var direction = Vector3.Reflect(lastVelocity.normalized, collision.contacts[0].normal);

            rb.velocity = direction * Mathf.Max(speed, 0f);
        }
        if (collision.gameObject.CompareTag("Brique")) 
        {
            var speed = lastVelocity.magnitude;
            var direction = Vector3.Reflect(lastVelocity.normalized, collision.contacts[0].normal);

            currentScore = lastScore + 1;
            scoreText.text = currentScore.ToString();

            rb.velocity = direction * Mathf.Max(speed, 0f);
        }
    }
}
