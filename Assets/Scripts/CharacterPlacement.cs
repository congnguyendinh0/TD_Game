
using UnityEngine;


using UnityEngine.EventSystems;
public class CharacterPlacement : MonoBehaviour
{
        
    public Color hoverColor;
    public Vector3 positionOffset;
    
    //character reference
    private GameObject _gun;
    
    private Renderer _renderingComponent;
    private Color _startColor;

    private BuildOptions _buildOptions;
    // Start is called before the first frame update

    void Start()
    {
         
        _renderingComponent = GetComponent<Renderer>();
        _startColor = _renderingComponent.material.color;
        _buildOptions = BuildOptions.Ins;
    }
    private void OnMouseDown()
    {
        // pointeroverobj
        var pointerOverObj = EventSystem.current.IsPointerOverGameObject();
         
        if (pointerOverObj)
        {
            return;
        }
        
        if (_buildOptions.SelectCharacter() == null)
        {
            return;
        }
        if (_gun != null)
        {
            return;
        }

        GameObject character =_buildOptions.SelectCharacter();
        _gun = (GameObject) Instantiate(character, transform.position + positionOffset,  transform.rotation);

    }
    
    void OnMouseEnter()
    {
     
        
        // hover color
        _renderingComponent.material.color = hoverColor;
    }

    private void OnMouseExit()
    {
        _renderingComponent.material.color = _startColor;
    }

//Followed brackeys tutorial as allowed : https://www.youtube.com/watch?v=beuoNuK2tbk&list=PLPV2KyIb3jR4u5jX8za5iU1cqnQPmbzG0&index=1&ab_channel=Brackeys
}
