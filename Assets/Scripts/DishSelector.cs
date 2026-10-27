using UnityEngine;

public class DishSelector : MonoBehaviour
{
    [Tooltip("3D dish objects, in the same order as the menu cards.")]
    [SerializeField] private GameObject[] dishes;

    public void ShowDish(int index)
    {
        if (dishes == null || index < 0 || index >= dishes.Length)
        {
            Debug.LogWarning($"DishSelector: no dish assigned for index {index}.", this);
            return;
        }

        for (int i = 0; i < dishes.Length; i++)
        {
            if (dishes[i] != null)
                dishes[i].SetActive(i == index);
        }
    }

    public void HideAll()
    {
        if (dishes == null) return;
        foreach (var dish in dishes)
            if (dish != null) dish.SetActive(false);
    }
}
