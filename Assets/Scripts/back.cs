using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class back : MonoBehaviour
{
    public Button backbutton;
    private GameObject PlayCube;
    private float x;
    private float y;
    // Start is called before the first frame update
    void Start()
    {
        PlayCube = GameObject.Find("PlayCube");
        PlayCube.transform.GetChild(0).localPosition = new Vector3(0F, 0F, -createobj.pocketheight / 2 - 0.0005F);  //FrontWall
        PlayCube.transform.GetChild(0).localScale = new Vector3(createobj.pocketwidth, createobj.pocketdepth, 0.001F);
        PlayCube.transform.GetChild(1).localPosition = new Vector3(0F, -createobj.pocketdepth / 2 - 0.0005F, 0F);  //BaseWall
        PlayCube.transform.GetChild(1).localScale = new Vector3(createobj.pocketwidth, 0.001F, createobj.pocketheight);
        PlayCube.transform.GetChild(2).localPosition = new Vector3(0F, createobj.pocketdepth / 2 + 0.0005F, 0F);  //TopWall
        PlayCube.transform.GetChild(2).localScale = new Vector3(createobj.pocketwidth, 0.001F, createobj.pocketheight);
        PlayCube.transform.GetChild(3).localPosition = new Vector3(createobj.pocketwidth / 2 + 0.0005F, 0F, 0F);   //RightWall
        PlayCube.transform.GetChild(3).localScale = new Vector3(0.001F, createobj.pocketdepth, createobj.pocketheight);
        PlayCube.transform.GetChild(4).localPosition = new Vector3(0F, 0F, createobj.pocketheight / 2 + 0.0005F);  //BackWall
        PlayCube.transform.GetChild(4).localScale = new Vector3(createobj.pocketwidth, createobj.pocketdepth, 0.001F);
        PlayCube.transform.GetChild(5).localPosition = new Vector3(-createobj.pocketwidth / 2 - 0.0005F, 0F, 0F);  //LeftWall
        PlayCube.transform.GetChild(5).localScale = new Vector3(0.001F, createobj.pocketdepth, createobj.pocketheight);
        PlayCube.transform.GetChild(6).localPosition = new Vector3(0F, 0F, 0F);  //Box
        PlayCube.transform.GetChild(6).localScale = new Vector3(createobj.itemwidth, createobj.itemdepth, createobj.itemheight);
        Button btn3 = backbutton.GetComponent<Button>();
        btn3.onClick.AddListener(ChgbackScene);
    }

    // Update is called once per frame
    void ChgbackScene()
    {
        SceneManager.LoadScene("mainmenu");
    }

    void Update()
    {
        if (SystemInfo.supportsAccelerometer)
        {
            float x = 3 * Input.acceleration.y;
            float y = 3 * -Input.acceleration.x;
            PlayCube.transform.Rotate(x, y, 0);
        }
        else
        {
            float x = 5 * Input.GetAxis("Mouse X");
            float y = 5 * -Input.GetAxis("Mouse Y");
            PlayCube.transform.Rotate(x, y, 0);
        }
       
    }

}
