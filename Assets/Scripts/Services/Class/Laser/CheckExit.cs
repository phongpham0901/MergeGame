using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckExit : ICheckExit
{
    public void Check(GameObject gameObject, Collider2D collider2D)
    {
            for (int i = 1; i <= 3; i++)
            {
                string tagToCheck = i.ToString();
                if (collider2D.gameObject.CompareTag(tagToCheck))
                {
                    Time.timeScale = 0f;
                }
            }
    }

    public IEnumerator ActiveLaser(GameObject gameObject)
    {
        gameObject.SetActive(true); // Kích hoạt đối tượng
        yield return new WaitForSeconds(5f * Time.deltaTime); // Đợi 5 giây
        gameObject.SetActive(false); // Vô hiệu hóa đối tượng sau 5 giây
    }


}
