using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

    public class Slot : MonoBehaviour
{
	public Item slotItem;	//物品所对应的物品信息存储
	public Image slotImage;	//Slot对应的图片组件，引用以在之后对其进行修改
	public Text slotNum;	//Slot对应的标识物品数量的Text组件引用
}

