using UnityEngine;
using TMPro;

public class PlantCountUI : MonoBehaviour
{
    [SerializeField] private TMP_Text _plantedText;
    [SerializeField] private TMP_Text _remainingText;

    [SerializeField] private TMP_Text _annoucement;

    public void UpdateSeeds (int seedsLeft, int seedsPlanted)
    {
        _plantedText.text = "Seeds Planted: " + seedsPlanted;
        _remainingText.text = "Remaining Seeds: " + seedsLeft;
    }

    public void Annoucing ()
    {
        _annoucement.gameObject.SetActive(true);
    }
}