using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScript : MonoBehaviour
{
    public void StartMethod()
    {
        SceneManager.LoadScene("MainScene", LoadSceneMode.Single);
    }
}
