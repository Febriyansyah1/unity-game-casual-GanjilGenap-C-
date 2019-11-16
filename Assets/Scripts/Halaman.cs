using UnityEngine;
using UnityEngine.SceneManagement;

public class Halaman : MonoBehaviour
{
    public bool isEscapeToExit;
    // Use this for initialization
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            if (isEscapeToExit)
            {
                Application.Quit();
            }
            else
            {
                KembaliKeMenu();
            }
        }
    }
    public void MulaiPermainan()
    {
        Data.score = 0;
        SceneManager.LoadScene("GamePlay");
    }
    public void KembaliKeMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void Credit()
    {
        SceneManager.LoadScene("Credit");
    }
    public void HalKeluar()
    {
        SceneManager.LoadScene("Keluar");
    }
    public void Keluarapp()
    {
       Application.Quit();
    }
     
}
