using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : SingletonMono<GameManager>
{
    // Start is called before the first frame update

    [SerializeField] private Button btnsave;
    void Start()
    {
        btnsave.onClick.AddListener(testSave);
        Init();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public async void Init()
    {
        Debug.Log("Init");
        Logic.Instance.Init();
    }


    public void testSave()
    {
        Logic.Instance.towerLogic.save();
    }

}
