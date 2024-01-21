using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_15
{
    interface ISeries
    {
        void setStart(int x);
        int getNext();
        void reset();

    }

    class ArithProgression : ISeries
    {
        int step;
        int startValue;
        int currentValue;
        public int getNext()
        {
            currentValue+=step;
            return currentValue;
        }
        public void setStart(int x)
        {
            startValue = x;
        }
        public void reset()
        {
            currentValue = startValue;
        }
        public void setStep(int s)
        {
            step = s;
            currentValue = startValue;
        }
    }
    class GeomProgression
    {
        int step;
        int startValue;
        int currentValue;
        public int getNext()
        {
            currentValue *= step;
            return currentValue;
        }
        public void setStart(int x)
        {
            startValue = x;
        }
        public void reset()
        {
            currentValue = startValue;
        }
        public void setStep(int s)
        {
            step = s;
            currentValue = startValue;
        }
    }
}