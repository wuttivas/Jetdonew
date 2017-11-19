using UnityEngine;

public class SceneController : MonoBehaviour
{
    public enum AllScene { CharacterTesting, WorldMap };
    public static SceneController Instance;

    void Awake()
    {
        Instance = this;
    }
}
