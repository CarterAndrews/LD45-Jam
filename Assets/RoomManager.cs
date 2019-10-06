using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomManager : MonoBehaviour
{
    public List<tileType> rooms;
    public static RoomManager instance;
    public GameObject customer;
    public float schedulingDelay;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        foreach(tileType r in rooms)
        {
            if (!r.occupied)
            {
                StartCoroutine(bookRoom(r));
                
            }
        }
    }
    public IEnumerator bookRoom(tileType stay)
    {
        print("booked room");
        stay.occupied = true;
        var guest = Instantiate(customer, stay.position, Quaternion.identity);
        yield return new WaitForSeconds(stay.time);
        stay.cost=stay.cost;//add price here    
        FindObjectOfType<Try1>().addMoney((int) stay.cost);
        Destroy(guest);
        yield return new WaitForSeconds(schedulingDelay);
        stay.occupied = false;
    }
    public void addRoom(tileType type)
    {
        rooms.Add(type);
        print("adding room");
    }
}
