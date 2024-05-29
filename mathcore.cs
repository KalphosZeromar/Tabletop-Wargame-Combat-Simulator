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
        float shoot(float n, float m)
        {
            float output = n * m;
            return output;
        }
        float shootplusrrhit(float n, float m)
        {
            float output = n*(2-n);//hit part
            output = m * output;//wound part
            return output;
        }
        float shootplusrrwound(float n, float m)
        {
            float output = n;
            output = output*(m*(2-m));
            return output;
        }
        float shootplusrrfull(float n, float m)
        {
            float output = n * (2 - n);//hit part
            output = output * (m * (2 - m));//wound part
            return output;
        }
    }
}