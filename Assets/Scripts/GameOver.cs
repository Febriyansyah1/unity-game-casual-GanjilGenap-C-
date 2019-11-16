using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{

    float timer = 0;
    
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 8)
        {
            Data.score = 0;
            SceneManager.LoadScene("GameOver");
        }
    }
}