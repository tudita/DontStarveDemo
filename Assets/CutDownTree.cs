using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CutDownTree : MonoBehaviour, IPointerDownHandler
{
    private int ClickCount = 0;
    public GameObject trunk;
    public void OnPointerClick(PointerEventData eventData)
    {
    	//你要触发的代码
    }
    
    public void OnPointerDown(PointerEventData eventData)
    {
    	Debug.Log(ClickCount);
        ClickCount++;
    }
    void Update() {
        if(ClickCount >= 8) {
            Destroy(gameObject);
            Instantiate(trunk, transform.position + (new Vector3(0,1.2f,0)),transform.rotation);
        }    
    }
}