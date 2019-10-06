using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
public class tileRay : MonoBehaviour
{
    public Tilemap tiles;
    public TileBase placingBuilding;
    public TileBase tent;
    public TileBase suite;
    public SpriteRenderer mouseIcon;
    public TileBase airTile;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void changePlacingTile(TileBase newTileType)
    {
        placingBuilding = newTileType;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            changePlacingTile(tent);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            changePlacingTile(suite);
        }
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition + new Vector3(0, 0, 10));
            var tile = tiles.GetTile(tiles.WorldToCell(pos));
            if (tile == airTile&&tiles.GetTile(tiles.WorldToCell(pos)+new Vector3Int(0,-1,0))!=airTile)
            {
                tiles.SetTile(tiles.WorldToCell(pos), placingBuilding);
            }
            print(tile);
        }
    }
    
}
