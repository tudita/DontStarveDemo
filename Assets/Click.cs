using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Click : MonoBehaviour, IPointerDownHandler
{
    private int ClickCount = 0;
    public void OnPointerClick(PointerEventData eventData)
    {
    	//你要触发的代码
    }
    
	//当检测到鼠标在该物体上有“按下”操作时，触发以下函数
    public void OnPointerDown(PointerEventData eventData)
    {
    	Debug.Log(ClickCount);
        ClickCount++;
    }
    void Update() {
        if(ClickCount >= 8) {
            Destroy(gameObject);
        }    
    }
}