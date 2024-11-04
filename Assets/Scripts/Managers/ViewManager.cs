using UnityEngine;
using UnityEngine.SceneManagement;

public class ViewManager : MonoBehaviour
{
    [HideInInspector] public static ViewManager Instance;

    void Awake()
    {
        // Persistence
        if (Instance) { Destroy(gameObject); return; }
        else Instance = this;
        DontDestroyOnLoad(gameObject);

        ChangeScene("Game");
    }

    // Change scenes
    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
