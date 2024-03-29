﻿
using UnityEngine;

public class Cell {

    public Vector3 worldPos;
    public Vector2Int gridIndex;
    public byte cost;
    public ushort bestCost;

    public bool occupied;

    public GridDirection bestDirection;

    public Cell(Vector3 _worldPos, Vector2Int _gridIndex) {
        worldPos = _worldPos;
        gridIndex = _gridIndex;
        cost = 1;
        bestCost = ushort.MaxValue;
        bestDirection = GridDirection.None;
        occupied = false;

    }

    public void increaseCost(int amount) {

        if (cost == byte.MaxValue) { return; }

        if (amount + cost > 255) { cost = byte.MaxValue; }
        else { cost += (byte) amount; }
    
    
    
    
    }


}
