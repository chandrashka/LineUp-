using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class StartGame : MonoBehaviour
{
    private const int RowCount = 10;
    private const int CellsInRowCount = 9;

    [SerializeField] private GameObject _firstTilePrefab;
    [SerializeField] private GameObject _secondTilePrefab;

    [Space] [SerializeField] private GameObject _oneBlockPrefab;
    [SerializeField] private GameObject _twoBlockPrefab;
    [SerializeField] private GameObject _threeBlockPrefab;

    private GameObject _parent;

    private List<Cell> Cells = new();

    public void Start()
    {
        _parent = new GameObject("Grid");
        CreateGrid();
        Debug.Log("Grid created.");
        GenerateBricks();
    }

    private void CreateGrid()
    {
        for (var i = 0; i < RowCount; i++)
        {
            if (i % 2 == 0)
            {
                CreateFirstRow(i);
            }
            else
            {
                CreateSecondRow(i);
            }
        }
    }

    private void CreateFirstRow(int height)
    {
        for (var i = 0; i < CellsInRowCount; i++)
        {
            var cellGameObject = Instantiate(i % 2 == 0 ? _firstTilePrefab : _secondTilePrefab, new Vector3(i, height),
                Quaternion.identity, _parent.transform);
            var cell = new Cell { X = i, Y = height, CellObject = cellGameObject };
            Cells.Add(cell);
        }
    }

    private void CreateSecondRow(int height)
    {
        for (var i = 0; i < CellsInRowCount; i++)
        {
            var cellGameObject = Instantiate(i % 2 == 0 ? _secondTilePrefab : _firstTilePrefab, new Vector3(i, height),
                Quaternion.identity, _parent.transform);
            var cell = new Cell { X = i, Y = height, CellObject = cellGameObject };
            Cells.Add(cell);
        }
    }

    private void GenerateBricks()
    {
        int len = 0;
        List<int> possibleCells = new List<int> { 0, 1, 2, 3 };
        var random = new Random();
        while (len != CellsInRowCount)
        {
            var randValue = random.Next(0, 4);
            if (possibleCells[randValue] + len <= CellsInRowCount)
            {
                if (possibleCells[randValue] == 0)
                {
                    len++;
                }
                else
                {
                    len += possibleCells[randValue];
                }
                Debug.Log($"Cell with len {possibleCells[randValue]}");
            }
        }
    }
}