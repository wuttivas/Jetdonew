using UnityEngine;
using UnityEngine.SceneManagement;

public class Warper : MonoBehaviour
{
    public SceneController.AllScene allScene;

    void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(allScene.ToString());
    }
}
