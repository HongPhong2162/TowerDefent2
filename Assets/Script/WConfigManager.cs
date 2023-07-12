using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WConfigManager : SingletonMono<WConfigManager>
{
    [SerializeField] private TowerConfig DataConfig;


    public TowerConfig dataTowerConfig => DataConfig;

}
