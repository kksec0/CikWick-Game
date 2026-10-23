using UnityEngine;
using UnityEngine.SceneManagement;

public class Respawn : MonoBehaviour
{
    private Vector3 startPosition;
    void Start()
    {
        startPosition = transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -10f)
        {
          transform.position = startPosition;
          ScoreManager scoreManager = GetComponent<ScoreManager>();
          scoreManager.score = 0;
          SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
          Debug.Log("oyuncu düştü ve oyun yeniden başladı skor sıfırlandı"); 
        }
        
    }
}
