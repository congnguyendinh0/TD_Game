
using UnityEngine;

using UnityEngine.SceneManagement;
public class Manager : MonoBehaviour
{
    
    private bool _gameHasEnded;
    public GameObject gameOverScreen;
  
    void Start()
    {
        // game didnt end yet at start
        _gameHasEnded = false;
    }
    private void Update()
    {
        if (_gameHasEnded)
        {
            return ;
        }
    
        // end game when live <0 
        if (HealthCounter.Health <= 0)
        {
            Beenden();
        }
    }

    private void Beenden()
    {
        _gameHasEnded = true;
        // gameoverscreen is off first 
        gameOverScreen.SetActive(true);
   
    }

    // retry button at endscreen
    public void Retry()
    {
        // unfreeze
        Time.timeScale = 1f;
    
        // reload the scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
//Followed brackeys tutorial as allowed : https://www.youtube.com/watch?v=beuoNuK2tbk&list=PLPV2KyIb3jR4u5jX8za5iU1cqnQPmbzG0&index=1&ab_channel=Brackeys

