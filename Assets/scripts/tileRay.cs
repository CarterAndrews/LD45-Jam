using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
public class tileRay : MonoBehaviour
{
    public Tilemap tiles;
    public TileBase placingBuilding;
    public SpriteRenderer mouseIcon;
    public TileBase airTile;
    public tileType[] tiletypes;
    // Start is called before the first frame update
    void Start()
    {

    }
    [System.Serializable]
    public struct tileType{
        public TileBase tile;
        public Sprite spr;
    }
    public void changePlacingTile(tileType t)
    {
        placingBuilding = t.tile;
        mouseIcon.sprite = t.spr;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            changePlacingTile(tiletypes[1]);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            changePlacingTile(tiletypes[0]);
        }
        if (Input.GetMouseButton(1))
        {
            placingBuilding = null;
        }
        if (Input.GetMouseButtonDown(0)&&placingBuilding!=null)
        {
            Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition + new Vector3(0, 0, 10));
            var tile = tiles.GetTile(tiles.WorldToCell(pos));
            if (tile == airTile&&tiles.GetTile(tiles.WorldToCell(pos)+new Vector3Int(0,-1,0))!=airTile)
            {
                tiles.SetTile(tiles.WorldToCell(pos), placingBuilding);
            }
        }
    }
    
}
