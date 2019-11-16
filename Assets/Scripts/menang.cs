using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menang : MonoBehaviour
{
    int sel = 0 ;
    int selesai = 0;
    void Update()
    {
        selesai = sel + Data.score;
        if (selesai > 29)
        {
            
            SceneManager.LoadScene("PlayMenang");
        }
    
    }
}
