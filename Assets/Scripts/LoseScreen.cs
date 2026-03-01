using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseScreen : MonoBehaviour
{
    public void TryAgain()
    {
        SceneManager.LoadScene("Game");
    }
}
