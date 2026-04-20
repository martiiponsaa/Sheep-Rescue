using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;


public class QuitButton : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData) // 1
    {
        Application.Quit(); // 2
    }

}
