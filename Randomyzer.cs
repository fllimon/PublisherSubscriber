using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublisherSubscriberProj
{
    class Randomyzer
    {
        #region ======----- PRIVATE DATA ------======

        private Random _random;
        private static Randomyzer _instance = null;

        #endregion

        #region =====----- PRIVATE CTOR -----=====

        private Randomyzer()
        {
            _random = new Random();
        }

        #endregion

        public double[] GetRandomInitialize(double[] source)
        {
            for (int i = 0; i < source.Length; i++)
            {
                source[i] =_random.Next(DefaultSettings.DEFAULT_MIN_RANDOM_VALUE,
                    DefaultSettings.DEFAULT_MAX_RANDOM_VALUE);
            }

            return source;
        }

        public static Randomyzer GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Randomyzer();
            }

            return _instance;
        }
    }
}
