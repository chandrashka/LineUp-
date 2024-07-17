using UnityEngine;

public class StartGame : MonoBehaviour
{
    [SerializeField] private GameObject _firstTilePrefab;
    [SerializeField] private GameObject _secondTilePrefab;

    private GameObject _parent;

    public void Start()
    {
        _parent = new GameObject("Grid");
        CreateGrid();
    }

    private void CreateGrid()
    {
        for (int i = 0; i < 10; i++)
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
        for (var i = 0; i < 9; i++)
        {
            Instantiate(i % 2 == 0 ? _firstTilePrefab : _secondTilePrefab, new Vector3(i, height), Quaternion.identity, _parent.transform);
        }
    }

    private void CreateSecondRow(int height)
    {
        for (var i = 0; i < 9; i++)
        {
            Instantiate(i % 2 == 0 ? _secondTilePrefab : _firstTilePrefab, new Vector3(i, height), Quaternion.identity, _parent.transform);
        }
    }
}