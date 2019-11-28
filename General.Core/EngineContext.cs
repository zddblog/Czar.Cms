using System.Runtime.CompilerServices;

namespace General.Core
{
    public class EngineContext
    {
        private static IEngin _engin;

        [MethodImpl(MethodImplOptions.Synchronized)]
        public static IEngin Initialize(IEngin engin)
        {
            if (_engin == null)
                _engin = engin;
            return engin;
        }

        /// <summary>
        /// 当前引擎
        /// </summary>
        public static IEngin Current
        {
            get
            {
                return _engin;
            }
        }
    }
}
