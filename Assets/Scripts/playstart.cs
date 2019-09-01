using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class playstart : MonoBehaviour
{
    public Button playbutton;
    // Start is called before the first frame update
    void Start()
    {
        Button btn2 = playbutton.GetComponent<Button>();
        btn2.onClick.AddListener(ChgScene);
    }

    // Update is called once per frame
    void ChgScene()
    {
        SceneManager.LoadScene("freeplay");
    }
}
