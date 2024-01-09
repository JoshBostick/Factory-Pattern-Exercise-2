using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public class SQLDataAcess : IDataAccess
    {
        
        public void LoadData()
        {
            Console.WriteLine("Data is loading from SQLDataAccess class");
        }
        public void SaveData()
        {
            Console.WriteLine("Data is saving to SQLDataAccess class");
        }
    }
}
