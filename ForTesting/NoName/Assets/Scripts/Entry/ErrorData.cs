using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
/// <summary> </summary>
public static class ErrorData
{
    public static void LogError(uint errorNunber)
    {
        if (errorNunber == 1)
        {
            Debug.Log(LoadError);
        }
    }

    private static string LoadError = "Неверный порядок загрузки скриптов/ отсутствие скриптов в очереди загрузки";
}
