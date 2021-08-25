﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Bezier
{
    static Vector2 quadraticCurve(Vector2 a, Vector2 b, Vector2 c, float t)
    {
        Vector2 p1 = Vector2.Lerp(a, b, t);
        Vector2 p2 = Vector2.Lerp(b, c, t);

        return Vector2.Lerp(p1, p2, t);
    }

    public static Vector2 cubicCurve(Vector2 a, Vector2 b, Vector2 c, Vector2 d, float t)
    {
        Vector2 p1 = quadraticCurve(a, b, c, t);
        Vector2 p2 = quadraticCurve(b, c, d, t);

        return Vector2.Lerp(p1, p2, t);
    }
}
