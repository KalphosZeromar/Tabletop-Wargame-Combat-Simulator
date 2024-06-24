using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Warhammer_Combat_Simulator
{
    class mathcore
    {
        public float shoot(float n, float m)
        {
            Console.WriteLine(n + m);
            float output = n * m;
            Console.WriteLine(output);
            return output;
        }
        public float shootplusrrhit(float n, float m)
        {
            float output = n*(2-n);//hit part
            output = m * output;//wound part
            return output;
        }
        public float shootplusrrwound(float n, float m)
        {
            float output = n;
            output = output*(m*(2-m));
            return output;
        }
        public float shootplusrrfull(float n, float m)
        {
            float output = n * (2 - n);//hit part
            output = output * (m * (2 - m));//wound part
            return output;
        }
    }
}