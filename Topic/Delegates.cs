using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;


namespace DataStructureAlgorithm.Topic
{
    public class MathUnits
    {
        public static int Add(int x, int y)=> x + y;        
        public static int Substract(int x, int y) => x - y;

    }

    public delegate int MathOperation(int x, int y);

    //implementation
    public static class MainDelegate
    {
        public static MathOperation addition = MathUnits.Add;
        public static MathOperation deduction = MathUnits.Substract;
       
    }

}
