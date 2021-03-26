using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BacteriaScript : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D rb;

    

    //we going to use Screenbounds to make sure that once object has left the scene it gets destroyed
    private Vector2 screenBounds;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
       
        rb.velocity = new Vector2(0, -speed); //this will move the bacteria from right to left consistently on the speed 5

        //call out each side of the screen x,y,z
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height * -1, Camera.main.transform.position.z));
    }

    // Update is called once per frame
    void Update()
    {
        //check if bacteria is less than the screen's y value, basically is bacteria moving down and if out of the screen then destroy it 
        if (transform.position.y < screenBounds.y * 2)
        {

            Destroy(gameObject);

        }
    }

}
