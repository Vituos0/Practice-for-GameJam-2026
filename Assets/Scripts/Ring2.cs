using System.Collections.Generic; // Cần thêm thư viện này để dùng List
using UnityEngine;


public class Ring : MonoBehaviour
{
    public GameObject piecePrefab;
    public float rotationSpeed = 100f;
    public Color[] energyColors;

    void Start()
    {
        GenerateRing();
    }

    void Update()
    {
        transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
    }

    private void GenerateRing()
    {
        // 1. Tạo một danh sách các chỉ số màu (0, 1, 2, 3, 4)
        List<int> colorIndices = new List<int>();
        for (int i = 0; i < energyColors.Length; i++)
        {
            colorIndices.Add(i);
        }

        // 2. Trộn ngẫu nhiên danh sách chỉ số này (Shuffle)
        for (int i = 0; i < colorIndices.Count; i++)
        {
            int temp = colorIndices[i];
            int randomIndex = Random.Range(i, colorIndices.Count);
            colorIndices[i] = colorIndices[randomIndex];
            colorIndices[randomIndex] = temp;
        }

        // 3. Sinh 4 mảnh và lấy 4 chỉ số đầu tiên từ danh sách đã trộn
        for (int i = 0; i < 4; i++)
        {
            GameObject piece = Instantiate(piecePrefab, transform);
            piece.transform.localPosition = Vector3.zero;
            piece.transform.localRotation = Quaternion.Euler(0, 0, i * 90f);

            // Lấy chỉ số màu đã được trộn
            int colorIndex = colorIndices[i];

            var data = piece.GetComponent<ColorSegmentData>();
            if (data != null)
            {
                // Gán màu và Tier dựa trên chỉ số duy nhất
                data.SetSegment((EnergyTier)(colorIndex + 1), energyColors[colorIndex]);
            }
        }
    }
}