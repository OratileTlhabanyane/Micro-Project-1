using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerOneScript : MonoBehaviour
{

    public GameObject bacteria;
    public GameObject rainDrop;

    public float speed = 3f;
    private Rigidbody2D rb;


    [SerializeField] public ScoreSystem scoreSystem;
    // Start is called before the first frame update
    void Start()
    {
        ScoreSystem.p1canSubtractLive = true;
        rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))


        {

            rb.velocity = new Vector2(10f, 0);
            //we wanna set the velocity of the rb to its new vector in order for player 1 can move along the x and y-axis
        }
        else if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector2(-10f, 0);
        }

        else
        {
            rb.velocity = new Vector2(0f, 0f);
        }

    
}
    public void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(bacteria);

           ScoreSystem.p1canSubtractLive = true;
            scoreSystem.p1LIVES--;
            collision.gameObject.SetActive(false);
        }
        if(collision.gameObject.CompareTag("Rain"))
        {
            Destroy(rainDrop);

            ScoreSystem.p1canAddLive = true;
            scoreSystem.p1LIVES++;
            collision.gameObject.SetActive(false);
        }
        if (scoreSystem.p1LIVES <= 0)
        {
            SceneManager.LoadScene(3);
        }
        if (scoreSystem.p2LIVES <= 0)
        {
            SceneManager.LoadScene(4);
        }
    }
}