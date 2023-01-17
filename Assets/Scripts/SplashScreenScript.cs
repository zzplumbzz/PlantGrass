using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashScreenScript : MonoBehaviour
{
    public float timer = 3f;
    public bool timerOn;
    // Start is called before the first frame update
    void Start()
    {
        timerOn = true;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(timer);

        if(timerOn == true)
        {
            timer -= Time.deltaTime;
        }

        if( timer <= 0)
        {
            SceneManager.LoadScene("GameScene");
        }
    }
}
