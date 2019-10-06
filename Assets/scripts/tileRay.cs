using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
[System.Serializable]
public class tileType
{
    public TileBase tile;
    public Sprite spr;
    public float cost;
    public float time;
    public bool occupied;
    public Vector3 position;
}
public class tileRay : MonoBehaviour
{
    public Tilemap tiles;
    public tileType placingBuilding;
    public SpriteRenderer mouseIcon;
    public TileBase airTile;
    public tileType[] tiletypes;
    public bool activePlacement;
    // Start is called before the first frame update
    void Start()
    {

    }
    
    public void changePlacingTile(tileType t)
    {
        placingBuilding =t;
        mouseIcon.sprite = t.spr;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            changePlacingTile(tiletypes[1]);
            activePlacement = true;
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            changePlacingTile(tiletypes[0]);
            activePlacement = true;
        }
        if (Input.GetMouseButton(1))
        {
            activePlacement = false;
            mouseIcon.sprite = null;
        }
        if (Input.GetMouseButtonDown(0)&&activePlacement)
        {
            Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition + new Vector3(0, 0, 10));
            var tile = tiles.GetTile(tiles.WorldToCell(pos));
            if (tile == airTile&&tiles.GetTile(tiles.WorldToCell(pos)+new Vector3Int(0,-1,0))!=airTile)
            {
                
                tiles.SetTile(tiles.WorldToCell(pos), placingBuilding.tile);
                
                var newRoom = new tileType();
                newRoom.position = tiles.CellToWorld(tiles.WorldToCell(pos));
                newRoom.cost = placingBuilding.cost;
                newRoom.time = placingBuilding.time;
                newRoom.occupied = false;
                RoomManager.instance.addRoom( newRoom);
            }
        }
    }
    
}
