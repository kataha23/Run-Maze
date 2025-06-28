using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public List<ExitItem> exitItems = new List<ExitItem>();
    public List<GameObject> LockedWall = new List<GameObject>();

    private void Start()
    {
        Instance = this;
    }


    public bool CanExit = false;
    public TextMeshProUGUI getItemList;
    public TextMeshProUGUI openDoor;

    public void UpdateItem()
    {
        getItemList.text = "»πµÊ«— æ∆¿Ã≈€ : ";
        for(int i=0; i < exitItems.Count; i++)
        {
            if (exitItems[i].IsActivate == true)
            {
                getItemList.text += exitItems[i].Itemname;
                getItemList.text += " ";
            }
        }
    } 

    public bool GetAllKey()
    {
        for (int i = 0; i < exitItems.Count; i++)
        {
            if(exitItems[i].IsActivate == false)
            {
                return false;
            }
            CanExit = true;
        }
        return true;
    }

    public void GetKey()
    {
        UpdateItem();
        CanExit = GetAllKey();

        if(CanExit)
        {
            foreach (GameObject g in LockedWall)
              g.SetActive(false);

            openDoor.text = "≈ª√‚±∏∞° ø≠∑»Ω¿¥œ¥Ÿ.";
        }


    }
}
