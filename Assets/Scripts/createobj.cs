using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createobj : MonoBehaviour
{
	public int pocketwidth;
	public int pocketheight;
	public int pocketdepth;
	public int itemheight;
	public int itemwidth;
	public int itemdepth;
	
    // Start is called before the first frame update
    void Start()
    {
        pocketwidth = GameObject.Find("pocket_width_t").Text;
	pocketheight = GameObject.Find("pocket_height_t").Text;
	pocketdepth = GameObject.Find("pocket_depth_t").Text;
	itemheight = GameObject.Find("item_height_t").Text;
	itemwidth = GameObject.Find("item_width_t").Text;
	itemdepth= GameObject.Find("item_depth_t").Text;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
