﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class BasicDot : TileItem
{

  private void Awake() {
    GameObject child = transform.GetChild(0).gameObject;
    child.GetComponent<Renderer>().material.color =  ColorSchema.GetColor(dotColor);
  }

  public override TileItem GetItemFromItem()
  {
    tileSlot.ObtainNewTileItem();
    return this;
  }

  public override void OnClearItem()
  {
    tileSlot.ObtainNewTileItem();
		Destroy(this.gameObject);
  }

  public override void DrawItemGizmo(Vector3 position)
  {
    Gizmos.color = ColorSchema.GetColor(dotColor);
    Gizmos.DrawWireSphere(position, transform.localScale.x / 2);
  }

}