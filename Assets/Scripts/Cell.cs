using UnityEngine;
using UnityEngine.UI;

public class Cell : MonoBehaviour
{
    public enum MarkerTypes { None, Square, Circle, QuareNeg, CircleNeg };

    [Header("Cell Properties")]
    public bool isActive = false;
    public MarkerTypes marker;
    internal bool canBeToggled = true;
    internal Puzzle puzzle;

    private Image markerImage;
    private Image self;

    void Start()
    {
        self = GetComponent<Image>();
        markerImage = transform.Find("Marker").GetComponent<Image>();

        if (!isActive) self.color = GameManager.Instance.inactiveCell;
        switch (marker)
        {
            case MarkerTypes.Square:
                markerImage.sprite = GameManager.Instance.positiveSquare;
                break;
            case MarkerTypes.None:
            default:
                markerImage.color = GameManager.Instance.invisible;
                break;
        }
    }

    public void ToggleCell()
    {
        if (!puzzle.isActive) return;

        // Toggle off
        if (isActive) {
            self.color = GameManager.Instance.inactiveCell;
            isActive = false;
            return;   
        }

        // Toggle on
        self.color = GameManager.Instance.activeCell;
        isActive = true;
    }
}
