using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace citiAppSystem
{
   public class Reports
    {
       public class Rows
       {
           public static void addRows(DataTable dt1)
           {

               int rowsToAdd = 24 - dt1.Rows.Count;

               for (int x = 0; x < rowsToAdd; x++)
               {
                   DataRow a_Rows = dt1.NewRow();
                   for (int y = 0; y < dt1.Columns.Count; y++)
                   {
                       a_Rows[y] = DBNull.Value;
                   }
                  
                   dt1.Rows.Add(a_Rows);
               }
           }

           public static void addRows12(DataTable dt2)
           {

               int rowsToAdd = 13 - dt2.Rows.Count;

               for (int x = 0; x < rowsToAdd; x++)
               {
                   DataRow a_Rows = dt2.NewRow();
                   for (int y = 0; y < dt2.Columns.Count; y++)
                   {
                       a_Rows[y] = DBNull.Value;
                   }

                   dt2.Rows.Add(a_Rows);
               }
           }
       }
    }
}
