using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; // เพิ่มไลบรารีนี้เพื่อเข้าถึง UI

public class Levelchanger : MonoBehaviour
{
    public Animator animator;
    public Button button; // เพิ่มตัวแปร Button เพื่อเชื่อมต่อกับปุ่ม UI

    private int levelToLoad;

    void Start()
    {
        // เชื่อมต่อฟังก์ชัน FadeToLevel กับฟังก์ชัน OnClick ของปุ่ม UI
        button.onClick.AddListener(FadeToNextLevel);
    }

    public void FadeToLevel(int levelIndex)
    {
        levelToLoad = levelIndex;
        animator.SetTrigger("Fadeout");
    }

    // เมื่อการเฟดเสร็จสิ้น (animation) เรียกใช้ฟังก์ชันนี้
    public void OnFadeComplete()
    {
        SceneManager.LoadScene(levelToLoad);
    }

    // สร้างฟังก์ชันที่จะเรียกเมื่อปุ่มถูกคลิก
    public void FadeToNextLevel()
    {
        FadeToLevel(2); // กำหนดให้เป็นการโหลดเลเวลที่ 1 ในที่นี้
    }
}
