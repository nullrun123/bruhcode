using UnityEngine;

public class ResetSpeed : MonoBehaviour
{
    void Start()
    {
        // กำหนดค่า speed ใน PlayerPrefs เป็น 3
        PlayerPrefs.SetFloat("Speed", 3f);
    }
}
