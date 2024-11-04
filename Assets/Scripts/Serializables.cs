using System.Collections.Generic;
using UnityEngine;

public class Serializables
{
    internal class Level
    {
        internal readonly List<List<Cell>> cells = new();

        // Prints an output of the current level cells
        public void PrintLevel()
        {
            foreach (var row in cells)
            {
                Debug.Log("\nROW:");
                foreach (var cell in row)
                {
                    Debug.Log($"{cell.name}");
                }
            }
        }
    }    
}