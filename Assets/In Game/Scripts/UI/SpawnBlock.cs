using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBlock : MonoBehaviour 
{
	public GameObject block;

	public void CreateBlock()
	{
		Instantiate(block, new Vector3(0, 0, 0), Quaternion.identity);
	}
}
