using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update

    [GUIColor(0.3f, 0.8f, 0.8f, 1)]
    public int num;

    [GUIColor("GetButtonColor")]
    [ButtonGroup]
    private void MDebug()
    {
        Debug.LogError(111);
    }

    private static Color GetButtonColor()
    {
        Sirenix.Utilities.Editor.GUIHelper.RequestRepaint();
        return Color.HSVToRGB(Mathf.Cos((float)UnityEditor.EditorApplication.timeSinceStartup + 1f) * 0.225f + 0.325f, 1, 1);
    }

    void Start()
    {
        Debug.LogError(11);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
