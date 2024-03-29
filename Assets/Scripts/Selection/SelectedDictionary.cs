﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectedDictionary : MonoBehaviour{

    public Dictionary<int, GameObject> selectedTable = new Dictionary<int, GameObject>();

    public void addSelected(GameObject go) {

        int id = go.GetInstanceID();

        if (!(selectedTable.ContainsKey(id))) {

            selectedTable.Add(id, go);
            //go.AddComponent<SelectionComponent>();
        
        }
    
    }

    public void deselect(int id) {

        //Destroy(selectedTable[id].GetComponent<SelectionComponent>());
        selectedTable.Remove(id);
    }

    public void deselectAll() {

        foreach (KeyValuePair<int, GameObject> pair in selectedTable) {

            if (pair.Value != null) {

                Destroy(selectedTable[pair.Key].GetComponent<SelectionComponent>());

            }
        
        
        }

        selectedTable.Clear();
       
    }

    public Dictionary<int, GameObject> getDictionary() {
        return selectedTable;

    }

   
}
