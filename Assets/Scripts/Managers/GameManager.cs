using UnityEngine;

public class GameManager : MonoBehaviour
{
    [HideInInspector] public static GameManager Instance;
    public Color inactiveCell;
    public Color activeCell;

    void Awake()
    {
        // Persistence
        if (Instance) { Destroy(gameObject); return; }
        else Instance = this;
        DontDestroyOnLoad(gameObject);
    
        // References
        ColorUtility.TryParseHtmlString("#dda963", out inactiveCell);
        ColorUtility.TryParseHtmlString("#c9814b", out activeCell);
    }
}
