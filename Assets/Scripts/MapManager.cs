using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class MapManager : MonoBehaviour
{
    public Transform crop_parent;
    public Transform farm_1_parent;
    public Transform farm_2_parent;
    public Transform farm_3_parent;
    public Transform farm_4_parent;
    public Transform farm_5_parent;
    public Transform farm_6_parent;

    public GameObject tile_ground;
    public GameObject tile_grass;
    public GameObject tile_mudpatch;
    public GameObject tile_u;
    public GameObject tile_d;
    public GameObject tile_l;
    public GameObject tile_r;
    public GameObject tile_h;

    public GameObject crop_1;
    public GameObject crop_2;
    public GameObject crop_3;

    public int map_index;
    Map currentMap;

    private void Start()
    {
        
    }

    public void DeleteMap()
    {
        while (transform.childCount != 0)
        {
            DestroyImmediate(transform.GetChild(0).gameObject);
        }

        while (crop_parent.childCount != 0)
        {
            DestroyImmediate(crop_parent.GetChild(0).gameObject);
        }

        while (farm_1_parent.childCount != 0)
        {
            DestroyImmediate(farm_1_parent.GetChild(0).gameObject);
        }

        while (farm_2_parent.childCount != 0)
        {
            DestroyImmediate(farm_2_parent.GetChild(0).gameObject);
        }

        while (farm_3_parent.childCount != 0)
        {
            DestroyImmediate(farm_3_parent.GetChild(0).gameObject);
        }

        while (farm_4_parent.childCount != 0)
        {
            DestroyImmediate(farm_4_parent.GetChild(0).gameObject);
        }

        while (farm_5_parent.childCount != 0)
        {
            DestroyImmediate(farm_5_parent.GetChild(0).gameObject);
        }

        while (farm_6_parent.childCount != 0)
        {
            DestroyImmediate(farm_6_parent.GetChild(0).gameObject);
        }
    }

    public void GenerateMap()
    {
        currentMap = MapLoader.ReadMap(map_index);

        for (int y = 0; y < currentMap.y_size; y++)
        {
            for (int x = 0; x < currentMap.x_size; x++)
            {
                if (currentMap.mapData[x + y * currentMap.x_size] == 1)
                {
                    GameObject temp_tile = Instantiate(tile_ground, new Vector3(1.45f * x, 0, 1.45f * y), Quaternion.identity, this.transform);
                    temp_tile.name = "Ground " + x + " " + y;
                }
                else if (currentMap.mapData[x + y * currentMap.x_size] == 0)
                {
                    GameObject temp_tile = Instantiate(tile_grass, new Vector3(1.45f * x, 0, 1.45f * y), Quaternion.identity, this.transform);
                    temp_tile.name = "Grass " + x + " " + y;
                }

                else if (currentMap.mapData[x + y * currentMap.x_size] == 5)
                {
                    GameObject temp_tile = Instantiate(tile_h, new Vector3(1.45f * x, 0, 1.45f * y), Quaternion.identity, this.transform);
                    temp_tile.transform.eulerAngles = new Vector3(0,90,0);
                    temp_tile.name = "Grass " + x + " " + y;
                }

                else if (currentMap.mapData[x + y * currentMap.x_size] == 6)
                {
                    GameObject temp_tile = Instantiate(tile_u, new Vector3(1.45f * x, 0, 1.45f * y), Quaternion.identity, this.transform);
                    temp_tile.name = "Grass " + x + " " + y;
                }

                else if (currentMap.mapData[x + y * currentMap.x_size] == 7)
                {
                    GameObject temp_tile = Instantiate(tile_d, new Vector3(1.45f * x, 0, 1.45f * y), Quaternion.identity, this.transform);
                    temp_tile.name = "Grass " + x + " " + y;
                }

                else if (currentMap.mapData[x + y * currentMap.x_size] == 8)
                {
                    GameObject temp_tile = Instantiate(tile_l, new Vector3(1.45f * x, 0, 1.45f * y), Quaternion.identity, this.transform);
                    temp_tile.name = "Grass " + x + " " + y;
                }

                else if (currentMap.mapData[x + y * currentMap.x_size] == 9)
                {
                    GameObject temp_tile = Instantiate(tile_r, new Vector3(1.45f * x, 0, 1.45f * y), Quaternion.identity, this.transform);
                    temp_tile.name = "Grass " + x + " " + y;
                }

                else if (currentMap.mapData[x + y * currentMap.x_size] == 2)
                {
                    if (x < 6)
                    {
                        GameObject temp_tile;
                        if (y < 10)
                        {
                            temp_tile = Instantiate(tile_mudpatch, new Vector3(1.45f * x, 0, 1.45f * y), Quaternion.identity, farm_1_parent);
                            temp_tile.name = "MudPatch " + x + " " + y;
                        }
                        else
                        {
                            temp_tile = Instantiate(tile_mudpatch, new Vector3(1.45f * x, 0, 1.45f * y), Quaternion.identity, farm_2_parent);
                            temp_tile.name = "MudPatch " + x + " " + y;
                        }
                            Instantiate(crop_1, new Vector3(temp_tile.transform.position.x + 0.3f, 0, temp_tile.transform.position.z + 0.3f), Quaternion.identity, crop_parent);
                            Instantiate(crop_1, new Vector3(temp_tile.transform.position.x + 0.3f, 0, temp_tile.transform.position.z - 0.3f), Quaternion.identity, crop_parent);
                            Instantiate(crop_1, new Vector3(temp_tile.transform.position.x - 0.3f, 0, temp_tile.transform.position.z + 0.3f), Quaternion.identity, crop_parent);
                            Instantiate(crop_1, new Vector3(temp_tile.transform.position.x - 0.3f, 0, temp_tile.transform.position.z - 0.3f), Quaternion.identity, crop_parent);          
                    }

                    else if (x > 6 && x < 10) {

                        GameObject temp_tile;
                        if (y < 10)
                        {
                            temp_tile = Instantiate(tile_mudpatch, new Vector3(1.45f * x, 0, 1.45f * y), Quaternion.identity, farm_3_parent);
                            temp_tile.name = "MudPatch " + x + " " + y;
                        }
                        else
                        {
                            temp_tile = Instantiate(tile_mudpatch, new Vector3(1.45f * x, 0, 1.45f * y), Quaternion.identity, farm_4_parent);
                            temp_tile.name = "MudPatch " + x + " " + y;
                        }
                        Instantiate(crop_2, new Vector3(temp_tile.transform.position.x + 0.3f, 0, temp_tile.transform.position.z + 0.3f), Quaternion.identity, crop_parent);
                        Instantiate(crop_2, new Vector3(temp_tile.transform.position.x - 0.3f, 0, temp_tile.transform.position.z - 0.3f), Quaternion.identity, crop_parent);
                        
                    }

                    else if (x > 10)
                    {
                        GameObject temp_tile;
                        if (y < 10)
                        {
                            temp_tile = Instantiate(tile_mudpatch, new Vector3(1.45f * x, 0, 1.45f * y), Quaternion.identity, farm_5_parent);
                            temp_tile.name = "MudPatch " + x + " " + y;
                        }
                        else
                        {
                            temp_tile = Instantiate(tile_mudpatch, new Vector3(1.45f * x, 0, 1.45f * y), Quaternion.identity, farm_6_parent);
                            temp_tile.name = "MudPatch " + x + " " + y;
                        }
                        Instantiate(crop_3, new Vector3(temp_tile.transform.position.x , 0, temp_tile.transform.position.z), Quaternion.identity, crop_parent);
                    }
                }
            }
        }
    }
}
