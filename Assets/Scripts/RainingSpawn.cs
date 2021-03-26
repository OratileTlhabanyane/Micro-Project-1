using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainingSpawn : MonoBehaviour
{
    public GameObject rainPrefab;
    public float respawnTime = 10f; //this time will tell us how often do we want to spawn the bacteria
    // Start is called before the first frame update

    public Vector2 screenBounds;
    void Start()
    {
        //2. We then need to move the prefab to start all the way from the top of the screen so we need to calculate the screen again
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height * -1, Camera.main.transform.position.z));
        StartCoroutine(rainFall());
    }
    private void spawnRaindrops()
    {
        //1. Using Instatiate to load prefab onto the scene
        GameObject b = Instantiate(rainPrefab) as GameObject;

        //3. then we going to use the screen calculation and manioulate/modify the  b value (the bacteria)'s position
        b.transform.position = new Vector2(Random.Range(screenBounds.x, -screenBounds.y * 2), screenBounds.y * -2);
    }//      here we are placing the x value randomly^             ^here we are placing the bacteria's y value waayy above the screen    



    //4. We going to use Coroutine to call out when the script can start spawning bacteria
    IEnumerator rainFall()
    {
        //5. we going to create either a while loop or boolen so that we can tell the script to spawn the bacteria at what time 
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnRaindrops(); //4.
        }

    }
}
