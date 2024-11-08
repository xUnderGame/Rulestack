using UnityEngine;

public class GameManager : MonoBehaviour
{
    [HideInInspector] public static GameManager Instance;

    public Sprite positiveSquare;
    public Sprite positiveCircle;
    public Color inactiveCell;
    public Color activeCell;
    public Color invisible;

    void Awake()
    {
        // Persistence
        if (Instance) { Destroy(gameObject); return; }
        else Instance = this;
        DontDestroyOnLoad(gameObject);

        // References
        positiveSquare = Resources.Load<Sprite>("Sprites/Markers/Positive Square Marker");
        positiveCircle = Resources.Load<Sprite>("Sprites/Markers/Positive Circle Marker");

        ColorUtility.TryParseHtmlString("#c9814b", out inactiveCell);
        ColorUtility.TryParseHtmlString("#dda963", out activeCell);
        invisible = new Color(1, 1, 1, 0);
    }
}
