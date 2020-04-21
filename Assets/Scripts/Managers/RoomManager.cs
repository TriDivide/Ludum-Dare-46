using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomManager : MonoBehaviour {

    [SerializeField]
    private IntVector2 coordinates;

    [SerializeField]
    private GameObject roomCellPrefab;

    private GameObject[,] roomCells;


    void Start() {
        
        for (int x = 0; x < coordinates.z; x++) {
            for (int z = 0; z < coordinates.x; z++) {
                GameObject cell = Instantiate(roomCellPrefab);
                roomCells[x, z] = cell;
                cell.transform.parent = transform;
                cell.transform.localPosition = new Vector3(x - coordinates.x * 0.5f + 0.5f, 0f, z - coordinates.z * 0.5f + 0.5f);
                cell.name = "Cell " + x + ", " + z;

                IntVector2 coordinate = new IntVector2(x, z);
                RoomCell cellConfig = cell.GetComponent(typeof(RoomCell)) as RoomCell;
                cellConfig.coordinates = coordinate;
        }
        }
    }


}
