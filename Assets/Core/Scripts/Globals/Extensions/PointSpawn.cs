using UnityEngine;

public class PointSpawn
{
    public static Vector3 GetRandomPoint(Renderer renderer, PointGenerationType generationType)
    {
        Vector3 planeSize = renderer.bounds.size;
        Vector3 planeCenter = renderer.bounds.center;

        if (generationType == PointGenerationType.Edge)
        {
            Vector3 topLeft = new Vector3(planeCenter.x - planeSize.x / 2, planeCenter.y + planeSize.y / 2,
                planeCenter.z);
            Vector3 topRight = new Vector3(planeCenter.x + planeSize.x / 2, planeCenter.y + planeSize.y / 2,
                planeCenter.z);
            Vector3 bottomLeft = new Vector3(planeCenter.x - planeSize.x / 2, planeCenter.y - planeSize.y / 2,
                planeCenter.z);
            Vector3 bottomRight = new Vector3(planeCenter.x + planeSize.x / 2, planeCenter.y - planeSize.y / 2,
                planeCenter.z);

            return GetRandomPointOnEdge(topLeft, topRight, bottomLeft, bottomRight);
        }
        else if (generationType == PointGenerationType.Random)
        {
            float randomX = Random.Range(planeCenter.x - planeSize.x / 2, planeCenter.x + planeSize.x / 2);
            float randomY = Random.Range(planeCenter.y - planeSize.y / 2, planeCenter.y + planeSize.y / 2);
            float randomZ = Random.Range(planeCenter.z - planeSize.z / 2, planeCenter.z + planeSize.z / 2);

            return new Vector3(randomX, randomY, randomZ);
        }

        return Vector3.zero;
    }

    private static Vector3 GetRandomPointOnEdge(Vector3 topLeft, Vector3 topRight, Vector3 bottomLeft,
        Vector3 bottomRight)
    {
        float randomPercentage = Random.Range(0f, 1f);

        Vector3 randomPoint = Vector3.Lerp(Vector3.Lerp(bottomLeft, bottomRight, randomPercentage),
            Vector3.Lerp(topLeft, topRight, randomPercentage),
            randomPercentage);

        return randomPoint;
    }
}