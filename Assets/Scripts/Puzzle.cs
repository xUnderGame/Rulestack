using UnityEngine;
using UnityEngine.UI;
using static Serializables;

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
                level.cells[rowCount].Add(cell.GetComponent<Cell>());
            }
            rowCount++;
        }
    }

    private void FixedUpdate()
    {
        if (!isActive) return;
        CheckCompletion();
    }

    // Checks if a level is completed, then disables itself.
    public bool CheckCompletion()
    {
        // complicated condition here
        // isActive = false;
        return true;
    }
}
