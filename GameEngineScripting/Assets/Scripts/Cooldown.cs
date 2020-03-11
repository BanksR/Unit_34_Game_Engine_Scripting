using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Cooldown : MonoBehaviour
{

    public string CoolDownName = "";

    [TextArea(5, 10)]
    public string CoolDownDescription = "";

    [Space]

    public float CoolDownTime = 5;
    public Sprite CoolDownSprite;

    public bool CoolingDown = false;

    // Here we create some reference to the UI components we need to create our cooldown
    private Image[] _imageComponents;
    private Slider _coolDownSlider;
    private Button _coolDownButton;
    private Text _coolDownCountdonw;

    #region Awake
    private void Awake()
    {
        // Search our Cooldown Gameobject for Image components to add to
        // our Image array
        _imageComponents = GetComponentsInChildren<Image>();

        foreach (Image i in _imageComponents)
        {
            // We then loop thru them all and assign our cooldown sprite to them...
            i.sprite = CoolDownSprite;
        }

        // Assiging references for our Slider and setting the value
        _coolDownSlider = GetComponentInChildren<Slider>();
        _coolDownSlider.value = 0;
        

        // Assigning references for our button and setting the assiciated
        // Function to trigger...
        _coolDownButton = GetComponentInChildren<Button>();
        // The AddListener function is a Unity Event and calls the specified function when clicked
        _coolDownButton.onClick.AddListener(OnButtonClicked);


        // Getting references to our text countdown display
        _coolDownCountdonw = GetComponentInChildren<Text>();
        _coolDownCountdonw.text = Mathf.RoundToInt(CoolDownTime).ToString();
        _coolDownCountdonw.enabled = false;
        
    }
    #endregion // Here we gather our Component references and init our variables


    // This is the function we call when we press our button
    public void OnButtonClicked()
    {

        if (!CoolingDown)
        {
            // If we are NOT currently on Cooldown, start the CoRoutine
            StartCoroutine(StartCoolDown());
        }
        else
        {
            return;
        }
    }

    #region CoRoutine
    // This Coroutine is responsible for counting down and updating our UI elements
    IEnumerator StartCoolDown()
    {
        CoolingDown = true;
        _coolDownSlider.value = CoolDownTime / CoolDownTime;
        _coolDownCountdonw.enabled = true;
        _coolDownCountdonw.text = CoolDownTime.ToString();
        

        float t = 0;
        while (t < CoolDownTime)
        {
            _coolDownSlider.value = 1 - (t / CoolDownTime);
            _coolDownCountdonw.text = Mathf.RoundToInt(CoolDownTime - t).ToString();

            t += Time.deltaTime;
            yield return null;
        }

        _coolDownCountdonw.enabled = false;
        _coolDownSlider.value = 0f;
        CoolingDown = false;
        yield return null;
    }
    #endregion

}
