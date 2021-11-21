namespace Corgibytes.Freshli.Lib.Util
{
    public static class VersionHelper
    {
        // TODO: Seems like there should be a class/method provided by the runtime that would do this for us
        public static int CompareNumericValues(long? v1, long? v2)
        {
            if (v1 == v2)
            {
                return 0;
            }
            if (v1 > v2)
            {
                return 1;
            }
            if (v1 != null && v2 == null)
            {
                return 1;
            }
            return -1;
        }

    }
}
