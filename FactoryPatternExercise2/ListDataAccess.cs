using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public class ListDataAccess : IDataAccess
    {
        public void LoadData() 
        {
            Console.WriteLine("Data is loading from ListDataAccess class");
        }
        public void SaveData()
        {
            Console.WriteLine("Data is saving to ListDataAccess class");
        }
    }
}
