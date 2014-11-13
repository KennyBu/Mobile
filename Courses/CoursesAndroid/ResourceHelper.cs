using System.Collections.Generic;

namespace CoursesAndroid
{
    public static class ResourceHelper
    {
        static readonly Dictionary<string,int> ResourceDictionary = new Dictionary<string, int>();
        
        public static int TranslateDrawable(string drawableName)
         {
             var resourceValue = -1;

             //Ugly Mapping
             
             switch (drawableName)
             {
                 case "jimwilson":
                     resourceValue = Resource.Drawable.jimwilson;
                     break;
                 case "johnpapa":
                     resourceValue = Resource.Drawable.johnpapa;
                     break;
                 case "johnsonmez":
                     resourceValue = Resource.Drawable.johnsonmez;
                     break;
                 case "julieyack":
                     resourceValue = Resource.Drawable.julieyack;
                     break;
             }
             
             return resourceValue;
         }

         public static int TranslateDrawableWithReflection(string drawableName)
         {
            int resourceValue;
            if (ResourceDictionary.ContainsKey(drawableName))
            {
                resourceValue = ResourceDictionary[drawableName];
                return resourceValue;
            }
             
            var drawableType = typeof(Resource.Drawable);
            var resourceFieldInfo = drawableType.GetField(drawableName);

            resourceValue = (int) resourceFieldInfo.GetValue(null);
            ResourceDictionary.Add(drawableName, resourceValue);

             return resourceValue;
         }
    }
}