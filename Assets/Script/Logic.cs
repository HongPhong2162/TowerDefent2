using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public abstract class BasaLogic
{
    public Func<SaveDataManager> getSaveDataManger;

    public abstract bool save();

}

public class Logic : Singleton<Logic>
{
    public SaveDataManager saveDataManager;
    public TowerLogic towerLogic { get; private set; }

    public void Init()
    {
        saveDataManager = new SaveDataManager();
        saveDataManager.Load();

        towerLogic = new TowerLogic(WConfigManager.Instance.dataTowerConfig, saveDataManager.dataTower);
        towerLogic.getSaveDataManger = () => saveDataManager;
    }
}
