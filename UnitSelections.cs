
using System.Collections.Generic;
using UnityEngine;

public class UnitSelections : MonoBehaviour
{
    public List<GameObject> unitList = new List<GameObject>();
    public List<GameObject> unitsSelected = new List<GameObject>();


    private static UnitSelections _instance;
    public static UnitSelections Instance { get { return _instance; } }


    void Awake()
    {


        //if an instance of this already exists and isnt this one
        if(_instance != null && _instance != this)
        {
            //destroy this instance
            Destroy(this.gameObject);
        }
        else
        {
            //make this the instance
            _instance = this;
        }
    }

    public void ClickSelect(GameObject unitToAdd)
    {
        DeselectAll();
        unitsSelected.Add(unitToAdd);

    }

    public void ShiftClickSelect(GameObject unitToAdd)
    {
        if (!unitsSelected.Contains(unitToAdd))
        {
            unitsSelected.Add(unitToAdd);
        }
        else
        {
            unitsSelected.Remove(unitToAdd);
        }

    }

    public void DragSelect(GameObject unitToAdd)
    {

    }

    public void DeselectAll()
    {
        unitsSelected.Clear();
    }

    public void Deselect(GameObject unitToDeselect)
    {

    }


}
