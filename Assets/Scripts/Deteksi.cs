using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Deteksi : MonoBehaviour
{
    public string nameTag;
    
   
    public Text textScore;

    
    void Start()
    {
        
    }
    
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals(nameTag))
        {
            Data.score += 10;
            textScore.text = Data.score.ToString();
            Destroy(collision.gameObject);
        }
        else
        {
            Data.score -= 5;
            textScore.text = Data.score.ToString();
            Destroy(collision.gameObject);
        }
    }
}