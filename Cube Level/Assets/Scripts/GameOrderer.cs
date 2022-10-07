using UnityEngine.SceneManagement;
using UnityEngine;

public class GameOrderer : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 1f;
    public GameObject completelevelUI;
    public void CompleteLevel ()
    {
        completelevelUI.SetActive(true);
    }
    public void endGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("GAME OVER! Better luck next time!");
            Invoke("restart", restartDelay);
        }
    }
    void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
