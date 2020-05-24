using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuManager : MonoBehaviour
{
    public Image frontImp;
    public Image unlockablesMenu;
    public Image mainTittleText;
    public Text goldText;
    // Start is called before the first frame update
    void Start()
    {
        unlockablesMenu.gameObject.SetActive(false);
    }
    //Placeholder function
    public void KillImp()
    {

        if (frontImp.gameObject.activeInHierarchy)
        {
            frontImp.gameObject.SetActive(false);
        }
    }

        // Update is called once per frame
    void Update()
    {
        goldText.text = GoldManager.goldNum + "G";
    }
    //Helper Function. Use on other functions to clear screen
    public void EmptyMenu()
    {
        
        if (frontImp.gameObject.activeInHierarchy)
        {
            frontImp.gameObject.SetActive(false);
        }

        if (mainTittleText.gameObject.activeInHierarchy)
        {
            mainTittleText.gameObject.SetActive(false);
        }
    }

    public void UnlockablesMenu()
    {
        EmptyMenu();

        unlockablesMenu.gameObject.SetActive(true);
    }
}
