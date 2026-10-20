using UnityEngine;

public class Mediaadapter : Media
{
    /*
        Heredando del Holder de los datos, aca podremos diversificar
        Usando los #if (plataforma usada)
    
        Esto sirve, para cuando va enfocado a diferentes plataformas
        Haciendo que si se ejecuta en esa plataforma actue de la manera esperada
    */

#if UNITY_PS3
{
    // Aca guardaria los datos de las Hojas quemadas, de la manera especifica para esta consola
}
#endif
}
