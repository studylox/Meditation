using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIFadeEffect : MonoBehaviour
{
    public GameObject uiElement;
    private CanvasGroup canvasGroup;
    public GameObject uiElement2;


    void Awake()
    {

        canvasGroup = uiElement.GetComponent<CanvasGroup>();
      
        if (canvasGroup == null)
        {
            canvasGroup = uiElement.AddComponent<CanvasGroup>();
       
        }

        canvasGroup.alpha = 0f;
    }
    void Start()
    {

        LeanTween.alphaCanvas(canvasGroup, 1f, 1f).setEase(LeanTweenType.easeInSine).setDelay(2.5f);

    }

    public void ChangeScene()
    {   LeanTween.alphaCanvas(canvasGroup, 0f, 1f).setEase(LeanTweenType.easeInOutSine).setDelay(1f);

        uiElement2.SetActive(true);
  
        canvasGroup = uiElement2.GetComponent<CanvasGroup>();
       
        LeanTween.alphaCanvas(canvasGroup, 1f, 1f).setEase(LeanTweenType.easeInSine).setDelay(2.5f);
        LeanTween.alphaCanvas(canvasGroup, 0f, 1f).setEase(LeanTweenType.easeInOutSine).setDelay(4.5f);
 StartCoroutine(hideMenue());
    }

   

IEnumerator hideMenue()
{
    yield return new WaitForSeconds(9.5f);
    uiElement2.SetActive(false);
        uiElement.SetActive(false);
}
}
