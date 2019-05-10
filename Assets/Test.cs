using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour
{
    // Use this for initialization
    private void Start()
    {
        //配列を初期化する
        int[] array = { 9, 6, 3, 1, 0 };

        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }
        for (int i = 4; i >= 0; i--)
        {
                Debug.Log(array[i]);
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
