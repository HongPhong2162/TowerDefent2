using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseSaveData
{

    public abstract string getKey();
    public virtual void LoadDefaulft()
    {

    }
    public void SaveData()
    {
        var jsonData = JsonUtility.ToJson(this);
        PlayerPrefs.SetString(getKey(), jsonData);
        PlayerPrefs.Save();
    }
    public virtual void LoadAfter()
    {

    }




}
    

