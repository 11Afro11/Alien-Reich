using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomCursor : MonoBehaviour {
    public Texture2D imagen; //Imagen asignada al cursor
    private CursorMode cursorMode = CursorMode.Auto; //Allow this cursor to render as a hardware cursor on supported platforms, or force software cursor
    private Vector2 hotSpot = Vector2.zero; //The offset from the top left of the texture to use as the target point (must be within the bounds of the cursor).
    private void Start()
    {
        Cursor.SetCursor(imagen, hotSpot, cursorMode);
    }
    //Al entrar el ratón en pantalla
    private void OnMouseEnter() {
        Cursor.SetCursor(imagen, hotSpot, cursorMode);
	}
    //Al salir el curosor de la pantalla
    private void OnMouseExit(){
        Cursor.SetCursor(null, Vector2.zero, cursorMode);
    }

}
