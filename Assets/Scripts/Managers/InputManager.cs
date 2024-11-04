using UnityEngine;

public class InputManager : MonoBehaviour
{
    [HideInInspector] public static InputManager Instance;

    void Awake()
    {
        // 
        if (Instance) { Destroy(gameObject); return; }
        else Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    private void OnTest()
    {
        Debug.LogWarning("hiiiiiiiiiii");
    }
}
