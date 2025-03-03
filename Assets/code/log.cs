using UnityEngine;

public class KeyInputLogger : MonoBehaviour
{
    void Update()
    {
        if (Input.anyKeyDown) 
        {
            foreach (KeyCode key in System.Enum.GetValues(typeof(KeyCode))) 
            {
                if (Input.GetKeyDown(key)) 
                {
                    Debug.Log("Key Pressed: " + key);
                }
            }
        }
    }
}