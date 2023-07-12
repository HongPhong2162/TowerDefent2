using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerLogic : BasaLogic
{
     
    List<Tower> towers = new List<Tower>();
    public TowerLogic(TowerConfig dataConfig,SaveDataTower dataSave)
    {
        var data = dataConfig.Towers;

        if(dataSave.towers.Count != 0)
        {
            data = dataSave.towers;
        }
        towers = data;
               
    }





    public override bool save()
    {
        Debug.Log(towers.Count);
        var saveDataConTroler = getSaveDataManger();
        saveDataConTroler.setDataTower(towers);
        return true;
    }
}
