using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersistentData : MonoBehaviour
{
    [SerializeField] int playerMoney;
    [SerializeField] string playerName;
    const int playerMoneyStart = 1000;

    public static PersistentData Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            DontDestroyOnLoad(this);
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        playerMoney = 1000;
        playerName = "";

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SetName(string s)
    {
        playerName = s;
    }

   /* public void SubtractMoney(int m)
    {
        playerMoney -= m;
    }
    public void AddMoney(int m)
    {
        playerMoney += m;
    }*/
    public void SetMoney(int m)
    {
        playerMoney = m;
    }

    public string GetName()
    {
        return playerName;
    }

    public int GetMoney()
    {
        return playerMoney;
    }
}
