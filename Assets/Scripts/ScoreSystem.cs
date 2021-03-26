using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour

{
 
    public Text p1ScoreText;  
    public Text p2ScoreText;
    public static bool p1canSubtractLive = true;
    public static bool p1canAddLive = true;
    public static bool p2canSubtractLive = true;
    public static bool p2canAddLive = true;

    private int p1score;
    private int p2score;
    // Start is called before the first frame update

    public int p1LIVES
    {
        get { return p1score; }
        set
        {
            
            p1score = value;
            p1ScoreText.text = "PlayerPlant 1 Lives: " + p1score.ToString();
           
        }
    }   
    public int p2LIVES
    {
        get { return p2score; }
        set
        {
            
            p2score = value;
            p2ScoreText.text = "PlayerPlant 2 Lives: " + p2score.ToString();
            
        }
    }

    private void Awake()
    {
        p1LIVES = 5; 
        p2LIVES = 5;
    }
}

