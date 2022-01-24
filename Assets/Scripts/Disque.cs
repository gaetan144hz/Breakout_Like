using UnityEngine;
using TMPro;

public class Disque : MonoBehaviour
{
    [SerializeField] public int currentScore;
    private int lastScore;
    
    [SerializeField] float currentSpeed;
    [SerializeField] private float lastSpeed;

    public GameObject gameOverScreen;
    
    private Rigidbody2D rb;

    Vector3 lastVelocity;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highScore;

    // Start is called before the first frame update
    void Awake()
    {
        rb = this.GetComponent<Rigidbody2D>();

        var num1 = Random.Range(1, 10);
        //var num2 = Random.Range(10, 20);
        Vector3 moveDir = new Vector3(num1, num1).normalized;
        rb.velocity = moveDir * currentSpeed;
        Debug.Log(num1);
        //Debug.Log(num2);
    }

    void Update()
    {
        lastVelocity = rb.velocity;
        lastScore = currentScore;
        lastSpeed = currentSpeed;
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

            currentSpeed = lastSpeed ++;
            currentScore = lastScore + 1;
            scoreText.text = currentScore.ToString();
            scoreText.text = currentScore.ToString();

            rb.velocity = direction * Mathf.Max(speed, 0f);
        }

        if (collision.gameObject.CompareTag("DeathZone"))
        {
            Destroy(this.gameObject);
            gameOverScreen.SetActive(true);
        }
    }
}
