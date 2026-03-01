using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void LoseGame()
    {
        SceneManager.LoadScene("LoseScene");
    }

    public void WinGame()
    {
        SceneManager.LoadScene("WinScene");
    }
}