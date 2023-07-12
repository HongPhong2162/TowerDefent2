using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveDataManager 
{

    public SaveDataTower dataTower = new SaveDataTower();

    private T LoadData<T>(T baseData) where T : BaseSaveData
    {
        string jsonData = PlayerPrefs.GetString(baseData.getKey());
        if (string.IsNullOrEmpty(jsonData))
        {
            baseData.LoadDefaulft();
        }
        else
        {
            baseData = JsonUtility.FromJson<T>(jsonData);
        }

        baseData.LoadAfter();
        return baseData;
    }

    public void Load()
    {
        dataTower = LoadData(dataTower);
    }


    public void setDataTower(List<Tower> data)
    {
        dataTower.towers = data;
        dataTower.SaveData();
    }



}
