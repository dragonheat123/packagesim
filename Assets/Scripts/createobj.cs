using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class createobj : MonoBehaviour
{
    public InputField pocketwidth_t;
    public InputField pocketheight_t;
    public InputField pocketdepth_t;
    public InputField itemwidth_t;
    public InputField itemheight_t;
    public InputField itemdepth_t;
    public static float pocketwidth = 1.0F;
    public static float pocketheight = 1.0F;
    public static float pocketdepth = 1.0F;
    public static float itemwidth = 0.5F;
    public static float itemheight = 0.5F;
    public static float itemdepth = 0.5F;
    public Button createbutton;
    private GameObject LeftWall;
    private GameObject RightWall;
    private GameObject TopWall;
    private GameObject BackWall;
    private GameObject FrontWall;
    private GameObject BaseWall;
    private GameObject ItemCube;
    private GameObject IsoCube;
    private GameObject SideCube;
    private GameObject TopCube;
    private GameObject TopRot;
    private GameObject SideTilt;
    private GameObject SideRot;


    // Start is called before the first frame update
    void Start()
    {
        Button btn = createbutton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
        LeftWall = GameObject.Find("LeftWall");
        RightWall = GameObject.Find("RightWall");
        TopWall = GameObject.Find("TopWall");
        BackWall = GameObject.Find("BackWall");
        FrontWall = GameObject.Find("FrontWall");
        BaseWall = GameObject.Find("BaseWall");
        ItemCube = GameObject.Find("ItemCube");
        IsoCube = GameObject.Find("IsoCube");
        SideCube = GameObject.Find("SideCube");
        TopCube = GameObject.Find("TopCube");
        TopRot = GameObject.Find("TopRot");
        SideTilt = GameObject.Find("SideTilt");
        SideRot = GameObject.Find("SideRot");
        
    }
    //isometric rotation 30 60 30
    void TaskOnClick()
    {
        if (float.TryParse(pocketwidth_t.text, out pocketwidth)) { };
        if (float.TryParse(pocketheight_t.text, out pocketheight)) { };
        if (float.TryParse(pocketdepth_t.text, out pocketdepth)) { };
        if (float.TryParse(itemwidth_t.text, out itemwidth)) { };
        if (float.TryParse(itemheight_t.text, out itemheight)) { };
        if (float.TryParse(itemdepth_t.text, out itemdepth)) { };

        //BaseWall.transform.position = new Vector3(0F,-pocketdepth/2-0.0005F,0F);
        //BaseWall.transform.localScale = new Vector3(pocketwidth, 0.001F, pocketheight);
        IsoCube.transform.GetChild(0).localPosition = new Vector3(0F, 0F, -pocketheight/2-0.0005F);  //FrontWall
        IsoCube.transform.GetChild(0).localScale = new Vector3(pocketwidth, pocketdepth, 0.001F);
        IsoCube.transform.GetChild(1).localPosition = new Vector3(0F, -pocketdepth / 2 - 0.0005F, 0F);  //BaseWall
        IsoCube.transform.GetChild(1).localScale = new Vector3(pocketwidth, 0.001F, pocketheight);
        IsoCube.transform.GetChild(2).localPosition = new Vector3(0F, pocketdepth / 2 + 0.0005F, 0F);  //TopWall
        IsoCube.transform.GetChild(2).localScale = new Vector3(pocketwidth, 0.001F, pocketheight);
        IsoCube.transform.GetChild(3).localPosition = new Vector3(pocketwidth/2+0.0005F, 0F, 0F);   //RightWall
        IsoCube.transform.GetChild(3).localScale = new Vector3(0.001F, pocketdepth, pocketheight);
        IsoCube.transform.GetChild(4).localPosition = new Vector3(0F, 0F, pocketheight/2+0.0005F);  //BackWall
        IsoCube.transform.GetChild(4).localScale = new Vector3(pocketwidth, pocketdepth, 0.001F);  
        IsoCube.transform.GetChild(5).localPosition = new Vector3(-pocketwidth / 2 - 0.0005F, 0F, 0F);  //LeftWall
        IsoCube.transform.GetChild(5).localScale = new Vector3(0.001F, pocketdepth, pocketheight);
        IsoCube.transform.GetChild(6).localPosition = new Vector3(0F, 0F, 0F);  //Box
        IsoCube.transform.GetChild(6).localScale = new Vector3(itemwidth, itemdepth, itemheight);

        SideCube.transform.GetChild(0).localPosition = new Vector3(0F, 0F, -pocketheight / 2 - 0.0005F);  //FrontWall
        SideCube.transform.GetChild(0).localScale = new Vector3(pocketwidth, pocketdepth, 0.001F);
        SideCube.transform.GetChild(1).localPosition = new Vector3(0F, -pocketdepth / 2 - 0.0005F, 0F);  //BaseWall
        SideCube.transform.GetChild(1).localScale = new Vector3(pocketwidth, 0.001F, pocketheight);
        SideCube.transform.GetChild(2).localPosition = new Vector3(0F, pocketdepth / 2 + 0.0005F, 0F);  //TopWall
        SideCube.transform.GetChild(2).localScale = new Vector3(pocketwidth, 0.001F, pocketheight);
        SideCube.transform.GetChild(3).localPosition = new Vector3(pocketwidth / 2 + 0.0005F, 0F, 0F);   //RightWall
        SideCube.transform.GetChild(3).localScale = new Vector3(0.001F, pocketdepth, pocketheight);
        SideCube.transform.GetChild(4).localPosition = new Vector3(0F, 0F, pocketheight / 2 + 0.0005F);  //BackWall
        SideCube.transform.GetChild(4).localScale = new Vector3(pocketwidth, pocketdepth, 0.001F);
        SideCube.transform.GetChild(5).localPosition = new Vector3(-pocketwidth / 2 - 0.0005F, 0F, 0F);  //LeftWall
        SideCube.transform.GetChild(5).localScale = new Vector3(0.001F, pocketdepth, pocketheight);
        SideCube.transform.GetChild(6).localPosition = new Vector3(0F, 0F, 0F);  //Box
        SideCube.transform.GetChild(6).localScale = new Vector3(itemwidth, itemdepth, itemheight);

        TopCube.transform.GetChild(0).localPosition = new Vector3(0F, 0F, -pocketheight / 2 - 0.0005F);  //FrontWall
        TopCube.transform.GetChild(0).localScale = new Vector3(pocketwidth, pocketdepth, 0.001F);
        TopCube.transform.GetChild(1).localPosition = new Vector3(0F, -pocketdepth / 2 - 0.0005F, 0F);  //BaseWall
        TopCube.transform.GetChild(1).localScale = new Vector3(pocketwidth, 0.001F, pocketheight);
        TopCube.transform.GetChild(2).localPosition = new Vector3(0F, pocketdepth / 2 + 0.0005F, 0F);  //TopWall
        TopCube.transform.GetChild(2).localScale = new Vector3(pocketwidth, 0.001F, pocketheight);
        TopCube.transform.GetChild(3).localPosition = new Vector3(pocketwidth / 2 + 0.0005F, 0F, 0F);   //RightWall
        TopCube.transform.GetChild(3).localScale = new Vector3(0.001F, pocketdepth, pocketheight);
        TopCube.transform.GetChild(4).localPosition = new Vector3(0F, 0F, pocketheight / 2 + 0.0005F);  //BackWall
        TopCube.transform.GetChild(4).localScale = new Vector3(pocketwidth, pocketdepth, 0.001F);
        TopCube.transform.GetChild(5).localPosition = new Vector3(-pocketwidth / 2 - 0.0005F, 0F, 0F);  //LeftWall
        TopCube.transform.GetChild(5).localScale = new Vector3(0.001F, pocketdepth, pocketheight);
        TopCube.transform.GetChild(6).localPosition = new Vector3(0F, 0F, 0F);  //Box
        TopCube.transform.GetChild(6).localScale = new Vector3(itemwidth, itemdepth, itemheight);

        TopRot.transform.GetChild(0).localPosition = new Vector3(0F, 0F, -pocketheight / 2 - 0.0005F);  //FrontWall
        TopRot.transform.GetChild(0).localScale = new Vector3(pocketwidth, pocketdepth, 0.001F);
        TopRot.transform.GetChild(1).localPosition = new Vector3(0F, -pocketdepth / 2 - 0.0005F, 0F);  //BaseWall
        TopRot.transform.GetChild(1).localScale = new Vector3(pocketwidth, 0.001F, pocketheight);
        TopRot.transform.GetChild(2).localPosition = new Vector3(0F, pocketdepth / 2 + 0.0005F, 0F);  //TopWall
        TopRot.transform.GetChild(2).localScale = new Vector3(pocketwidth, 0.001F, pocketheight);
        TopRot.transform.GetChild(3).localPosition = new Vector3(pocketwidth / 2 + 0.0005F, 0F, 0F);   //RightWall
        TopRot.transform.GetChild(3).localScale = new Vector3(0.001F, pocketdepth, pocketheight);
        TopRot.transform.GetChild(4).localPosition = new Vector3(0F, 0F, pocketheight / 2 + 0.0005F);  //BackWall
        TopRot.transform.GetChild(4).localScale = new Vector3(pocketwidth, pocketdepth, 0.001F);
        TopRot.transform.GetChild(5).localPosition = new Vector3(-pocketwidth / 2 - 0.0005F, 0F, 0F);  //LeftWall
        TopRot.transform.GetChild(5).localScale = new Vector3(0.001F, pocketdepth, pocketheight);
        TopRot.transform.GetChild(6).localPosition = new Vector3(0F, 0F, 0F);  //Box
        TopRot.transform.GetChild(6).localScale = new Vector3(itemwidth, itemdepth, itemheight);

        SideTilt.transform.GetChild(0).localPosition = new Vector3(0F, 0F, -pocketheight / 2 - 0.0005F);  //FrontWall
        SideTilt.transform.GetChild(0).localScale = new Vector3(pocketwidth, pocketdepth, 0.001F);
        SideTilt.transform.GetChild(1).localPosition = new Vector3(0F, -pocketdepth / 2 - 0.0005F, 0F);  //BaseWall
        SideTilt.transform.GetChild(1).localScale = new Vector3(pocketwidth, 0.001F, pocketheight);
        SideTilt.transform.GetChild(2).localPosition = new Vector3(0F, pocketdepth / 2 + 0.0005F, 0F);  //TopWall
        SideTilt.transform.GetChild(2).localScale = new Vector3(pocketwidth, 0.001F, pocketheight);
        SideTilt.transform.GetChild(3).localPosition = new Vector3(pocketwidth / 2 + 0.0005F, 0F, 0F);   //RightWall
        SideTilt.transform.GetChild(3).localScale = new Vector3(0.001F, pocketdepth, pocketheight);
        SideTilt.transform.GetChild(4).localPosition = new Vector3(0F, 0F, pocketheight / 2 + 0.0005F);  //BackWall
        SideTilt.transform.GetChild(4).localScale = new Vector3(pocketwidth, pocketdepth, 0.001F);
        SideTilt.transform.GetChild(5).localPosition = new Vector3(-pocketwidth / 2 - 0.0005F, 0F, 0F);  //LeftWall
        SideTilt.transform.GetChild(5).localScale = new Vector3(0.001F, pocketdepth, pocketheight);
        SideTilt.transform.GetChild(6).localPosition = new Vector3(0F, 0F, 0F);  //Box
        SideTilt.transform.GetChild(6).localScale = new Vector3(itemwidth, itemdepth, itemheight);

        SideRot.transform.GetChild(0).localPosition = new Vector3(0F, 0F, -pocketheight / 2 - 0.0005F);  //FrontWall
        SideRot.transform.GetChild(0).localScale = new Vector3(pocketwidth, pocketdepth, 0.001F);
        SideRot.transform.GetChild(1).localPosition = new Vector3(0F, -pocketdepth / 2 - 0.0005F, 0F);  //BaseWall
        SideRot.transform.GetChild(1).localScale = new Vector3(pocketwidth, 0.001F, pocketheight);
        SideRot.transform.GetChild(2).localPosition = new Vector3(0F, pocketdepth / 2 + 0.0005F, 0F);  //TopWall
        SideRot.transform.GetChild(2).localScale = new Vector3(pocketwidth, 0.001F, pocketheight);
        SideRot.transform.GetChild(3).localPosition = new Vector3(pocketwidth / 2 + 0.0005F, 0F, 0F);   //RightWall
        SideRot.transform.GetChild(3).localScale = new Vector3(0.001F, pocketdepth, pocketheight);
        SideRot.transform.GetChild(4).localPosition = new Vector3(0F, 0F, pocketheight / 2 + 0.0005F);  //BackWall
        SideRot.transform.GetChild(4).localScale = new Vector3(pocketwidth, pocketdepth, 0.001F);
        SideRot.transform.GetChild(5).localPosition = new Vector3(-pocketwidth / 2 - 0.0005F, 0F, 0F);  //LeftWall
        SideRot.transform.GetChild(5).localScale = new Vector3(0.001F, pocketdepth, pocketheight);
        SideRot.transform.GetChild(6).localPosition = new Vector3(0F, 0F, 0F);  //Box
        SideRot.transform.GetChild(6).localScale = new Vector3(itemwidth, itemdepth, itemheight);




    }
}
