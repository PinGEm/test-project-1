using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using static UnityEngine.GraphicsBuffer;

public class TakeABreakMenu : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        print("I was clicked");
        int randomXPosition = Random.Range(-150, 150);
        int randomYPosition = Random.Range(-150, 150);
        Debug.Log("y value is : " + randomYPosition + "\n\rx value is: " + randomXPosition);

        transform.localPosition = new Vector2(randomXPosition, randomYPosition);
    }
}
