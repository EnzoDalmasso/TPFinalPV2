using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class MenuManager : MonoBehaviour
{
    [SerializeField] private Slider mySlider;
    [SerializeField] private Toggle myToggle;
    [SerializeField] private TMP_InputField myInput;

    // Start is called before the first frame update
    void Start()
    {
        mySlider.value = PersistenceManager.Instance.GetFloat("MusicVolumen");
        myToggle.isOn = PersistenceManager.Instance.GetBool(PersistenceManager.KeyMusic);
        myInput.text = PersistenceManager.Instance.GetSring("UserName");
    }

    // Update is called once per frame
    private void OnDisable()
    {
        PersistenceManager.Instance.Save();
    }

    private void OnEnable()
    {
        PersistenceManager.Instance.SetInt("Puntaje", GameManager.Instance.GetScore());
    }
}
