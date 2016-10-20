using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiChannelQueuing
{
    static class DataFlowManipulation
    {
        static public List<string[]> convertToList(DataGridView data)
        {
            List<string[]> s = new List<string[]>();

            for (int i = 0; i < data.Rows.Count-1; i++)
            {
                string[] si = new string[data.Columns.Count];

                for (int j = 0; j < data.ColumnCount; j++)
                {
                    si[j] = data.Rows[i].Cells[j].Value.ToString();
                }
                s.Add(si);
            }
            MessageBox.Show(Convert.ToString(data.Rows.Count));
            return s;
        }
    }
}
