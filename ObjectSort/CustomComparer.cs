using System;
using System.Collections.Generic;

namespace CustomObjectSort
{
    public class CustomComparer : IComparer<Object>
    {
        public int Compare(Object first, Object second)
        {
            //Compare to sort in this order:
            // ModelA
            // ModelB
            // Model C

            var result = 1;
            if (first.GetType().GetProperty("ItemModel").GetValue(first, null) == null && second.GetType().GetProperty("ItemModel").GetValue(second, null) == null)
            {
                result = 0;
            }
            if (first.GetType().GetProperty("ItemModel").GetValue(first, null) == second.GetType().GetProperty("ItemModel").GetValue(second, null))
            {
                result = 0;
            }
            else if (first.GetType().GetProperty("ItemModel").GetValue(first, null) is ModelA && second.GetType().GetProperty("ItemModel").GetValue(second, null) is not ModelA)
            {
                result = - 1;
            }
            else if (first.GetType().GetProperty("ItemModel").GetValue(first, null) is ModelB && second.GetType().GetProperty("ItemModel").GetValue(second, null) is not ModelB)
            {
                result = -1;
            }
            else if(first.GetType().GetProperty("ItemModel").GetValue(first, null) is ModelC && second.GetType().GetProperty("ItemModel").GetValue(second, null) is not ModelC )
            {
                result = -1;
            }

            return result;
        }
    }
}
