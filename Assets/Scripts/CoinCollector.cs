using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class CoinCollector : MonoBehaviour
{
    
    private bool collected = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ScoreManager scoreManager = other.GetComponent<ScoreManager>();
            
            if (scoreManager != null)
            {
                scoreManager.AddScore();
                if (scoreManager.score==12)
                {
                    Debug.Log("Oyuncu Kazandı");
                }
            }
            
            Destroy(gameObject);
            

        }
    }



}
