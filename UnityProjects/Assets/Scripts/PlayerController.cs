
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{

    private float auxDashCD;
    private Rigidbody2D rb2d;
    private int count;
    public int targetCount;
    public Text countText;
    public bool isGameOver = false;
    public float speed;
    public int dashForce;
    public float dashCD;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        auxDashCD = dashCD;
        this.count = 0;
        rb2d = GetComponent<Rigidbody2D>();
        SetCountText();

    }

    // Update is called once per frame
    private void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(moveHorizontal, moveVertical);

        rb2d.AddForce(movement * speed);

        if (auxDashCD <= 0)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rb2d.AddForce(movement * dashForce, ForceMode2D.Impulse);
                auxDashCD = dashCD;
            }
        }
        else
        {
            auxDashCD -= Time.deltaTime;
        }
        if (count >= targetCount)
        {
            SceneManager.LoadScene("GameOver");
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        switch (other.gameObject.tag)
        {
            case "Hurts":
                // Restart the scene
                gameObject.SetActive(false);
                gameObject.GetComponent<Collider2D>().enabled = false;
                isGameOver = true;
                SceneManager.LoadScene("GameOver");
                break;
            case "PickUp":
                other.gameObject.SetActive(false);
                other.gameObject.GetComponent<Collider2D>().enabled = false;
                // Reset the dash cooldown
                if (other.gameObject.GetComponent<ClassInfo>().className == "BigCoin")
                {
                    auxDashCD = 0;
                }
                // Update the count
                this.count = this.count + other.gameObject.GetComponent<ClassInfo>().getValue();
                Debug.Log("Count: " + this.count);
                SetCountText();
                break;
            default:
                break;
        }
    }
    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
    }
}
