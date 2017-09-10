using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleSceneController : MonoBehaviour
{
    public int gridRows = 8;
    public int gridColumns = 8;
    public GameObject gridGameObject;
    public Transform firstCreateGridPosition;
    public Transform gridParent;
    public GameObject[] allCharacter;
    public List<GridPosition> allGrid = new List<GridPosition>();

    public struct GridPosition
    {
        public int myRow;
        public int myColumn;
        public GameObject myGameObject;

        public bool getGridPosition(int inputRow, int inputColumn)
        {
            if (inputRow == myRow && inputColumn == myColumn)
                return true;
            return false;
        }
    }

    void Start()
    {
        Init();
    }

    void Update()
    {

    }

    public void Init()
    {
        GridGenerator();
        CharacterInserter(0, 0, 0);
    }

    public void GridGenerator()
    {
        //Grid generator
        for (int i = 0; i < gridRows; i++)
        {
            for (int j = 0; j < gridColumns; j++)
            {
                GameObject newGridGameObject = Instantiate(gridGameObject, firstCreateGridPosition.transform.position, Quaternion.identity);
                newGridGameObject.transform.Translate(Vector3.right * j);
                newGridGameObject.transform.Translate(Vector3.forward * i);
                newGridGameObject.transform.SetParent(gridParent);
                GridPosition newGridPosition = new GridPosition();
                newGridPosition.myRow = i;
                newGridPosition.myColumn = j;
                newGridPosition.myGameObject = newGridGameObject;
                allGrid.Add(newGridPosition);
            }
        }
    }

    public void CharacterInserter(int inputRow, int inputColumn, int inputCharacter)
    {
        //Character inserter
        for (int i = 0; i < allGrid.Count; i++)
        {
            if (allGrid[i].getGridPosition(inputRow, inputColumn))
            {
                GameObject newCharacterGameObject = Instantiate(allCharacter[inputCharacter], allGrid[i].myGameObject.transform.position, Quaternion.identity);
                break;
            }
        }
    }
}
