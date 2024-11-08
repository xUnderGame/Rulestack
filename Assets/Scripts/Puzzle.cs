using UnityEngine;
using UnityEngine.UI;
using static Serializables;
using static Cell;

public class Puzzle : MonoBehaviour
{
    public string puzzleName = "Puzzle!";
    public Puzzle nextPuzzle = null;

    public bool isActive = false;

    private Level level = new();

    private void Awake()
    {
        // Set puzzle name
        transform.Find("Title").GetComponent<Text>().text = puzzleName;

        // Get the puzzle cells
        int rowCount = 0;
        foreach (Transform row in transform.Find("Panels"))
        {
            level.cells.Add(new());
            foreach (Transform cell in row.transform)
            {
                Cell comp = cell.GetComponent<Cell>();
                level.cells[rowCount].Add(comp);
                comp.puzzle = this;
            }
            rowCount++;
        }
    }

    private void FixedUpdate()
    {
        if (!isActive) return;
        ParseLevel();
    }

    // Checks if a level is completed, then disables itself.
    public bool ParseLevel()
    {
        bool winCondition = true;
        for (int row = 0; row < level.cells.Count; row++)
        {
            for (int i = 0; i < level.cells[row].Count; i++)
            {
                Cell cell = level.cells[row][i];
                switch (cell.marker)
                {
                    case MarkerTypes.Square:
                        if (!cell.isActive) winCondition = false;
                        break;
                    case MarkerTypes.None:
                    default:
                        break;
                }
            }
        }
        // complicated condition here
        if (winCondition) isActive = false;
        return winCondition;
    }
}
