using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveDataTower : BaseSaveData
{
    public List<Tower> towers = new List<Tower>();

    public override string getKey()
    {
        return "S_TowerData";
    }
    public override void LoadDefaulft()
    {
        towers = new List<Tower>();
    }
}
