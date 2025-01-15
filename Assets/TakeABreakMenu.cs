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
        int randomXPosition = Random.Range(-400, 400);
        int randomYPosition = Random.Range(-400, 400);
        Debug.Log("y value is : " + randomYPosition + "\n\rx value is: " + randomXPosition);

        transform.localPosition = new Vector2(randomXPosition, randomYPosition);
    }
}
