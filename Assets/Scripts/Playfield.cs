using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playfield : MonoBehaviour
{

    public int FieldWidth { get; private set; }
    GameObject[,] cells;

    void Start()
    {
        Init();
    }

    void Init()
    {
        FieldWidth = FieldConfig.FieldWidth;
        cells = new GameObject[FieldWidth, FieldWidth];

        var initialOffset = FieldWidth / 2f;
        var initialPos = new Vector3(-initialOffset, 0f, -initialOffset);
        var rnd = new System.Random();

        for (short i = 0; i < FieldWidth; i++)
        {
            for (short j = 0; j < FieldWidth; j++)
            {
                var cellGO = cells[i, j] = Instantiate(CellConfig.Prefab);
				cellGO.transform.position = initialPos + new Vector3(1.1f * i, 0f, 1.1f * j);
				cellGO.transform.parent = gameObject.transform;

				Cell cell = cellGO.GetComponent<Cell>();
                CellState state;
                
                switch (rnd.Next(0, 5))
                {
                    case 0:
                        state = CellState.LEFT;
                        break;
                    case 1:
                        state = CellState.UP;
                        break;
                    case 2:
                        state = CellState.RIGHT;
                        break;
                    case 3:
                        state = CellState.DOWN;
                        break;
                    default: state = CellState.LEFT;
                        break;
                }

                cell.State = state;
            }
        }
    }
}
