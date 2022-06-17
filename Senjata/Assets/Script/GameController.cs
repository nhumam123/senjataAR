using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject CanvasGolok, CanvasKeris, CanvasKujang, CanvasRencong;

    public bool show = false;

    public void ShowHideInfo()
    {
        if(!show)
        {
            CanvasGolok.SetActive(true);
            CanvasKeris.SetActive(true);
            CanvasKujang.SetActive(true);
            CanvasRencong.SetActive(true);
            show = true;
        }
        else
        {
            CanvasGolok.SetActive(false);
            CanvasKeris.SetActive(false);
            CanvasKujang.SetActive(false);
            CanvasRencong.SetActive(false);
            show = false;
        }
    }
}
