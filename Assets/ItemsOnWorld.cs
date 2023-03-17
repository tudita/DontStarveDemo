using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections.Generic;
using System.Collections;

public class ItemsOnWorld : MonoBehaviour, IPointerDownHandler
{
    public Item thisItem;					//素材所属的Item(物品配置文件)
	public Inventory thisInventory;			//素材所属的Inventory(背包配置文件)
    public void OnPointerDown(PointerEventData eventData)
    {
        AddNewItem();//将物品添加到指定物品栏
		Destroy(gameObject);//在场景中摧毁物品
    }
	public void AddNewItem()//将物品添加到指定物品栏
	{
		if (!thisInventory.Items.Contains(thisItem))//若指定物品栏中尚未存放该物品
		{
			thisInventory.Items.Add(thisItem);//在物品栏中添加物品
		}
		else
		{
			thisItem.itemHeld++;//物品持有数量增加
		}
		InventoryManager.RefreshItem();
	}
    
}