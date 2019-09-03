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

    public static float pocketwidth = 1.13F;
    public static float pocketheight = 1.96F;
    public static float pocketdepth = 0.57F;
    public static float itemwidth = 1.008F;
    public static float itemheight = 1.832F;
    public static float itemdepth = 0.435F;
    public Button createbutton;
    public Button calbutton;
    private GameObject ItemCube;
    private GameObject IsoCube;
    private GameObject SideCube;
    private GameObject TopCube;
    private GameObject TopRot;
    private GameObject SideTilt;
    private GameObject SideRot;
    RaycastHit hit;
    private GameObject aallow;
    private GameObject ballow;
    private GameObject kallow;
    private GameObject atilt;
    private GameObject btilt;
    private GameObject ktilt;


    // Start is called before the first frame update
    void Start()
    {
        Button btn = createbutton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
        Button btn1 = calbutton.GetComponent<Button>();
        btn1.onClick.AddListener(CalThreshold);
        ItemCube = GameObject.Find("ItemCube");
        IsoCube = GameObject.Find("IsoCube");
        SideCube = GameObject.Find("SideCube");
        TopCube = GameObject.Find("TopCube");
        TopRot = GameObject.Find("TopRot");
        SideTilt = GameObject.Find("SideTilt");
        SideRot = GameObject.Find("SideRot");
        aallow = GameObject.Find("Aallowance");
        ballow = GameObject.Find("Ballowance");
        kallow = GameObject.Find("Kallowance");
        atilt = GameObject.Find("Atilt");
        btilt = GameObject.Find("Btilt");
        ktilt = GameObject.Find("Ktilt");
        pocketwidth_t.text = (pocketwidth).ToString();
        pocketheight_t.text = (pocketheight).ToString();
        pocketdepth_t.text = (pocketdepth).ToString();
        itemwidth_t.text = (itemwidth).ToString();
        itemheight_t.text = (itemheight).ToString();
        itemdepth_t.text = (itemdepth).ToString();
        TaskOnClick();


}
    //isometric rotation 30 60 30
    void TaskOnClick()
    {
        if (float.TryParse(pocketwidth_t.text, out pocketwidth)) { };
        if (pocketwidth > 0) { } else { pocketwidth = 1.13F; };
        if (float.TryParse(pocketheight_t.text, out pocketheight)) { };
        if (pocketheight > 0) { } else { pocketheight = 1.96F; };
        if (float.TryParse(pocketdepth_t.text, out pocketdepth)) { };
        if (pocketdepth > 0) { } else { pocketdepth = 0.57F; };
        if (float.TryParse(itemwidth_t.text, out itemwidth)) { };
        if (itemwidth > 0) { } else { itemwidth = 1.008F; };
        if (float.TryParse(itemheight_t.text, out itemheight)) { };
        if (itemheight > 0) { } else { itemheight = 1.832F; };
        if (float.TryParse(itemdepth_t.text, out itemdepth)) { };
        if (itemdepth > 0) { } else { itemdepth = 0.435F; };

        //BaseWall.transform.position = new Vector3(0F,-pocketdepth/2-0.0005F,0F);
        //BaseWall.transform.localScale = new Vector3(pocketwidth, 0.001F, pocketheight);
        IsoCube.transform.GetChild(0).localPosition = new Vector3(0F, 0F, -pocketheight / 2 - 0.0005F);  //FrontWall
        IsoCube.transform.GetChild(0).localScale = new Vector3(pocketwidth, pocketdepth, 0.001F);
        IsoCube.transform.GetChild(1).localPosition = new Vector3(0F, -pocketdepth / 2 - 0.0005F, 0F);  //BaseWall
        IsoCube.transform.GetChild(1).localScale = new Vector3(pocketwidth, 0.001F, pocketheight);
        IsoCube.transform.GetChild(2).localPosition = new Vector3(0F, pocketdepth / 2 + 0.0005F, 0F);  //TopWall
        IsoCube.transform.GetChild(2).localScale = new Vector3(pocketwidth, 0.001F, pocketheight);
        IsoCube.transform.GetChild(3).localPosition = new Vector3(pocketwidth / 2 + 0.0005F, 0F, 0F);   //RightWall
        IsoCube.transform.GetChild(3).localScale = new Vector3(0.001F, pocketdepth, pocketheight);
        IsoCube.transform.GetChild(4).localPosition = new Vector3(0F, 0F, pocketheight / 2 + 0.0005F);  //BackWall
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
        SideCube.transform.GetChild(6).GetComponent<Rigidbody>().AddForce(0F, 0F, -1F);

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
        TopCube.transform.GetChild(6).GetComponent<Rigidbody>().AddForce(-9.81F, 0F, 9.81F);

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
        TopRot.transform.GetChild(6).GetComponent<Rigidbody>().AddTorque(0F,1F,0F);

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
        SideTilt.transform.GetChild(6).GetComponent<Rigidbody>().AddTorque(0F, -1F, 0F);
        //SideTilt.transform.GetChild(6).GetComponent<Rigidbody>().AddForce(0F, 0F, 9.81F);

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
        SideRot.transform.GetChild(6).GetComponent<Rigidbody>().AddTorque(0F, -1F, 0F);
        //SideRot.transform.GetChild(6).GetComponent<Rigidbody>().AddForce(-9.81F, 0F, 0F);

    }

    void CalThreshold() {
        kallow.GetComponent<Text>().text = "Ko Allowance: " + (pocketdepth-itemdepth).ToString("F4") + "cm";
        aallow.GetComponent<Text>().text = "Ao Allowance: " + (pocketwidth - itemwidth).ToString("F4") + "cm";
        ballow.GetComponent<Text>().text = "Bo Allowance: " + (pocketheight - itemheight).ToString("F4") + "cm";

        if (Physics.Raycast(TopRot.transform.GetChild(0).TransformPoint(0F, 0F, -pocketheight/2), new Vector3(0F, 0F, 1F), out hit, Mathf.Infinity))
        {
            //Debug.DrawRay(TopRot.transform.GetChild(0).TransformPoint(0F, 0F, -pocketheight / 2), new Vector3(0F, 0F, 1F) * hit.distance,  Color.green,500F);
            //Debug.Log("Did Hit"+hit.distance);
            //Debug.Log(Vector3.Angle(hit.normal, new Vector3(0F, 0F, -1F)).ToString());
            //Debug.Log(hit.transform.eulerAngles.y);
            atilt.GetComponent<Text>().text = "Rotation: " + Vector3.Angle(hit.normal, new Vector3(0F, 0F, -1F)).ToString("F4") + "deg";
        }
        else
        {
            atilt.GetComponent<Text>().text = "Rotation Tilt: " + "ERR" + "deg";
        }

        //Debug.Log(SideTilt.transform.GetChild(1).TransformPoint(0, pocketdepth / 2, 0F));

        if (Physics.Raycast(SideTilt.transform.GetChild(1).TransformPoint(0, pocketdepth/2, 0F), new Vector3(0F, 0F, 1F), out hit, Mathf.Infinity))
        {
            Debug.DrawRay(SideTilt.transform.GetChild(1).TransformPoint(0F, pocketdepth/2, 0F), new Vector3(0F, 0F, 1F) * hit.distance,  Color.red,500F);
            btilt.GetComponent<Text>().text = "Bo Tilt: " + Vector3.Angle(hit.normal, new Vector3(0F, 0F, -1F)).ToString("F4") + "deg";
        }
        else
        {
            btilt.GetComponent<Text>().text = "Bo Tilt: " + "ERR" + "deg";
        }

        if (Physics.Raycast(SideRot.transform.GetChild(1).TransformPoint(0, pocketdepth / 2, 0F), new Vector3(0F, 0F, 1F), out hit, Mathf.Infinity))
        {
            Debug.DrawRay(SideRot.transform.GetChild(1).TransformPoint(0F, pocketdepth/2, 0F), new Vector3(0F, 0F, 1F) * hit.distance,  Color.red,500F);
            ktilt.GetComponent<Text>().text = "Ao Tilt: " + Vector3.Angle(hit.normal, new Vector3(0F, 0F, -1F)).ToString("F4") + "deg";
        }
        else
        {
            ktilt.GetComponent<Text>().text = "Ao Tilt: " + "ERR" + "deg";
        }


    }

}
