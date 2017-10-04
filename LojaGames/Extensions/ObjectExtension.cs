using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LojaGames
{
    public static class ObjectExtension
    {
        public static T Cast<T>(this object Data)
        {
            T RET = (T)Activator.CreateInstance(typeof(T));

            foreach (var P in RET.GetType().GetProperties())
            {
                if (Data.GetType().GetProperty(P.Name) != null)
                    P.SetValue(RET, Data.GetType().GetProperty(P.Name).GetValue(Data));
            }

            return RET;
        }
    }
}