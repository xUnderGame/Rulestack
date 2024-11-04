using UnityEngine;
using UnityEngine.UI;

public class Cell : MonoBehaviour
{
    [Header("Cell Properties")]
    public MarkerTypes marker;

    public enum MarkerTypes { None, Square, Circle, QuareNeg, CircleNeg };
    internal bool canBeToggled = true;
    internal bool isActive = false;
    private Image image;

    private void Awake()
    {
        image = GetComponent<Image>();
    }

    public void ToggleCell()
    {
        // Toggle off
        if (isActive) {
            image.color = GameManager.Instance.inactiveCell;
            isActive = false;
            return;   
        }

        // Toggle on
        image.color = GameManager.Instance.activeCell;
        isActive = true;
    }
}
