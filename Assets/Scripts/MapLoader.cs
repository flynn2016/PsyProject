﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public static class MapLoader
{
	public static Map ReadMap(int map_index)
	{
		int x_size;
		int y_size;
		int line_counter = 0;
		string temp;
		string path = "Assets/Maps/Map_" + map_index + ".txt";
		StreamReader reader = new StreamReader(path);
		if (reader.Peek() == '/') //eat comment
		{
			reader.ReadLine();
		}
        temp = reader.ReadLine();
		x_size = int.Parse(temp.Split()[0]);
		y_size = int.Parse(temp.Split()[1]);
        Map map = new Map(x_size, y_size);
        Debug.Log("here");

        while ((temp = reader.ReadLine()) != null)
		{
            if (!string.IsNullOrEmpty(temp))
            {
                string[] temp_string = temp.Split();
                for (int i = 0; i < Mathf.Max(map.y_size, map.x_size); i++)
                {
                    map.mapData[i + line_counter * x_size] = int.Parse(temp_string[i]);
                }
                line_counter++;
            }
		}
		reader.Close();
        return map;
	}
}

public struct Map
{
	public int x_size;
	public int y_size;
	public int[] mapData;

	public Map(int _x_size, int _y_size)
	{
		x_size = _x_size;
		y_size = _y_size;
		mapData = new int[x_size * y_size];
	}
}


