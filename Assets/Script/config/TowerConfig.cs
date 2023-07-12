using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;




[Serializable]
public class Tower
{
    public string id;
    public float damage;
    public float price;
    public float speed;
    public TowerControler Prefabs;
    public bool isLock;
}



[CreateAssetMenu(fileName ="Tower",menuName ="towerConfig")]
public class TowerConfig : ScriptableObject
{
    public List<Tower> Towers;
}
