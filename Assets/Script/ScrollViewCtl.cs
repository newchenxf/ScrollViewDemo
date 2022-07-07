using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollViewCtl : BaseUIController
{
    private GameObject TitleBuyButton;
    private GameObject TitleName;

    public float HideFactor = 0.3f;
    // Start is called before the first frame update
    void Start()
    {
        TitleBuyButton = findObjectByPath("TitleBuyButton");
        TitleName = findObjectByPath("TitleName");
        //findObjectByPath("Scroll View").GetComponent<ScrollRect>().onValueChanged.AddListener(OnValueChange);

    }

    public void OnValueChange(Vector2 value)
    {
        Debug.Log("OnValueChange " + value);
        if(value.y < HideFactor)
        {
            TitleName.GetComponent<Text>().text = "欢迎光临请选择商品";
            TitleBuyButton.SetActive(true);
        } else
        {
            TitleName.GetComponent<Text>().text = "我是标题";
            TitleBuyButton.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
